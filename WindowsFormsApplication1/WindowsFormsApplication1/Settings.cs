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
            else if (Program.queryDatabase(Program.usersConnectionString, "SELECT * FROM [Table] WHERE Username = '" + usernameTextBox.Text + "'").Count != 0)
            {
                MessageBox.Show("Username already in use");
                return;
            }

            Program.editUsersDatabase(Program.usersConnectionString, 
                                      "INSERT INTO [Table] ([Username], [Password], [User Type]) " + 
                                      "VALUES ('" + usernameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + userTypeComboBox.Text + "')");

            MessageBox.Show("User created");
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox);
        }

        private void settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == createNewUserTabPage)
                createUserButton_Click(sender, e);
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == editUserTabPage)
                editUserButton_Click(sender, e);
        }

        private void editUsernameComboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            String[] selectedUserInfo = Program.queryDatabase(Program.usersConnectionString, "SELECT * FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'")[0].Split(':');

            editPasswordTextBox.Text = selectedUserInfo[1];
            editUserTypeComboBox.Text = selectedUserInfo[2];
        }

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

            Program.editUsersDatabase(Program.usersConnectionString,
                                      "UPDATE [Table] SET Password = '" + editPasswordTextBox.Text + "', [User Type] = '" + editUserTypeComboBox.Text + "'" +
                                      "WHERE Username = '" + editUsernameComboBox.Text + "'");

            MessageBox.Show("User edited");
            editPasswordTextBox.Clear();
            editUserTypeComboBox.ResetText();

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (editUsernameComboBox.Text.Equals(side_menu.username))
            {
                MessageBox.Show("Cannot delete self");
                return;
            }

            Program.editUsersDatabase(Program.usersConnectionString,
                                      "DELETE FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'");

            MessageBox.Show("User deleted");
            editUsernameComboBox.DataSource = null;
            editPasswordTextBox.Clear();
            editUserTypeComboBox.SelectedIndex = 1;

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox);
        }
    }
}
