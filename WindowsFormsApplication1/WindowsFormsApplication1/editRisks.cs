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

            riskIDComboBox.Text = side_menu.rdgv.SelectedRows[0].Cells[0].Value.ToString();
            
            fillControls();
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
            evaluationComboBox.Text = selectedRiskInfo[8];
            controlMeasuresTextBox.Text = selectedRiskInfo[9];
            riskResponseTextBox.Text = selectedRiskInfo[10];
            responsiblePersonTextBox.Text = selectedRiskInfo[11];
            probabilityAfterComboBox.Text = selectedRiskInfo[12];
            consequenceAfterComboBox.Text = selectedRiskInfo[13];
            statusAfterComboBox.Text = selectedRiskInfo[14];
            evaluationAfterComboBox.Text = selectedRiskInfo[15];
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
                !int.TryParse(evaluationComboBox.Text, out value) || !int.TryParse(probabilityAfterComboBox.Text, out value) ||
                !int.TryParse(consequenceAfterComboBox.Text, out value) || !int.TryParse(evaluationAfterComboBox.Text, out value))
            {
                MessageBox.Show("The values of probability, consequence and evaluation can only be numbers.");
                return;
            }

            Program.editDatabase(Program.risksConnectionString,
                                        "UPDATE [Table] SET [Date] = '" + dateTimePicker.Value.ToShortDateString() +
                                        "', [Next Revision] = '" + nextRevisionDateTimePicker.Value.ToShortDateString() +
                                        "', [Category] = '" + riskCategoryComboBox.Text +
                                        "', [Description] = '" + descriptionTextBox.Text +
                                        "', [Probability] = '" + probabilityComboBox.Text +
                                        "', [Consequence] = '" + consequenceComboBox.Text +
                                        "', [Status] = '" + statusComboBox.Text +
                                        "', [Evaluation] = '" + evaluationComboBox.Text +
                                        "', [Control Measure] = '" + controlMeasuresTextBox.Text +
                                        "', [Response] = '" + riskResponseTextBox.Text +
                                        "', [Responsible Person] = '" + responsiblePersonTextBox.Text +
                                        "', [Probability After] = '" + probabilityAfterComboBox.Text +
                                        "', [Consequence After] = '" + consequenceAfterComboBox.Text +
                                        "', [Status After] = '" + statusAfterComboBox.Text +
                                        "', [Evaluation After] = '" + evaluationAfterComboBox.Text + "'" +
                                        "WHERE ID = '" + riskIDComboBox.Text + "'");
               //if(!isEdited)
               //{
               //    MessageBox.Show("Failed to edit, wrong format.");
               //    return;
               //}

            MessageBox.Show("Risk edited");

            descriptionTextBox.Clear();
            probabilityComboBox.ResetText();
            consequenceComboBox.ResetText();
            statusComboBox.ResetText();
            probabilityComboBox.ResetText();
            consequenceComboBox.ResetText();
            evaluationAfterComboBox.ResetText();
            controlMeasuresTextBox.Clear();
            riskResponseTextBox.Clear();
            responsiblePersonTextBox.Clear();
            probabilityAfterComboBox.ResetText();
            consequenceAfterComboBox.ResetText();
            statusAfterComboBox.ResetText();
            probabilityAfterComboBox.ResetText();
            consequenceAfterComboBox.ResetText();
            evaluationAfterComboBox.ResetText();
            riskIDComboBox.ResetText();

            Program.updateDataGridView(Program.risksConnectionString, side_menu.rdgv);

        }




    }
}
