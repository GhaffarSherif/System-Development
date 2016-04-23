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
        String connectionString;
        UsersDataSet usersDS;
        DataTable usersDT;

        public login()
        {
            connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Graal\\Desktop\\Team Project\\System-Development\\WindowsFormsApplication1\\WindowsFormsApplication1\\Users.mdf\";Integrated Security=True";
            usersDS = new UsersDataSet();
            usersDT = usersDS.Tables[0];
            
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!userAuthentication())
                return;
            

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

        private Boolean userAuthentication()
        {
            DataRow[] users = usersDT.Select("Username = '" + usernameTextBox.Text +"'");

            // Testing
            //MessageBox.Show("" + users.Count());

            if (users.Count() == 0)
                return false;
            else if (!users[1].Equals(passwordTextBox.Text))
                return false;

            return true;
        }
    }
}
