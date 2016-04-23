namespace WindowsFormsApplication1
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersListTabPage = new System.Windows.Forms.TabPage();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new WindowsFormsApplication1.UsersDataSet();
            this.createNewUserTabPage = new System.Windows.Forms.TabPage();
            this.createUserButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.editUserTabPage = new System.Windows.Forms.TabPage();
            this.editUserButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editUserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.editPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableTableAdapter = new WindowsFormsApplication1.UsersDataSetTableAdapters.TableTableAdapter();
            this.editUsernameComboBox = new System.Windows.Forms.ComboBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.usersListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.createNewUserTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editUserTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersListTabPage);
            this.tabControl1.Controls.Add(this.createNewUserTabPage);
            this.tabControl1.Controls.Add(this.editUserTabPage);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 237);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // usersListTabPage
            // 
            this.usersListTabPage.Controls.Add(this.usersDataGridView);
            this.usersListTabPage.Location = new System.Drawing.Point(4, 22);
            this.usersListTabPage.Name = "usersListTabPage";
            this.usersListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersListTabPage.Size = new System.Drawing.Size(251, 211);
            this.usersListTabPage.TabIndex = 0;
            this.usersListTabPage.Text = "Users List";
            this.usersListTabPage.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn});
            this.usersDataGridView.DataSource = this.tableBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(245, 205);
            this.usersDataGridView.TabIndex = 0;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User Type";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createNewUserTabPage
            // 
            this.createNewUserTabPage.Controls.Add(this.createUserButton);
            this.createNewUserTabPage.Controls.Add(this.panel3);
            this.createNewUserTabPage.Controls.Add(this.panel2);
            this.createNewUserTabPage.Controls.Add(this.panel1);
            this.createNewUserTabPage.Location = new System.Drawing.Point(4, 22);
            this.createNewUserTabPage.Name = "createNewUserTabPage";
            this.createNewUserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createNewUserTabPage.Size = new System.Drawing.Size(251, 211);
            this.createNewUserTabPage.TabIndex = 1;
            this.createNewUserTabPage.Text = "Create New Users";
            this.createNewUserTabPage.UseVisualStyleBackColor = true;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(91, 175);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(75, 23);
            this.createUserButton.TabIndex = 4;
            this.createUserButton.TabStop = false;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userTypeComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 48);
            this.panel3.TabIndex = 3;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Reader"});
            this.userTypeComboBox.Location = new System.Drawing.Point(7, 21);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.userTypeComboBox.Sorted = true;
            this.userTypeComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Location = new System.Drawing.Point(6, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 48);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(7, 20);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(226, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(7, 20);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(226, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // editUserTabPage
            // 
            this.editUserTabPage.Controls.Add(this.deleteUserButton);
            this.editUserTabPage.Controls.Add(this.editUserButton);
            this.editUserTabPage.Controls.Add(this.panel4);
            this.editUserTabPage.Controls.Add(this.panel5);
            this.editUserTabPage.Controls.Add(this.panel6);
            this.editUserTabPage.Location = new System.Drawing.Point(4, 22);
            this.editUserTabPage.Name = "editUserTabPage";
            this.editUserTabPage.Size = new System.Drawing.Size(251, 211);
            this.editUserTabPage.TabIndex = 2;
            this.editUserTabPage.Text = "Edit Users";
            this.editUserTabPage.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(94, 175);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(75, 23);
            this.editUserButton.TabIndex = 8;
            this.editUserButton.TabStop = false;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.editUserTypeComboBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 48);
            this.panel4.TabIndex = 7;
            // 
            // editUserTypeComboBox
            // 
            this.editUserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUserTypeComboBox.FormattingEnabled = true;
            this.editUserTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Reader"});
            this.editUserTypeComboBox.Location = new System.Drawing.Point(7, 21);
            this.editUserTypeComboBox.Name = "editUserTypeComboBox";
            this.editUserTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.editUserTypeComboBox.Sorted = true;
            this.editUserTypeComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Type";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.editPasswordTextBox);
            this.panel5.Location = new System.Drawing.Point(6, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 48);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // editPasswordTextBox
            // 
            this.editPasswordTextBox.Location = new System.Drawing.Point(7, 20);
            this.editPasswordTextBox.Name = "editPasswordTextBox";
            this.editPasswordTextBox.Size = new System.Drawing.Size(226, 20);
            this.editPasswordTextBox.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.editUsernameComboBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 48);
            this.panel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // editUsernameComboBox
            // 
            this.editUsernameComboBox.DataSource = this.tableBindingSource;
            this.editUsernameComboBox.DisplayMember = "Username";
            this.editUsernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUsernameComboBox.FormattingEnabled = true;
            this.editUsernameComboBox.Location = new System.Drawing.Point(7, 21);
            this.editUsernameComboBox.Name = "editUsernameComboBox";
            this.editUsernameComboBox.Size = new System.Drawing.Size(226, 21);
            this.editUsernameComboBox.TabIndex = 2;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(13, 175);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 9;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settings_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.usersListTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.createNewUserTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editUserTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usersListTabPage;
        private System.Windows.Forms.TabPage createNewUserTabPage;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private UsersDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage editUserTabPage;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox editUserTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editPasswordTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox editUsernameComboBox;
        private System.Windows.Forms.Button deleteUserButton;
    }
}