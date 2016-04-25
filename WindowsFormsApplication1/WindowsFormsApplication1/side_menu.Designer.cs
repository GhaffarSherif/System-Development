namespace WindowsFormsApplication1
{
    partial class side_menu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.settingsButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.databaseTabPage = new System.Windows.Forms.TabPage();
            this.risksDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlMeasureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsiblePersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consequenceAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFIlterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.risksDataSet = new WindowsFormsApplication1.RisksDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewFiltersButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addRiskTabPage = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextRevisionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.riskIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addRiskButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.controlMeasuresTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.statusAfterComboBox = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.consequenceAfterComboBox = new System.Windows.Forms.ComboBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.probabilityAfterComboBox = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.responsiblePersonTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.riskResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.consequenceComboBox = new System.Windows.Forms.ComboBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.probabilityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.riskCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.tableTableAdapter = new WindowsFormsApplication1.RisksDataSetTableAdapters.TableTableAdapter();
            this.editRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.databaseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.risksDataGridView)).BeginInit();
            this.filterMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.risksDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.addRiskTabPage.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel16.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.settingsButton);
            this.splitContainer1.Panel1.Controls.Add(this.userLabel);
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(780, 671);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(14, 86);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(129, 37);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(53, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(47, 20);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "User";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(13, 622);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(129, 37);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Export to Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.databaseTabPage);
            this.tabControl1.Controls.Add(this.addRiskTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // databaseTabPage
            // 
            this.databaseTabPage.Controls.Add(this.risksDataGridView);
            this.databaseTabPage.Controls.Add(this.groupBox1);
            this.databaseTabPage.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.databaseTabPage.Location = new System.Drawing.Point(4, 22);
            this.databaseTabPage.Name = "databaseTabPage";
            this.databaseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.databaseTabPage.Size = new System.Drawing.Size(592, 639);
            this.databaseTabPage.TabIndex = 0;
            this.databaseTabPage.Text = "Database";
            this.databaseTabPage.UseVisualStyleBackColor = true;
            // 
            // risksDataGridView
            // 
            this.risksDataGridView.AllowDrop = true;
            this.risksDataGridView.AllowUserToOrderColumns = true;
            this.risksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.risksDataGridView.AutoGenerateColumns = false;
            this.risksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.risksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nextRevisionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.probabilityDataGridViewTextBoxColumn,
            this.consequenceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.evaluationDataGridViewTextBoxColumn,
            this.controlMeasureDataGridViewTextBoxColumn,
            this.responseDataGridViewTextBoxColumn,
            this.responsiblePersonDataGridViewTextBoxColumn,
            this.probabilityAfterDataGridViewTextBoxColumn,
            this.consequenceAfterDataGridViewTextBoxColumn,
            this.statusAfterDataGridViewTextBoxColumn,
            this.evaluationAfterDataGridViewTextBoxColumn});
            this.risksDataGridView.ContextMenuStrip = this.filterMenuStrip;
            this.risksDataGridView.DataSource = this.tableBindingSource;
            this.risksDataGridView.Location = new System.Drawing.Point(29, 154);
            this.risksDataGridView.Name = "risksDataGridView";
            this.risksDataGridView.ReadOnly = true;
            this.risksDataGridView.Size = new System.Drawing.Size(557, 468);
            this.risksDataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRevisionDataGridViewTextBoxColumn
            // 
            this.nextRevisionDataGridViewTextBoxColumn.DataPropertyName = "Next Revision";
            this.nextRevisionDataGridViewTextBoxColumn.HeaderText = "Next Revision";
            this.nextRevisionDataGridViewTextBoxColumn.Name = "nextRevisionDataGridViewTextBoxColumn";
            this.nextRevisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // probabilityDataGridViewTextBoxColumn
            // 
            this.probabilityDataGridViewTextBoxColumn.DataPropertyName = "Probability";
            this.probabilityDataGridViewTextBoxColumn.HeaderText = "Probability";
            this.probabilityDataGridViewTextBoxColumn.Name = "probabilityDataGridViewTextBoxColumn";
            this.probabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consequenceDataGridViewTextBoxColumn
            // 
            this.consequenceDataGridViewTextBoxColumn.DataPropertyName = "Consequence";
            this.consequenceDataGridViewTextBoxColumn.HeaderText = "Consequence";
            this.consequenceDataGridViewTextBoxColumn.Name = "consequenceDataGridViewTextBoxColumn";
            this.consequenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluationDataGridViewTextBoxColumn
            // 
            this.evaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.Name = "evaluationDataGridViewTextBoxColumn";
            this.evaluationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controlMeasureDataGridViewTextBoxColumn
            // 
            this.controlMeasureDataGridViewTextBoxColumn.DataPropertyName = "Control Measure";
            this.controlMeasureDataGridViewTextBoxColumn.HeaderText = "Control Measure";
            this.controlMeasureDataGridViewTextBoxColumn.Name = "controlMeasureDataGridViewTextBoxColumn";
            this.controlMeasureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responseDataGridViewTextBoxColumn
            // 
            this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
            this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            this.responseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsiblePersonDataGridViewTextBoxColumn
            // 
            this.responsiblePersonDataGridViewTextBoxColumn.DataPropertyName = "Responsible Person";
            this.responsiblePersonDataGridViewTextBoxColumn.HeaderText = "Responsible Person";
            this.responsiblePersonDataGridViewTextBoxColumn.Name = "responsiblePersonDataGridViewTextBoxColumn";
            this.responsiblePersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // probabilityAfterDataGridViewTextBoxColumn
            // 
            this.probabilityAfterDataGridViewTextBoxColumn.DataPropertyName = "Probability After";
            this.probabilityAfterDataGridViewTextBoxColumn.HeaderText = "Probability After";
            this.probabilityAfterDataGridViewTextBoxColumn.Name = "probabilityAfterDataGridViewTextBoxColumn";
            this.probabilityAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consequenceAfterDataGridViewTextBoxColumn
            // 
            this.consequenceAfterDataGridViewTextBoxColumn.DataPropertyName = "Consequence After";
            this.consequenceAfterDataGridViewTextBoxColumn.HeaderText = "Consequence After";
            this.consequenceAfterDataGridViewTextBoxColumn.Name = "consequenceAfterDataGridViewTextBoxColumn";
            this.consequenceAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusAfterDataGridViewTextBoxColumn
            // 
            this.statusAfterDataGridViewTextBoxColumn.DataPropertyName = "Status After";
            this.statusAfterDataGridViewTextBoxColumn.HeaderText = "Status After";
            this.statusAfterDataGridViewTextBoxColumn.Name = "statusAfterDataGridViewTextBoxColumn";
            this.statusAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluationAfterDataGridViewTextBoxColumn
            // 
            this.evaluationAfterDataGridViewTextBoxColumn.DataPropertyName = "Evaluation After";
            this.evaluationAfterDataGridViewTextBoxColumn.HeaderText = "Evaluation After";
            this.evaluationAfterDataGridViewTextBoxColumn.Name = "evaluationAfterDataGridViewTextBoxColumn";
            this.evaluationAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filterMenuStrip
            // 
            this.filterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem,
            this.editRiskToolStripMenuItem});
            this.filterMenuStrip.Name = "filterMenuStrip";
            this.filterMenuStrip.Size = new System.Drawing.Size(119, 48);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFIlterToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // addFIlterToolStripMenuItem
            // 
            this.addFIlterToolStripMenuItem.Name = "addFIlterToolStripMenuItem";
            this.addFIlterToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.addFIlterToolStripMenuItem.Text = "Add";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.risksDataSet;
            // 
            // risksDataSet
            // 
            this.risksDataSet.DataSetName = "RisksDataSet";
            this.risksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewFiltersButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // viewFiltersButton
            // 
            this.viewFiltersButton.Location = new System.Drawing.Point(23, 87);
            this.viewFiltersButton.Name = "viewFiltersButton";
            this.viewFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.viewFiltersButton.TabIndex = 6;
            this.viewFiltersButton.Text = "View Filters";
            this.viewFiltersButton.UseVisualStyleBackColor = true;
            this.viewFiltersButton.Click += new System.EventHandler(this.viewFiltersButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Filter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Filters";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Location = new System.Drawing.Point(153, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 58);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filter value";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(383, 20);
            this.textBox3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(17, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 58);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filter type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // addRiskTabPage
            // 
            this.addRiskTabPage.Controls.Add(this.panel15);
            this.addRiskTabPage.Location = new System.Drawing.Point(4, 22);
            this.addRiskTabPage.Name = "addRiskTabPage";
            this.addRiskTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addRiskTabPage.Size = new System.Drawing.Size(592, 639);
            this.addRiskTabPage.TabIndex = 1;
            this.addRiskTabPage.Text = "Add Risk";
            this.addRiskTabPage.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel2);
            this.panel15.Controls.Add(this.panel3);
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.addRiskButton);
            this.panel15.Controls.Add(this.groupBox5);
            this.panel15.Controls.Add(this.groupBox7);
            this.panel15.Controls.Add(this.groupBox8);
            this.panel15.Location = new System.Drawing.Point(6, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(580, 628);
            this.panel15.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nextRevisionDateTimePicker);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(225, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 41);
            this.panel2.TabIndex = 11;
            // 
            // nextRevisionDateTimePicker
            // 
            this.nextRevisionDateTimePicker.Location = new System.Drawing.Point(15, 15);
            this.nextRevisionDateTimePicker.Name = "nextRevisionDateTimePicker";
            this.nextRevisionDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.nextRevisionDateTimePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Next Revision";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 41);
            this.panel3.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 15);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.riskIDTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(440, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 41);
            this.panel1.TabIndex = 8;
            // 
            // riskIDTextBox
            // 
            this.riskIDTextBox.Enabled = false;
            this.riskIDTextBox.Location = new System.Drawing.Point(17, 15);
            this.riskIDTextBox.Name = "riskIDTextBox";
            this.riskIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.riskIDTextBox.TabIndex = 6;
            this.riskIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Risk ID";
            // 
            // addRiskButton
            // 
            this.addRiskButton.Location = new System.Drawing.Point(239, 603);
            this.addRiskButton.Name = "addRiskButton";
            this.addRiskButton.Size = new System.Drawing.Size(75, 23);
            this.addRiskButton.TabIndex = 4;
            this.addRiskButton.Text = "Add Risk";
            this.addRiskButton.UseVisualStyleBackColor = true;
            this.addRiskButton.Click += new System.EventHandler(this.addRiskButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel16);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.panel21);
            this.groupBox5.Controls.Add(this.panel22);
            this.groupBox5.Location = new System.Drawing.Point(4, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 297);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label14);
            this.panel16.Controls.Add(this.controlMeasuresTextBox);
            this.panel16.Location = new System.Drawing.Point(6, 19);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(550, 49);
            this.panel16.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Control Measures";
            // 
            // controlMeasuresTextBox
            // 
            this.controlMeasuresTextBox.Location = new System.Drawing.Point(105, 3);
            this.controlMeasuresTextBox.Name = "controlMeasuresTextBox";
            this.controlMeasuresTextBox.Size = new System.Drawing.Size(441, 42);
            this.controlMeasuresTextBox.TabIndex = 0;
            this.controlMeasuresTextBox.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel18);
            this.groupBox6.Controls.Add(this.panel19);
            this.groupBox6.Controls.Add(this.panel20);
            this.groupBox6.Location = new System.Drawing.Point(19, 171);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(526, 105);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "After Control";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label16);
            this.panel18.Controls.Add(this.statusAfterComboBox);
            this.panel18.Location = new System.Drawing.Point(286, 19);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 31);
            this.panel18.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Status";
            // 
            // statusAfterComboBox
            // 
            this.statusAfterComboBox.FormattingEnabled = true;
            this.statusAfterComboBox.Location = new System.Drawing.Point(76, 3);
            this.statusAfterComboBox.Name = "statusAfterComboBox";
            this.statusAfterComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusAfterComboBox.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label17);
            this.panel19.Controls.Add(this.consequenceAfterComboBox);
            this.panel19.Location = new System.Drawing.Point(23, 63);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(200, 31);
            this.panel19.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Consequence";
            // 
            // consequenceAfterComboBox
            // 
            this.consequenceAfterComboBox.FormattingEnabled = true;
            this.consequenceAfterComboBox.Location = new System.Drawing.Point(76, 3);
            this.consequenceAfterComboBox.Name = "consequenceAfterComboBox";
            this.consequenceAfterComboBox.Size = new System.Drawing.Size(121, 21);
            this.consequenceAfterComboBox.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label18);
            this.panel20.Controls.Add(this.probabilityAfterComboBox);
            this.panel20.Location = new System.Drawing.Point(23, 19);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 31);
            this.panel20.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Probability";
            // 
            // probabilityAfterComboBox
            // 
            this.probabilityAfterComboBox.FormattingEnabled = true;
            this.probabilityAfterComboBox.Location = new System.Drawing.Point(76, 3);
            this.probabilityAfterComboBox.Name = "probabilityAfterComboBox";
            this.probabilityAfterComboBox.Size = new System.Drawing.Size(121, 21);
            this.probabilityAfterComboBox.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.responsiblePersonTextBox);
            this.panel21.Controls.Add(this.label19);
            this.panel21.Location = new System.Drawing.Point(111, 129);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(278, 36);
            this.panel21.TabIndex = 3;
            // 
            // responsiblePersonTextBox
            // 
            this.responsiblePersonTextBox.Location = new System.Drawing.Point(111, 9);
            this.responsiblePersonTextBox.Name = "responsiblePersonTextBox";
            this.responsiblePersonTextBox.Size = new System.Drawing.Size(163, 20);
            this.responsiblePersonTextBox.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Responsible Person";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label20);
            this.panel22.Controls.Add(this.riskResponseTextBox);
            this.panel22.Location = new System.Drawing.Point(6, 74);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(550, 49);
            this.panel22.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Risk Response";
            // 
            // riskResponseTextBox
            // 
            this.riskResponseTextBox.Location = new System.Drawing.Point(105, 3);
            this.riskResponseTextBox.Name = "riskResponseTextBox";
            this.riskResponseTextBox.Size = new System.Drawing.Size(441, 42);
            this.riskResponseTextBox.TabIndex = 0;
            this.riskResponseTextBox.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel24);
            this.groupBox7.Controls.Add(this.panel25);
            this.groupBox7.Controls.Add(this.panel26);
            this.groupBox7.Location = new System.Drawing.Point(4, 189);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(562, 101);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Priority";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label22);
            this.panel24.Controls.Add(this.statusComboBox);
            this.panel24.Location = new System.Drawing.Point(305, 19);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(200, 31);
            this.panel24.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(76, 3);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 0;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label23);
            this.panel25.Controls.Add(this.consequenceComboBox);
            this.panel25.Location = new System.Drawing.Point(45, 61);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(200, 31);
            this.panel25.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Consequence";
            // 
            // consequenceComboBox
            // 
            this.consequenceComboBox.FormattingEnabled = true;
            this.consequenceComboBox.Location = new System.Drawing.Point(76, 3);
            this.consequenceComboBox.Name = "consequenceComboBox";
            this.consequenceComboBox.Size = new System.Drawing.Size(121, 21);
            this.consequenceComboBox.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label24);
            this.panel26.Controls.Add(this.probabilityComboBox);
            this.panel26.Location = new System.Drawing.Point(45, 20);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(200, 31);
            this.panel26.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Probability";
            // 
            // probabilityComboBox
            // 
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.Location = new System.Drawing.Point(76, 3);
            this.probabilityComboBox.Name = "probabilityComboBox";
            this.probabilityComboBox.Size = new System.Drawing.Size(121, 21);
            this.probabilityComboBox.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel27);
            this.groupBox8.Controls.Add(this.panel28);
            this.groupBox8.Location = new System.Drawing.Point(4, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(562, 133);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Basic Info";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.label25);
            this.panel27.Controls.Add(this.descriptionTextBox);
            this.panel27.Location = new System.Drawing.Point(6, 54);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(550, 71);
            this.panel27.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(4, 23);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(542, 45);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.label26);
            this.panel28.Controls.Add(this.riskCategoryComboBox);
            this.panel28.Location = new System.Drawing.Point(159, 21);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(200, 31);
            this.panel28.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Risk Category";
            // 
            // riskCategoryComboBox
            // 
            this.riskCategoryComboBox.DataSource = this.tableBindingSource;
            this.riskCategoryComboBox.DisplayMember = "Category";
            this.riskCategoryComboBox.FormattingEnabled = true;
            this.riskCategoryComboBox.Location = new System.Drawing.Point(76, 3);
            this.riskCategoryComboBox.Name = "riskCategoryComboBox";
            this.riskCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.riskCategoryComboBox.TabIndex = 0;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // editRiskToolStripMenuItem
            // 
            this.editRiskToolStripMenuItem.Name = "editRiskToolStripMenuItem";
            this.editRiskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editRiskToolStripMenuItem.Text = "Edit Risk";
            this.editRiskToolStripMenuItem.Click += new System.EventHandler(this.editRiskToolStripMenuItem_Click);
            // 
            // side_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 671);
            this.Controls.Add(this.splitContainer1);
            this.Name = "side_menu";
            this.Text = "Risk Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.side_menu_FormClosed);
            this.Load += new System.EventHandler(this.side_menu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.databaseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.risksDataGridView)).EndInit();
            this.filterMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.risksDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.addRiskTabPage.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage databaseTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage addRiskTabPage;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker nextRevisionDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox riskIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRiskButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox controlMeasuresTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox statusAfterComboBox;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox consequenceAfterComboBox;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox probabilityAfterComboBox;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox responsiblePersonTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox riskResponseTextBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox consequenceComboBox;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox probabilityComboBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox riskCategoryComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView risksDataGridView;
        private RisksDataSet risksDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private RisksDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextRevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlMeasureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsiblePersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consequenceAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button viewFiltersButton;
        private System.Windows.Forms.ContextMenuStrip filterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFIlterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRiskToolStripMenuItem;
    }
}