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

            // Sets the first selected user type for creating users to Reader.
            userTypeComboBox.SelectedIndex = 1;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.usersDataSet.Table);

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView, tableBindingSource);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox, "Username");
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            // Checks if all required fields are filled.
            if (usernameTextBox.Text.Trim().Equals("") || passwordTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username or Password not entered", "Could not create user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEdited = Program.editDatabase(Program.usersConnectionString, 
                                      "INSERT INTO [Table] ([Username], [Password], [User Type]) " + 
                                      "VALUES ('" + usernameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + userTypeComboBox.Text + "')");

            // Checks if an error occured when editing the database.
            if(!isEdited)
            {
                MessageBox.Show("Invalid Username/Password", "Could not create user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Successfully edited the database.
            MessageBox.Show("User created successfully", "User created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView, tableBindingSource);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox, "Username");
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
            String[] selectedUserInfo = Program.queryDatabase(Program.usersConnectionString, "SELECT * FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'")[0].Split(Program.fieldSeparationCharacter);

            // Update the fields with the selected user's data.
            editPasswordTextBox.Text = selectedUserInfo[1];
            editUserTypeComboBox.Text = selectedUserInfo[2];
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            // Checks if changing self's user type.
            if(editUsernameComboBox.Text.Equals(side_menu.username) && editUserTypeComboBox.Text.Equals("Reader"))
            {
                MessageBox.Show("Cannot change self to a Reader", "Could not edit user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Checks if all required fields are filled.
            else if (editPasswordTextBox.Text.Trim().Equals("") || editUserTypeComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Password or User Type not entered", "Could not edit user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEdited = Program.editDatabase(Program.usersConnectionString,
                                      "UPDATE [Table] SET Password = '" + editPasswordTextBox.Text + "', [User Type] = '" + editUserTypeComboBox.Text + "'" +
                                      "WHERE Username = '" + editUsernameComboBox.Text + "'");

            // Checks if an error occurred when editing the database.
            if (!isEdited)
            {
                MessageBox.Show("Invalid Username/Password", "Could not edit user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Successfully edited the database.
            MessageBox.Show("User edited successfully", "User edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editPasswordTextBox.Clear();
            editUserTypeComboBox.SelectedItem = null;

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView, tableBindingSource);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox, "Username");
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Checks if deleting self.
            if (editUsernameComboBox.Text.Equals(side_menu.username))
            {
                MessageBox.Show("Cannot delete self", "Could not delete user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.editDatabase(Program.usersConnectionString,
                                      "DELETE FROM [Table] WHERE Username = '" + editUsernameComboBox.Text + "'");

            // Successfully deleted from the database.
            MessageBox.Show("User deleted successfully", "User deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editUsernameComboBox.DataSource = null;
            editPasswordTextBox.Clear();
            editUserTypeComboBox.SelectedIndex = 1;

            Program.updateDataGridView(Program.usersConnectionString, usersDataGridView, tableBindingSource);
            Program.updateComboBox(Program.usersConnectionString, editUsernameComboBox, "Username");
        }
    }
}
