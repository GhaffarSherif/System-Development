using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            String sqlComm = ("SELECT * FROM [Table] " + 
                              "WHERE Username = '" + usernameTextBox.Text + "'" +
                              "AND Password = '" + passwordTextBox.Text + "'");

            List<String> users = Program.queryDatabase(Program.usersConnectionString, sqlComm);
            if (users.Count == 0)
            {
                invalidLoginCredentials();
                return;
            }

            Program.userInfo = users[0];
            Dispose(true);
            Close();

            new side_menu().Show();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton_Click(sender, e);
        }

        private void invalidLoginCredentials()
        {
            MessageBox.Show("Invalid Username or Password");
        }
    }
}
