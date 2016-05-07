using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class side_menu : Form
    {
        settings s;
        filterList f;
        editRisks v;

        public static String username;
        public static String userType;

        public static List<String> filters = new List<String>();

        public static BindingSource tbs;
        public static DataGridView rdgv;
        public static ComboBox filterValue;

        List<String> dateNumbCompare;
        List<String> textCompare;

        public side_menu()
        {
            InitializeComponent();

            tbs = tableBindingSource;
            rdgv = risksDataGridView;
            filterValue = filterValueComboBox;

            username = Program.userInfo.Split(Program.fieldSeparationCharacter)[0];
            userType = Program.userInfo.Split(Program.fieldSeparationCharacter)[2];

            userLabel.Text = username;
            if (!userType.Equals("Admin"))
            {
                tabControl1.TabPages.Remove(addRiskTabPage);
                filterMenuStrip.Items.Remove(editRiskToolStripMenuItem);
                filterMenuStrip.Items.Remove(deleteRiskToolStripMenuItem);
                settingsButton.Visible = false;
            }

            dateNumbCompare = new List<String> {
                "=", ">", ">=", "<", "<="
            };

            textCompare = new List<String> {
                "=", "LIKE", "NOT LIKE"
            };

            filterTypeComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME  = 'Table'");
        }

        private void side_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
            updateRiskID();

            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
            filterValueComboBox.ResetText();

            risksDataGridView.Columns["Probability"].HeaderCell.Style.BackColor = Program.customColors[0];
            risksDataGridView.Columns["Consequence"].HeaderCell.Style.BackColor = Program.customColors[0];
            risksDataGridView.Columns["Status"].HeaderCell.Style.BackColor = Program.customColors[0];
            risksDataGridView.Columns["Evaluation"].HeaderCell.Style.BackColor = Program.customColors[0];
            risksDataGridView.Columns["ControlMeasure"].HeaderCell.Style.BackColor = Program.customColors[1];
            risksDataGridView.Columns["Response"].HeaderCell.Style.BackColor = Program.customColors[1];
            risksDataGridView.Columns["ResponsiblePerson"].HeaderCell.Style.BackColor = Program.customColors[1];
            risksDataGridView.Columns["ProbabilityAfter"].HeaderCell.Style.BackColor = Program.customColors[2];
            risksDataGridView.Columns["ConsequenceAfter"].HeaderCell.Style.BackColor = Program.customColors[2];
            risksDataGridView.Columns["StatusAfter"].HeaderCell.Style.BackColor = Program.customColors[2];
            risksDataGridView.Columns["EvaluationAfter"].HeaderCell.Style.BackColor = Program.customColors[2];
            risksDataGridView.EnableHeadersVisualStyles = false;
        }

        private void side_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["settings"] != null)
                s.Close();

            s = new settings();
            s.Show();
        }

        private void viewFiltersButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["filterList"] != null)
                f.Close();

            f = new filterList();
            f.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["settings"] != null)
                s.Close();
            if (Application.OpenForms["filterList"] != null)
                f.Close();

            Dispose(true);
            Close();

            new login().Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewFiltersButton_Click(sender, e);
        }

        private void addRiskButton_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Basic risk information not completed", "Risk could not be added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEdited = Program.editDatabase(Program.risksConnectionString, createAddCommand());

            if(!isEdited)
            {
                MessageBox.Show("Invalid input format", "Risk could not be added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Risk added successfully", "Risk added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateTimePicker.ResetText();
            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
            descriptionTextBox.Clear();
            probabilityComboBox.SelectedItem = null;
            consequenceComboBox.SelectedItem = null;
            statusComboBox.ResetText();
            controlMeasureTextBox.Clear();
            riskResponseTextBox.Clear();
            responsiblePersonTextBox.Clear();
            probabilityAfterComboBox.SelectedItem = null;
            consequenceAfterComboBox.SelectedItem = null;
            statusAfterComboBox.ResetText();

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
            updateRiskID();
        }

        private bool validateFields()
        {
            if (riskCategoryComboBox.Text.Equals("") || descriptionTextBox.Text.Equals(""))
                return false;

            return true;
        }

        private String createAddCommand()
        {
            String sqlComm = "INSERT INTO [Table] ([Date], [Next Revision], [Category], [Description]";

            if (!probabilityComboBox.Text.Equals(""))
                sqlComm += ", [Probability]";
            if (!consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Consequence]";
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation]";
            if (!controlMeasureTextBox.Text.Equals(""))
                sqlComm += ", [Control Measure]";
            if (!riskResponseTextBox.Text.Equals(""))
                sqlComm += ", [Response]";
            if (!responsiblePersonTextBox.Text.Equals(""))
                sqlComm += ", [Responsible Person]";
            if (!probabilityAfterComboBox.Text.Equals(""))
                sqlComm += ", [Probability After]";
            if (!consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Consequence After]";
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation After]";
            if (!statusAfterComboBox.Text.Equals(""))
                sqlComm += ", [Status After]";

            sqlComm += ") ";


            sqlComm += "VALUES ('" + dateTimePicker.Value.ToShortDateString() + "', '" 
            + nextRevisionDateTimePicker.Value.ToShortDateString() + "', '" 
            + riskCategoryComboBox.Text + "', '"
            + descriptionTextBox.Text;

            if (!probabilityComboBox.Text.Equals(""))
                sqlComm += "', '" + probabilityComboBox.Text;
            if (!consequenceComboBox.Text.Equals(""))
                sqlComm += "', '" + consequenceComboBox.Text;
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                sqlComm += "', '" + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text));
            if (!controlMeasureTextBox.Text.Equals(""))
                sqlComm += "', '" + controlMeasureTextBox.Text;
            if (!riskResponseTextBox.Text.Equals(""))
                sqlComm += "', '" + riskResponseTextBox.Text;
            if (!responsiblePersonTextBox.Text.Equals(""))
                sqlComm += "', '" + responsiblePersonTextBox.Text;
            if (!probabilityAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + probabilityAfterComboBox.Text;
            if (!consequenceAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + consequenceAfterComboBox.Text;
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text));
            if (!statusAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + statusAfterComboBox.Text;

            sqlComm += "')";

            return sqlComm;
        }

        private void updateRiskID()
        {
            riskIDTextBox.Text = "" + (Convert.ToInt32(Program.queryDatabase(Program.risksConnectionString, "SELECT IDENT_CURRENT('Table')")[0].Split(Program.fieldSeparationCharacter)[0]) + 1);
        }

        private void editRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["editRisks"] != null)
                v.Close();

            v = new editRisks();
            v.Show();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            if(filterTypeComboBox.Text.Equals("") || filterValueComboBox.Text.Equals(""))
            {
                MessageBox.Show("Filter value not specified", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filterTypeComboBox.Text.Equals("Date") || filterTypeComboBox.Text.Equals("Next Revision"))
                filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + Convert.ToDateTime(filterValueComboBox.Text));
            else
                filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + "'" + filterValueComboBox.Text + "'");
            
            if (Application.OpenForms["filterList"] != null)
            {
                f.filters.DataSource = null;
                f.filters.DataSource = filters;
            }

            try
            {
                filterDataGridView();
                filterValueComboBox.ResetText();
            }
            catch (System.Data.EvaluateException)
            {
                filters.RemoveAt(filters.Count - 1);
                MessageBox.Show("Invalid filter value", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            filters = new List<String>();
          
            if (Application.OpenForms["filterList"] != null)
            {
                f.filters.DataSource = null;
                f.filters.DataSource = filters;
            }

            tableBindingSource.Filter = null;
            risksDataGridView.DataSource = tableBindingSource;
            filterValueComboBox.ResetText();
        }

        public static void filterDataGridView()
        {
            if (side_menu.filters.Count == 0)
            {
                side_menu.tbs.Filter = null;
            }
            else
            {
                side_menu.tbs.Filter = side_menu.filters[0];

                for (int index = 1; index < side_menu.filters.Count; index++)
                {
                    side_menu.tbs.Filter += "AND " + filters[index];
                }
            }

            side_menu.rdgv.DataSource = side_menu.tbs;
        }

        private void filterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String filterType = filterTypeComboBox.Text.Trim(',');
            if (filterType.Equals("Category") || filterType.Equals("Description") || filterType.Equals("Status") ||
                filterType.Equals("Control Measure") || filterType.Equals("Response") || filterType.Equals("Responsible Person") ||
                filterType.Equals("Status After"))
                filterComparisonComboBox.DataSource = textCompare;
            else
                filterComparisonComboBox.DataSource = dateNumbCompare;

            filterValueComboBox.DisplayMember = filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter);
            filterValueComboBox.ResetText();
        }

        private void side_menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == databaseTabPage)
                addFilterButton_Click(sender, e);
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == addRiskTabPage)
                addRiskButton_Click(sender, e);
        }

        private void columnsToolMenuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            if (risksDataGridView.Columns[tsmi.Text].Visible)
                risksDataGridView.Columns[tsmi.Text].Visible = false;
            else
                risksDataGridView.Columns[tsmi.Text].Visible = true;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            String fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            } 

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    exportMethods.exportExcel(fileName);
            }
        }

        private void risksDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    rdgv.ClearSelection();
                    rdgv.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void deleteRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = risksDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (!risksDataGridView.Rows[rowToDelete].IsNewRow)
            {
                string rowToDeleteId = risksDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Risk " + rowToDeleteId + " ?", "Deleting Entry", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.editDatabase(Program.risksConnectionString,
                                          "DELETE FROM [Table] WHERE ID = '" + rowToDeleteId + "'");

                    Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
                    risksDataGridView.ClearSelection();

                    return;
                }

                else
                {
                    return;
                }
            }

            MessageBox.Show("No entry selected.");
        }

        private void risksDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (risksDataGridView.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected risks?", "Deleting Entry", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow risk in risksDataGridView.SelectedRows)
                        {
                            if (!risk.IsNewRow)
                            {
                                string rowToDeleteId = risk.Cells[0].Value.ToString();

                                Program.editDatabase(Program.risksConnectionString,
                                                        "DELETE FROM [Table] WHERE ID = '" + rowToDeleteId + "'");
                            }
                        }

                        Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
                        risksDataGridView.ClearSelection();

                        return;
                    }

                    else
                    {
                        return;
                    }
                }

                MessageBox.Show("No entries selected.");
            }
        }
    }
}
