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
        // The forms that could pop-up from this form.
        settings s;
        filterList f;
        editRisks v;

        // The information of the current user.
        public static String username;
        public static String userType;

        // A list of filters that are applied to the risksDataGridView.
        public static List<String> filters = new List<String>();

        // THe set of Strings used to represent the comparison operators for certain data types.
        List<String> dateNumbCompare;
        List<String> textCompare;

        // Controls that are needed by other forms to either update or to get information.
        public static BindingSource tbs;
        public static DataGridView rdgv;
        public static ComboBox filterValue;
        public static ComboBox category;
        public static ComboBox status;
        public static ComboBox statusAfter;
        public static ComboBox responsiblePerson;

        public side_menu()
        {
            InitializeComponent();

            // Initialize the controls needed by other forms.
            tbs = tableBindingSource;
            rdgv = risksDataGridView;
            filterValue = filterValueComboBox;
            category = riskCategoryComboBox;
            status = statusComboBox;
            statusAfter = statusAfterComboBox;
            responsiblePerson = responsiblePersonComboBox;

            // Get the current user;s information.
            username = Program.userInfo.Split(Program.fieldSeparationCharacter)[0];
            userType = Program.userInfo.Split(Program.fieldSeparationCharacter)[2];

            // Disable some features if current user is not an Admin.
            userLabel.Text = username;
            if (!userType.Equals("Admin"))
            {
                tabControl1.TabPages.Remove(addRiskTabPage);
                filterMenuStrip.Items.Remove(editRiskToolStripMenuItem);
                filterMenuStrip.Items.Remove(deleteRiskToolStripMenuItem);
                settingsButton.Visible = false;
            }

            // The set of comparions operators for dates and numbers.
            dateNumbCompare = new List<String> {
                "=", ">", ">=", "<", "<="
            };

            // The set of comparions operators for Strings.
            textCompare = new List<String> {
                "=", "LIKE", "NOT LIKE"
            };

            filterTypeComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME  = 'Table'");
        }

        private void side_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

            splitContainer1.TabStop = false;
            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
            updateRiskID();
            updateAddComboBoxes();

            // Inform an Admin user that there are risks to revise.
            if (userType.Equals("Admin"))
            {
                String idsToRevise = Program.checkNextRevision();
                if (!idsToRevise.Equals(""))
                    MessageBox.Show("Risks with the following IDs need to be revised\n" + idsToRevise, "Risks to review", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set the next revision date to 3 years from the selected date field.
                nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
                filterValueComboBox.ResetText();
            }

            // Set the header color in the risksDataGridView.
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

        private void editRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["editRisks"] != null)
                v.Close();

            v = new editRisks();
            v.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["settings"] != null)
                s.Close();
            if (Application.OpenForms["filterList"] != null)
                f.Close();
            if (Application.OpenForms["editRisks"] != null)
                v.Close();

            Dispose(true);
            Close();

            new login().Show();
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

        private void filterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the appropriate set of comparions operators as DataSource for the filterComparisonComboBox.
            String filterType = filterTypeComboBox.Text;
            if (filterType.Equals("Category") || filterType.Equals("Description") || filterType.Equals("Status") ||
                filterType.Equals("Control Measure") || filterType.Equals("Response") || filterType.Equals("Responsible Person") ||
                filterType.Equals("Status After"))
                filterComparisonComboBox.DataSource = textCompare;
            else
                filterComparisonComboBox.DataSource = dateNumbCompare;

            // Fills the filterValueComboBox with distinct values of the selected filterType from the database.
            if (filterTypeComboBox.Text.Equals("Date") || filterTypeComboBox.Text.Equals("Next Revision")) // Formats the dates appropriately.
            {
                List<String> formattedDateList = new List<String>();
                List<String> dateList = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [" + filterTypeComboBox.Text + "] FROM [Table]");
                foreach (String date in dateList)
                    formattedDateList.Add(Convert.ToDateTime(date).ToString("dd/MM/yyyy"));
                filterValueComboBox.DataSource = formattedDateList;
            }
            else
                filterValueComboBox.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [" + filterTypeComboBox.Text + "] FROM [Table]");

            filterValueComboBox.ResetText();
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            // Checks of the required fields are filled.
            if (filterTypeComboBox.Text.Equals("") || filterValueComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Filter value not specified", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Adds the filter to the String List.
                if (filterTypeComboBox.Text.Equals("Date") || filterTypeComboBox.Text.Equals("Next Revision")) // Formats the dates appropriately. 
                    filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + " '" + Convert.ToDateTime(filterValueComboBox.Text).ToString("dd/MM/yyyy") + "'");
                else
                    filters.Add("[" + filterTypeComboBox.Text.Trim(Program.fieldSeparationCharacter) + "] " + filterComparisonComboBox.Text + " '" + filterValueComboBox.Text + "'");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid filter value: Dates must be in the following format DD/MM/YYYY", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Updates the filterList form if it open.
            if (Application.OpenForms["filterList"] != null)
            {
                f.filters.DataSource = null;
                f.filters.DataSource = filters;
            }

            try
            {
                filterDataGridView(); // Apply the filters to the risksDataGriView.
                Program.checkNextRevision();
                filterValueComboBox.ResetText();
            }
            catch (System.Data.EvaluateException) // If an error occurs while applying the filter.
            {
                filters.RemoveAt(filters.Count - 1); // Remove the added filter String from the list.
                MessageBox.Show("Invalid filter value", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SyntaxErrorException)
            {
                filters.RemoveAt(filters.Count - 1);
                MessageBox.Show("Invalid filter value", "Could not filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            filters = new List<String>();

            // Update the filterList form if it is open.
            if (Application.OpenForms["filterList"] != null)
            {
                f.filters.DataSource = null;
                f.filters.DataSource = filters;
            }

            // Clear the filters applied to the risksDataGridView.
            tableBindingSource.Filter = null;
            risksDataGridView.DataSource = tableBindingSource;

            Program.updateDataGridView(Program.risksConnectionString, rdgv, tbs);
            Program.checkNextRevision();
            filterValueComboBox.ResetText();
        }

        private void risksDataGridView_Sorted(object sender, EventArgs e)
        {
            Program.checkNextRevision();
        }

        private void columnsToolMenuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            // Hide or show to column that matches the text of the menu strip item.
            if (risksDataGridView.Columns[tsmi.Text].Visible)
                risksDataGridView.Columns[tsmi.Text].Visible = false;
            else
                risksDataGridView.Columns[tsmi.Text].Visible = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Set the next revision date to 3 years from the selected date field.
            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
        }

        private void addRiskButton_Click(object sender, EventArgs e)
        {
            // Check if the required fields are filled.
            if (riskCategoryComboBox.Text.Trim().Equals("") || descriptionTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Basic risk information not completed", "Risk could not be added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEdited = Program.editDatabase(Program.risksConnectionString, createAddCommand());

            // If an error occured whil editing the database.
            if (!isEdited)
            {
                MessageBox.Show("Invalid input format", "Risk could not be added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Successfully edited the database.
            MessageBox.Show("Risk added successfully", "Risk added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFieldsButton_Click(sender, e);

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView, tableBindingSource);
            updateRiskID();
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            // Reset all the fields in the add risk tab.
            dateTimePicker.ResetText();
            nextRevisionDateTimePicker.Value = dateTimePicker.Value.AddYears(3);
            descriptionTextBox.Clear();
            probabilityComboBox.SelectedItem = null;
            consequenceComboBox.SelectedItem = null;
            controlMeasureTextBox.Clear();
            riskResponseTextBox.Clear();
            probabilityAfterComboBox.SelectedItem = null;
            consequenceAfterComboBox.SelectedItem = null;
            updateAddComboBoxes();
        }

        private void side_menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == databaseTabPage)
                addFilterButton_Click(sender, e);
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == addRiskTabPage)
                addRiskButton_Click(sender, e);
        }

        // Updates the items in the comboBoxes of the add risk tab with distinct column values from the database.
        public static void updateAddComboBoxes()
        {
            side_menu.category.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Category] FROM [Table]");
            side_menu.status.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Status] FROM [Table]");
            side_menu.responsiblePerson.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Responsible Person] FROM [Table]");
            side_menu.statusAfter.DataSource = Program.queryDatabase(Program.risksConnectionString, "SELECT DISTINCT [Status After] FROM [Table]");
            
            side_menu.category.SelectedItem = null;
            side_menu.status.SelectedItem = null;
            side_menu.responsiblePerson.SelectedItem = null;
            side_menu.statusAfter.SelectedItem = null;
        }

        // Creates and returns the add SQL command depending on which fields are filled.
        private String createAddCommand()
        {
            // The default add SQL command for columns of required fields.
            String sqlComm = "INSERT INTO [Table] ([Date], [Next Revision], [Category], [Description]";

            // Add more columns if the designated fields are filled. 
            if (!probabilityComboBox.Text.Equals(""))
                sqlComm += ", [Probability]";
            if (!consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Consequence]";
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation]";
            if (!controlMeasureTextBox.Text.Trim().Equals(""))
                sqlComm += ", [Control Measure]";
            if (!riskResponseTextBox.Text.Trim().Equals(""))
                sqlComm += ", [Response]";
            if (!responsiblePersonComboBox.Text.Trim().Equals(""))
                sqlComm += ", [Responsible Person]";
            if (!probabilityAfterComboBox.Text.Equals(""))
                sqlComm += ", [Probability After]";
            if (!consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Consequence After]";
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                sqlComm += ", [Evaluation After]";
            if (!statusAfterComboBox.Text.Equals(""))
                sqlComm += ", [Status After]";

            // Add the last required fields. 
            sqlComm += ", [Last Modified By], [Last Modified Date]) ";

            // Add the values for the required fields.
            sqlComm += "VALUES ('" + dateTimePicker.Value.ToShortDateString() + "', '" 
            + nextRevisionDateTimePicker.Value.ToShortDateString() + "', '" 
            + riskCategoryComboBox.Text + "', '"
            + descriptionTextBox.Text;

            // Add more values if the designated fields are filled. 
            if (!probabilityComboBox.Text.Equals(""))
                sqlComm += "', '" + probabilityComboBox.Text;
            if (!consequenceComboBox.Text.Equals(""))
                sqlComm += "', '" + consequenceComboBox.Text;
            if (!probabilityComboBox.Text.Equals("") && !consequenceComboBox.Text.Equals(""))
                sqlComm += "', '" + (Convert.ToInt32(probabilityComboBox.Text) * Convert.ToInt32(consequenceComboBox.Text));
            if (!controlMeasureTextBox.Text.Trim().Equals(""))
                sqlComm += "', '" + controlMeasureTextBox.Text;
            if (!riskResponseTextBox.Text.Trim().Equals(""))
                sqlComm += "', '" + riskResponseTextBox.Text;
            if (!responsiblePersonComboBox.Text.Trim().Equals(""))
                sqlComm += "', '" + responsiblePersonComboBox.Text;
            if (!probabilityAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + probabilityAfterComboBox.Text;
            if (!consequenceAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + consequenceAfterComboBox.Text;
            if (!probabilityAfterComboBox.Text.Equals("") && !consequenceAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + (Convert.ToInt32(probabilityAfterComboBox.Text) * Convert.ToInt32(consequenceAfterComboBox.Text));
            if (!statusAfterComboBox.Text.Equals(""))
                sqlComm += "', '" + statusAfterComboBox.Text;

            // Add the values of the last required fields.
            sqlComm += "', '" + username + "', '" + DateTime.Now.ToShortDateString() + "')";

            return sqlComm;
        }

        // Update the risk id disabled TextBox to the next incrementation of the riskID field in the database.
        private void updateRiskID()
        {
            riskIDTextBox.Text = "" + (Convert.ToInt32(Program.queryDatabase(Program.risksConnectionString, "SELECT IDENT_CURRENT('Table')")[0].Split(Program.fieldSeparationCharacter)[0]) + 1);
        }

        // Applies the filters to the risksDataGriView.
        public static void filterDataGridView()
        {
            // If filters List is empty then just assign it to null.
            if (side_menu.filters.Count == 0)
            {
                side_menu.tbs.Filter = null;
            }
            else
            {
                // Add the first filter.
                side_menu.tbs.Filter = side_menu.filters[0];

                // Append any other filters using a default AND corelation.
                for (int index = 1; index < side_menu.filters.Count; index++)
                {
                    side_menu.tbs.Filter += "AND " + filters[index];
                }
            }

            // Apply the changes.
            Program.updateDataGridView(Program.risksConnectionString, rdgv, tbs);
            side_menu.rdgv.DataSource = side_menu.tbs;
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
                    updateAddComboBoxes();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            

            int rowCounter = 0;
            int z = 0;
            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;

            int width = 1150 / (risksDataGridView.Columns.Count - 2);
            int realwidth = 5;
            int height = 15;

            int realheight = 60;

            Font newFont = risksDataGridView.Font;

            // Summarry report
            String message = "Summary Report";
            Font drawFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(0F, 10.0F);
            e.Graphics.DrawString(message, drawFont, drawBrush, drawPoint);

            // Date
            Font dateFont = new Font("Arial", 10, FontStyle.Bold);
            e.Graphics.DrawString(DateTime.Today.ToString("D"), dateFont, new SolidBrush(Color.Black), new PointF(5f, 30f));


           



            // Headers
            for (z = 0; z < risksDataGridView.Columns.Count ; z++)
            {
                if (z != 9 && z != 10 && z!= 4)
                {
                    e.Graphics.FillRectangle(Brushes.AliceBlue, realwidth, realheight, width, height);
                    e.Graphics.DrawRectangle(Pens.Black, realwidth, realheight, width, height);

                    if (z == 11)
                    {
                        e.Graphics.DrawString("Responsible P.", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, realwidth, realheight + 4);

                    }
                    else if (z == 12)
                    {
                        e.Graphics.DrawString("Prob. After", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, realwidth, realheight + 4);

                    }
                    else if (z == 13)
                    {
                        e.Graphics.DrawString("Concq. After", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, realwidth, realheight + 4);

                    }
                    else if(z==15){
                        e.Graphics.DrawString("Eval. After", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, realwidth, realheight + 4);

                    }
                    else
                        e.Graphics.DrawString(risksDataGridView.Columns[z].HeaderText, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, realwidth, realheight+4);

                    realwidth = realwidth + width;
                }
            }

            z = 0;
            realheight = realheight + height;
            while (rowCounter < risksDataGridView.Rows.Count)
            {
                realwidth = 5;
                //Rows

                for (int i = 0; i < 16; i++)
                {
                    if (risksDataGridView.Rows[rowCounter].Cells[i].Value == null && i != 9 && i != 10 && i!= 4)
                    {
                        risksDataGridView.Rows[rowCounter].Cells[i].Value = "";
                    }
                    if (i != 9 && i != 10 && i != 4)
                    {
                        e.Graphics.FillRectangle(Brushes.AliceBlue, realwidth, realheight, width, height);
                        e.Graphics.DrawRectangle(Pens.Black, realwidth, realheight, width, height);

                        e.Graphics.DrawString(risksDataGridView.Rows[rowCounter].Cells[i].Value.ToString(), new Font("Arial", 7), Brushes.Black, realwidth, realheight+5);
                        realwidth = realwidth + width;
                    }
                    

                }

                ++rowCounter;
                realheight = realheight + height;

            }
            
            
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }
    }
}
