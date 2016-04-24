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

        public static String username;
        public static String userType;

        public side_menu()
        {
            InitializeComponent();

            username = Program.userInfo.Split(',')[0];
            userType = Program.userInfo.Split(',')[2];

            userLabel.Text = username;
            if (!userType.Equals("Admin"))
                settingsButton.Visible = false;
        }

        private void side_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

            Program.updateDataGridView(Program.risksConnectionString, risksDataGridView);
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
            List<String> temp = Program.queryDatabase(Program.usersConnectionString, "select * from INFORMATION_SCHEMA.COLUMNS where TABLE_Name='Table' order by ORDINAL_POSITION");

            String sTemp = "";
            foreach (String str in temp)
                sTemp += str + ",";

            MessageBox.Show(sTemp);

            

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
    }
}
