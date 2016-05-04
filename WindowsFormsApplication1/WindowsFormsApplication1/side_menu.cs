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

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView);
            updateRiskID();

            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
            filterValueComboBox.ResetText();
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
                MessageBox.Show("Not all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEdited = Program.editDatabase(Program.risksConnectionString, 
            "INSERT INTO [Table] ([Date], [Next Revision], [Category], [Description], [Probability], [Consequence], [Status], [Evaluation], [Control Measure], [Response], [Responsible Person], [Probability After], [Consequence After], [Status After], [Evaluation After]) " +
            "VALUES ('" + dateTimePicker.Value.ToShortDateString() + "', '" 
            + nextRevisionDateTimePicker.Value.ToShortDateString() + "', '" 
            + riskCategoryComboBox.Text + "', '"
            + descriptionTextBox.Text + "', '"
            + probabilityComboBox.Text + "', '"
            + consequenceComboBox.Text + "', '"
            + statusComboBox.Text + "', '"
            + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text)) + "', '"
            + controlMeasuresTextBox.Text + "', '"
            + riskResponseTextBox.Text + "', '"
            + responsiblePersonTextBox.Text + "', '"
            + probabilityAfterComboBox.Text + "', '"
            + consequenceAfterComboBox.Text + "', '" 
            + statusAfterComboBox.Text + "', '"
            + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text)) 
            +"')");

            if(!isEdited)
            {
                MessageBox.Show("Incorrect field format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Risk added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            descriptionTextBox.Clear();
            probabilityComboBox.ResetText();
            consequenceComboBox.ResetText();
            statusComboBox.ResetText();
            controlMeasuresTextBox.Clear();
            riskResponseTextBox.Clear();
            responsiblePersonTextBox.Clear();
            probabilityAfterComboBox.ResetText();
            consequenceAfterComboBox.ResetText();
            statusAfterComboBox.ResetText();

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView);
            updateRiskID();
        }

        private bool validateFields()
        {
            if (riskCategoryComboBox.Text.Equals(""))
                return false;
            else if (descriptionTextBox.Text.Equals(""))
                return false;
            else if(probabilityAfterComboBox.Text.Equals(""))
                return false;
            else if(consequenceComboBox.Text.Equals(""))
                return false;
            else if (statusComboBox.Text.Equals(""))
                return false;
            else if(controlMeasuresTextBox.Text.Equals(""))
                return false;
            else if(riskResponseTextBox.Text.Equals(""))
                return false;
            else if(responsiblePersonTextBox.Text.Equals(""))
                return false;
            else if(probabilityAfterComboBox.Text.Equals(""))
                return false;
            else if(consequenceAfterComboBox.Text.Equals(""))
                return false;
            else if(statusAfterComboBox.Text.Equals(""))
                return false;

            return true;
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
                MessageBox.Show("Not all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filterTypeComboBox.Text.Equals("Date") || filterTypeComboBox.Text.Equals("Next Revision"))
            {
                MessageBox.Show("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + Convert.ToDateTime(filterValueComboBox.Text));
                filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + Convert.ToDateTime(filterValueComboBox.Text));
            }
            else
            {
                MessageBox.Show("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + "'" + filterValueComboBox.Text + "'");
                filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + "'" + filterValueComboBox.Text + "'");
            }
            
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
                MessageBox.Show("Inappropriate filter value formatting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
