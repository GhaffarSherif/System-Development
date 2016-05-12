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
            catch (System.NullReferenceException) // Checks if a row was selected when the form was opened.
            {
                MessageBox.Show("No entry selected");
                this.Close();
                return;
            }

            try
            {
                updateEditComboBoxes();
                fillControls();
            }
            catch(System.ArgumentOutOfRangeException) // Checks if a row was selected when the form was opened.
            {
                MessageBox.Show("No entry selected");
                this.Close();
                return;
            }
        }

        // Updates the items in the comboBoxes of the edit risk form with distinct column values from the database. 
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

        // Fills the controls in the form with the data of the selected risk's ID.
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

            // Checks if the required fields are filled.
            if (riskCategoryComboBox.Text.Trim().Equals("") || descriptionTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must assign a category and add a description to the risk.");
                return;
            }

            // Validates int data type for certain fields.
            if (!int.TryParse(probabilityComboBox.Text, out value) || !int.TryParse(consequenceComboBox.Text, out value) ||
                !int.TryParse(evaluationTextBox.Text, out value) || !int.TryParse(probabilityAfterComboBox.Text, out value) ||
                !int.TryParse(consequenceAfterComboBox.Text, out value) || !int.TryParse(evaluationAfterTextBox.Text, out value))
            {
                MessageBox.Show("The values of probability, consequence and evaluation can only be numbers.");
                return;
            }

            bool isEdited = Program.editDatabase(Program.risksConnectionString, createEditCommand());

            // Checks if an error occured when editing the database.
            if(!isEdited)
            {
               MessageBox.Show("Failed to edit, wrong format.");
               return;
            }

            // Successfully edited the database.
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

        // Creates and returns the update SQL command depending on which fields are filled.
        private String createEditCommand()
        {
            // The default update SQL command for columns of required fields.
            String sqlComm = "UPDATE [Table] SET [Date] = '" + dateTimePicker.Value.ToString("MM/dd/yyyy") + "'" +
                                              ", [Next Revision] = '" + nextRevisionDateTimePicker.Value.ToString("MM/dd/yyyy") + "'" +
                                              ", [Category] = '" + riskCategoryComboBox.Text + "'" +
                                              ", [Description] = '" + descriptionTextBox.Text + "'";

            // Add more columns to update if the designated fields are filled.
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

            // Add the last required fields to update and the condition determining the row to update.
            sqlComm += ", [Last Modified By] = '" + side_menu.username + "'" +
                       ", [Last Modified Date] = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'" +
                       " WHERE ID = '" + riskIDComboBox.Text + "'";

            return sqlComm;
        }

        // Computes the evaluation and evaluation after fields using the formula consequence * probability.
        private void computeEvaluationFields(object sender, EventArgs e)
        {
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                evaluationTextBox.Text = "" + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text));
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                evaluationAfterTextBox.Text = "" + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text));
        }
    }
}
