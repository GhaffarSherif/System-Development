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
        public static String connectionString;

        public static String user;

        public login()
        {
            connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Graal\\Desktop\\Team Project\\System-Development\\WindowsFormsApplication1\\WindowsFormsApplication1\\Users.mdf\";Integrated Security=True";
            
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            String sqlComm = ("SELECT * FROM [Table] " + 
                              "WHERE Username = '" + usernameTextBox.Text + "'" +
                              "AND Password = '" + passwordTextBox.Text + "'");

            List<String> users = queryUserDatabase(sqlComm);
            if (users.Count == 0)
            {
                invalidLoginCredentials();
                return;
            }

            user = users[0];
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

        private List<String> queryUserDatabase(String sqlComm)
        {
            List<String> queryResults = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlComm, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                         queryResults.Add(reader.GetString(0) + ":" + reader.GetString(1) + ":" + reader.GetString(2));
                    }
                }
            }

            return queryResults;
        }

        private void invalidLoginCredentials()
        {
            // To decide
        }
    }
}
