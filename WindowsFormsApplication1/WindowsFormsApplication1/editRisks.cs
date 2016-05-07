using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class editRisks : Form
    {
        public editRisks()
        {
            InitializeComponent();
        }

        private void editRisks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

            try
            {
                riskIDComboBox.Text = side_menu.rdgv.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No entry selected");
                this.Close();
                return;
            }

            updateEditComboBoxes();
            fillControls();
        }

        public void updateEditComboBoxes()
        {
            riskCategoryComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Category] FROM [Table]");
            statusComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Status] FROM [Table]");
            responsiblePersonComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Responsible Person] FROM [Table]");
            statusAfterTextBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Status After] FROM [Table]");

            riskCategoryComboBox.SelectedItem = null;
            statusComboBox.SelectedItem = null;
            responsiblePersonComboBox.SelectedItem = null;
            statusAfterTextBox.SelectedItem = null;
        }

        private void fillControls()
        {
            String[] selectedRiskInfo = Program.queryDatabase(Program.risksConnectionString, "SELECT * FROM [Table] WHERE ID = '" + riskIDComboBox.Text + "'")[0].Split(Program.fieldSeparationCharacter);

            dateTimePicker.Value = Convert.ToDateTime(selectedRiskInfo[1]);
            nextRevisionDateTimePicker.Value = Convert.ToDateTime(selectedRiskInfo[2]);
            riskCategoryComboBox.Text = selectedRiskInfo[3];
            descriptionTextBox.Text = selectedRiskInfo[4];
            probabilityComboBox.Text = selectedRiskInfo[5];
            consequenceComboBox.Text = selectedRiskInfo[6];
            statusComboBox.Text = selectedRiskInfo[7];
            evaluationTextBox.Text = selectedRiskInfo[8];
            controlMeasureTextBox.Text = selectedRiskInfo[9];
            riskResponseTextBox.Text = selectedRiskInfo[10];
            responsiblePersonComboBox.Text = selectedRiskInfo[11];
            probabilityAfterComboBox.Text = selectedRiskInfo[12];
            consequenceAfterComboBox.Text = selectedRiskInfo[13];
            statusAfterTextBox.Text = selectedRiskInfo[14];
            evaluationAfterTextBox.Text = selectedRiskInfo[15];
            lastModifiedByLabel.Text = "Last modified by " + selectedRiskInfo[16] + " on " + Convert.ToDateTime(selectedRiskInfo[17]).ToString("dd/MM/yyyy");
        }

        private void riskIDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillControls();
        }

        private void editRiskButton_Click(object sender, EventArgs e)
        {
            int value;

            if (riskCategoryComboBox.Text.Trim().Equals("") || descriptionTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must assign a category and add a description to the risk.");
                return;
            }

            if (!int.TryParse(probabilityComboBox.Text, out value) || !int.TryParse(consequenceComboBox.Text, out value) ||
                !int.TryParse(evaluationTextBox.Text, out value) || !int.TryParse(probabilityAfterComboBox.Text, out value) ||
                !int.TryParse(consequenceAfterComboBox.Text, out value) || !int.TryParse(evaluationAfterTextBox.Text, out value))
            {
                MessageBox.Show("The values of probability, consequence and evaluation can only be numbers.");
                return;
            }

            bool isEdited = Program.editDatabase(Program.risksConnectionString, createEditCommand());

            if(!isEdited)
            {
               MessageBox.Show("Failed to edit, wrong format.");
                return;
            }

            MessageBox.Show("Risk edited");

            descriptionTextBox.Clear();
            probabilityComboBox.SelectedItem = null;
            consequenceComboBox.SelectedItem = null;
            evaluationTextBox.Clear();
            controlMeasureTextBox.Clear();
            riskResponseTextBox.Clear();
            probabilityAfterComboBox.SelectedItem = null;
            consequenceAfterComboBox.SelectedItem = null;
            evaluationAfterTextBox.Clear();
            riskIDComboBox.ResetText();
            lastModifiedByLabel.Text = null;

            Program.updateDataGridView(Program.risksConnectionString, side_menu.rdgv, side_menu.tbs);
            side_menu.updateAddComboBoxes();
            updateEditComboBoxes();

            //this.Close();
        }

        private String createEditCommand()
        {
            //"UPDATE [Table] SET [Date] = '" + dateTimePicker.Value.ToShortDateString() +
            //                            "', [Next Revision] = '" + nextRevisionDateTimePicker.Value.ToShortDateString() +
            //                            "', [Category] = '" + riskCategoryComboBox.Text +
            //                            "', [Description] = '" + descriptionTextBox.Text +
            //                            "', [Probability] = '" + probabilityComboBox.Text +
            //                            "', [Consequence] = '" + consequenceComboBox.Text +
            //                            "', [Status] = '" + statusComboBox.Text +
            //                            "', [Evaluation] = '" + evaluationComboBox.Text +
            //                            "', [Control Measure] = '" + controlMeasureTextBox.Text +
            //                            "', [Response] = '" + riskResponseTextBox.Text +
            //                            "', [Responsible Person] = '" + responsiblePersonComboBox.Text +
            //                            "', [Probability After] = '" + probabilityAfterComboBox.Text +
            //                            "', [Consequence After] = '" + consequenceAfterComboBox.Text +
            //                            "', [Status After] = '" + statusAfterComboBox.Text +
            //                            "', [Evaluation After] = '" + evaluationAfterComboBox.Text + "'" +
            //                            "WHERE ID = '" + riskIDComboBox.Text + "'"

            String sqlComm = "UPDATE [Table] SET [Date] = '" + dateTimePicker.Value.ToShortDateString() + "'" + 
                                              ", [Next Revision] = '" + nextRevisionDateTimePicker.Value.ToShortDateString() + "'";

            if (!probabilityComboBox.Text.Equals(""))
                sqlComm += ", [Probability] = '" + probabilityComboBox.Text + "'";
            if (!consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Consequence] = '" + consequenceComboBox.Text + "'";
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation] = '" + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text)) + "'";
            if (!controlMeasureTextBox.Text.Trim().Equals(""))
                sqlComm += ", [Control Measure] = '" + controlMeasureTextBox.Text + "'";
            if (!riskResponseTextBox.Text.Trim().Equals(""))
                sqlComm += ", [Response] = '" + riskResponseTextBox.Text + "'";
            if (!responsiblePersonComboBox.Text.Trim().Equals(""))
                sqlComm += ", [Responsible Person] = '" + responsiblePersonComboBox.Text + "'";
            if (!probabilityAfterComboBox.Text.Equals(""))
                sqlComm += ", [Probability After] = '" + probabilityAfterComboBox.Text + "'";
            if (!consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Consequence After] = '" + consequenceAfterComboBox.Text + "'";
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation After] = '" + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text)) + "'";
            if (!statusAfterTextBox.Text.Equals(""))
                sqlComm += ", [Status] = '" + statusAfterTextBox.Text + "'";

            sqlComm += ", [Last Modified By] = '" + side_menu.username + "'" + 
                       ", [Last Modified Date] = '" + DateTime.Now.ToShortDateString() + "'" +
                       " WHERE ID = '" + riskIDComboBox.Text + "'";

            return sqlComm;
        }

        private void computeEvaluationFields(object sender, EventArgs e)
        {
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                evaluationTextBox.Text = "" + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text));
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                evaluationAfterTextBox.Text = "" + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text));
        }
    }
}
