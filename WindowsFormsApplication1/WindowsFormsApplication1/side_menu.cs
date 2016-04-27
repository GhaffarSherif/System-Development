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
    public partial class side_menu : Form
    {
        settings s;
        filterList f;
        editRisks v;

        public static String username;
        public static String userType;

        public side_menu()
        {
            InitializeComponent();

            username = Program.userInfo.Split(Program.fieldSeparationCharacter)[0];
            userType = Program.userInfo.Split(Program.fieldSeparationCharacter)[2];

            userLabel.Text = username;
            if (!userType.Equals("Admin"))
                settingsButton.Visible = false;
        }

        private void side_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView);
            updateRiskID();

            //nextRevisionDateTimePicker.Value
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
                MessageBox.Show("Not all fields are filled");
                return;
            }

            Program.editDatabase(Program.risksConnectionString, 
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

            MessageBox.Show("Risk added");
            descriptionTextBox.Clear();
            probabilityComboBox.ResetText();
            consequenceComboBox.ResetText();
            statusComboBox.ResetText();
            probabilityComboBox.ResetText();
            consequenceComboBox.ResetText();
            controlMeasuresTextBox.Clear();
            riskResponseTextBox.Clear();
            responsiblePersonTextBox.Clear();
            probabilityAfterComboBox.ResetText();
            consequenceAfterComboBox.ResetText();
            statusAfterComboBox.ResetText();
            probabilityAfterComboBox.ResetText();
            consequenceAfterComboBox.ResetText();

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView);
            updateRiskID();

        }

        private bool validateFields()
        {
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

            //v
        }
    }
}
