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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            userTypeComboBox.SelectedIndex = 1;
            editUserTypeComboBox.SelectedIndex = 1;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.usersDataSet.Table);

        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim().Equals("") || passwordTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username or Password not entered");
                return;
            }
            else if (login.queryUserDatabase("SELECT * FROM [Table] WHERE Username = '" + usernameTextBox.Text + "'").Count != 0)
            {
                MessageBox.Show("Username already in use");
                return;
            }

            editUsersDatabase("INSERT INTO [Table] ([Username], [Password], [User Type]) " + 
                              "VALUES ('" + usernameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + userTypeComboBox.Text + "')");

            MessageBox.Show("User created");
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            updateDataGridView(login.connectionString, usersDataGridView);
            updateComboBox(login.connectionString, editUsernameComboBox);
        }

        private void editUsersDatabase(String sqlComm)
        {
            using (SqlConnection connection = new SqlConnection(login.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlComm, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void updateDataGridView(String connectionString, DataGridView dataGridView)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == createNewUserTabPage)
                createUserButton_Click(sender, e);
        }

        //private void editUsernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    String[] userInfo = login.queryUserDatabase("SELECT * FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'")[0].Split(':');
        //
        //    editPasswordTextBox.Text = userInfo[1];
        //    editUserTypeComboBox.Text = userInfo[2];
        //}

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if(editUsernameComboBox.Text.Equals(side_menu.username) && editUserTypeComboBox.Text.Equals("Reader"))
            {
                MessageBox.Show("Cannot change self to a Reader");
                return;
            }
            else if (editPasswordTextBox.Text.Trim().Equals("") || editUserTypeComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Password or User Type not entered");
                return;
            }

            editUsersDatabase("UPDATE [Table] SET Password = '" + editPasswordTextBox.Text + "', [User Type] = '" + editUserTypeComboBox.Text + "'" +
                              "WHERE Username = '" + editUsernameComboBox.Text + "'");

            MessageBox.Show("User edited");
            editPasswordTextBox.Clear();
            editUserTypeComboBox.ResetText();

            updateDataGridView(login.connectionString, usersDataGridView);
            updateComboBox(login.connectionString, editUsernameComboBox);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (editUsernameComboBox.Text.Equals(side_menu.username))
            {
                MessageBox.Show("Cannot delete self");
                return;
            }

            editUsersDatabase("DELETE FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'");

            MessageBox.Show("User deleted");
            editUsernameComboBox.DataSource = null;
            editPasswordTextBox.Clear();
            editUserTypeComboBox.SelectedIndex = 1;

            updateDataGridView(login.connectionString, usersDataGridView);
            updateComboBox(login.connectionString, editUsernameComboBox);
        }

        public static void updateComboBox(String connectionString, ComboBox comboBox)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = "Username";
        }
    }
}
