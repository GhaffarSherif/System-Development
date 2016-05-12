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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(side_menu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.printBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.databaseTabPage = new System.Windows.Forms.TabPage();
            this.risksDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextRevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsiblePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsequenceAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRevisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlMeasuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsiblePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.probabilityAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consequenceAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.risksDataSet = new WindowsFormsApplication1.RisksDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.filterComparisonComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.filterValueComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewFiltersButton = new System.Windows.Forms.Button();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addRiskTabPage = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.clearFieldsButton = new System.Windows.Forms.Button();
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
            this.responsiblePersonComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.riskResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.controlMeasureTextBox = new System.Windows.Forms.RichTextBox();
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.addRiskTabPage.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel16.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.printBtn);
            this.splitContainer1.Panel1.Controls.Add(this.settingsButton);
            this.splitContainer1.Panel1.Controls.Add(this.userLabel);
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.exportButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(780, 671);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(13, 86);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(128, 36);
            this.printBtn.TabIndex = 10;
            this.printBtn.TabStop = false;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 128);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(129, 37);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.TabStop = false;
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
            this.logoutButton.TabStop = false;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(13, 43);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(129, 37);
            this.exportButton.TabIndex = 3;
            this.exportButton.TabStop = false;
            this.exportButton.Text = "Export to Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.databaseTabPage);
            this.tabControl1.Controls.Add(this.addRiskTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 665);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.risksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.risksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.risksDataGridView.AutoGenerateColumns = false;
            this.risksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.risksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.NextRevision,
            this.Category,
            this.Description,
            this.Probability,
            this.Consequence,
            this.Status,
            this.Evaluation,
            this.ControlMeasure,
            this.Response,
            this.ResponsiblePerson,
            this.ProbabilityAfter,
            this.ConsequenceAfter,
            this.StatusAfter,
            this.EvaluationAfter});
            this.risksDataGridView.ContextMenuStrip = this.filterMenuStrip;
            this.risksDataGridView.DataSource = this.tableBindingSource;
            this.risksDataGridView.Location = new System.Drawing.Point(29, 154);
            this.risksDataGridView.Name = "risksDataGridView";
            this.risksDataGridView.ReadOnly = true;
            this.risksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.risksDataGridView.Size = new System.Drawing.Size(578, 468);
            this.risksDataGridView.TabIndex = 0;
            this.risksDataGridView.TabStop = false;
            this.risksDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.risksDataGridView_CellMouseDown);
            this.risksDataGridView.Sorted += new System.EventHandler(this.risksDataGridView_Sorted);
            this.risksDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.risksDataGridView_KeyDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // NextRevision
            // 
            this.NextRevision.DataPropertyName = "Next Revision";
            this.NextRevision.HeaderText = "Next Revision";
            this.NextRevision.Name = "NextRevision";
            this.NextRevision.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Probability
            // 
            this.Probability.DataPropertyName = "Probability";
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            this.Probability.ReadOnly = true;
            // 
            // Consequence
            // 
            this.Consequence.DataPropertyName = "Consequence";
            this.Consequence.HeaderText = "Consequence";
            this.Consequence.Name = "Consequence";
            this.Consequence.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Evaluation
            // 
            this.Evaluation.DataPropertyName = "Evaluation";
            this.Evaluation.HeaderText = "Evaluation";
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.ReadOnly = true;
            // 
            // ControlMeasure
            // 
            this.ControlMeasure.DataPropertyName = "Control Measure";
            this.ControlMeasure.HeaderText = "Control Measure";
            this.ControlMeasure.Name = "ControlMeasure";
            this.ControlMeasure.ReadOnly = true;
            // 
            // Response
            // 
            this.Response.DataPropertyName = "Response";
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            // 
            // ResponsiblePerson
            // 
            this.ResponsiblePerson.DataPropertyName = "Responsible Person";
            this.ResponsiblePerson.HeaderText = "Responsible Person";
            this.ResponsiblePerson.Name = "ResponsiblePerson";
            this.ResponsiblePerson.ReadOnly = true;
            // 
            // ProbabilityAfter
            // 
            this.ProbabilityAfter.DataPropertyName = "Probability After";
            this.ProbabilityAfter.HeaderText = "Probability After";
            this.ProbabilityAfter.Name = "ProbabilityAfter";
            this.ProbabilityAfter.ReadOnly = true;
            // 
            // ConsequenceAfter
            // 
            this.ConsequenceAfter.DataPropertyName = "Consequence After";
            this.ConsequenceAfter.HeaderText = "Consequence After";
            this.ConsequenceAfter.Name = "ConsequenceAfter";
            this.ConsequenceAfter.ReadOnly = true;
            // 
            // StatusAfter
            // 
            this.StatusAfter.DataPropertyName = "Status After";
            this.StatusAfter.HeaderText = "Status After";
            this.StatusAfter.Name = "StatusAfter";
            this.StatusAfter.ReadOnly = true;
            // 
            // EvaluationAfter
            // 
            this.EvaluationAfter.DataPropertyName = "Evaluation After";
            this.EvaluationAfter.HeaderText = "Evaluation After";
            this.EvaluationAfter.Name = "EvaluationAfter";
            this.EvaluationAfter.ReadOnly = true;
            // 
            // filterMenuStrip
            // 
            this.filterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnsToolStripMenuItem,
            this.editRiskToolStripMenuItem,
            this.deleteRiskToolStripMenuItem});
            this.filterMenuStrip.Name = "filterMenuStrip";
            this.filterMenuStrip.Size = new System.Drawing.Size(132, 70);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicInformationToolStripMenuItem,
            this.priorityToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // basicInformationToolStripMenuItem
            // 
            this.basicInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.nextRevisionToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.descriptionToolStripMenuItem});
            this.basicInformationToolStripMenuItem.Name = "basicInformationToolStripMenuItem";
            this.basicInformationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.basicInformationToolStripMenuItem.Text = "Basic Information";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Checked = true;
            this.iDToolStripMenuItem.CheckOnClick = true;
            this.iDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Checked = true;
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // nextRevisionToolStripMenuItem
            // 
            this.nextRevisionToolStripMenuItem.Checked = true;
            this.nextRevisionToolStripMenuItem.CheckOnClick = true;
            this.nextRevisionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nextRevisionToolStripMenuItem.Name = "nextRevisionToolStripMenuItem";
            this.nextRevisionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nextRevisionToolStripMenuItem.Text = "NextRevision";
            this.nextRevisionToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Checked = true;
            this.categoryToolStripMenuItem.CheckOnClick = true;
            this.categoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Checked = true;
            this.descriptionToolStripMenuItem.CheckOnClick = true;
            this.descriptionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probabilityToolStripMenuItem,
            this.consequenceToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.evaluationToolStripMenuItem});
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.priorityToolStripMenuItem.Text = "Priority";
            // 
            // probabilityToolStripMenuItem
            // 
            this.probabilityToolStripMenuItem.Checked = true;
            this.probabilityToolStripMenuItem.CheckOnClick = true;
            this.probabilityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.probabilityToolStripMenuItem.Name = "probabilityToolStripMenuItem";
            this.probabilityToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.probabilityToolStripMenuItem.Text = "Probability";
            this.probabilityToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // consequenceToolStripMenuItem
            // 
            this.consequenceToolStripMenuItem.Checked = true;
            this.consequenceToolStripMenuItem.CheckOnClick = true;
            this.consequenceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consequenceToolStripMenuItem.Name = "consequenceToolStripMenuItem";
            this.consequenceToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.consequenceToolStripMenuItem.Text = "Consequence";
            this.consequenceToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Checked = true;
            this.statusToolStripMenuItem.CheckOnClick = true;
            this.statusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // evaluationToolStripMenuItem
            // 
            this.evaluationToolStripMenuItem.Checked = true;
            this.evaluationToolStripMenuItem.CheckOnClick = true;
            this.evaluationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.evaluationToolStripMenuItem.Name = "evaluationToolStripMenuItem";
            this.evaluationToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.evaluationToolStripMenuItem.Text = "Evaluation";
            this.evaluationToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlMeasuresToolStripMenuItem,
            this.responseToolStripMenuItem,
            this.responsiblePersonToolStripMenuItem,
            this.toolStripSeparator2,
            this.probabilityAfterToolStripMenuItem,
            this.consequenceAfterToolStripMenuItem,
            this.statusAfterToolStripMenuItem,
            this.evaluationAfterToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // controlMeasuresToolStripMenuItem
            // 
            this.controlMeasuresToolStripMenuItem.Checked = true;
            this.controlMeasuresToolStripMenuItem.CheckOnClick = true;
            this.controlMeasuresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.controlMeasuresToolStripMenuItem.Name = "controlMeasuresToolStripMenuItem";
            this.controlMeasuresToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.controlMeasuresToolStripMenuItem.Text = "ControlMeasure";
            this.controlMeasuresToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // responseToolStripMenuItem
            // 
            this.responseToolStripMenuItem.Checked = true;
            this.responseToolStripMenuItem.CheckOnClick = true;
            this.responseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.responseToolStripMenuItem.Name = "responseToolStripMenuItem";
            this.responseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.responseToolStripMenuItem.Text = "Response";
            this.responseToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // responsiblePersonToolStripMenuItem
            // 
            this.responsiblePersonToolStripMenuItem.Checked = true;
            this.responsiblePersonToolStripMenuItem.CheckOnClick = true;
            this.responsiblePersonToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.responsiblePersonToolStripMenuItem.Name = "responsiblePersonToolStripMenuItem";
            this.responsiblePersonToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.responsiblePersonToolStripMenuItem.Text = "ResponsiblePerson";
            this.responsiblePersonToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // probabilityAfterToolStripMenuItem
            // 
            this.probabilityAfterToolStripMenuItem.Checked = true;
            this.probabilityAfterToolStripMenuItem.CheckOnClick = true;
            this.probabilityAfterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.probabilityAfterToolStripMenuItem.Name = "probabilityAfterToolStripMenuItem";
            this.probabilityAfterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.probabilityAfterToolStripMenuItem.Text = "ProbabilityAfter";
            this.probabilityAfterToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // consequenceAfterToolStripMenuItem
            // 
            this.consequenceAfterToolStripMenuItem.Checked = true;
            this.consequenceAfterToolStripMenuItem.CheckOnClick = true;
            this.consequenceAfterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consequenceAfterToolStripMenuItem.Name = "consequenceAfterToolStripMenuItem";
            this.consequenceAfterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consequenceAfterToolStripMenuItem.Text = "ConsequenceAfter";
            this.consequenceAfterToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // statusAfterToolStripMenuItem
            // 
            this.statusAfterToolStripMenuItem.Checked = true;
            this.statusAfterToolStripMenuItem.CheckOnClick = true;
            this.statusAfterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusAfterToolStripMenuItem.Name = "statusAfterToolStripMenuItem";
            this.statusAfterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.statusAfterToolStripMenuItem.Text = "StatusAfter";
            this.statusAfterToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // evaluationAfterToolStripMenuItem
            // 
            this.evaluationAfterToolStripMenuItem.Checked = true;
            this.evaluationAfterToolStripMenuItem.CheckOnClick = true;
            this.evaluationAfterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.evaluationAfterToolStripMenuItem.Name = "evaluationAfterToolStripMenuItem";
            this.evaluationAfterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.evaluationAfterToolStripMenuItem.Text = "EvaluationAfter";
            this.evaluationAfterToolStripMenuItem.Click += new System.EventHandler(this.columnsToolMenuStrip_Click);
            // 
            // editRiskToolStripMenuItem
            // 
            this.editRiskToolStripMenuItem.Name = "editRiskToolStripMenuItem";
            this.editRiskToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editRiskToolStripMenuItem.Text = "Edit Risk";
            this.editRiskToolStripMenuItem.Click += new System.EventHandler(this.editRiskToolStripMenuItem_Click);
            // 
            // deleteRiskToolStripMenuItem
            // 
            this.deleteRiskToolStripMenuItem.Name = "deleteRiskToolStripMenuItem";
            this.deleteRiskToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteRiskToolStripMenuItem.Text = "Delete Risk";
            this.deleteRiskToolStripMenuItem.Click += new System.EventHandler(this.deleteRiskToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.viewFiltersButton);
            this.groupBox1.Controls.Add(this.addFilterButton);
            this.groupBox1.Controls.Add(this.clearFiltersButton);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.filterComparisonComboBox);
            this.panel6.Location = new System.Drawing.Point(150, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 58);
            this.panel6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comparison";
            // 
            // filterComparisonComboBox
            // 
            this.filterComparisonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComparisonComboBox.FormattingEnabled = true;
            this.filterComparisonComboBox.Location = new System.Drawing.Point(3, 25);
            this.filterComparisonComboBox.Name = "filterComparisonComboBox";
            this.filterComparisonComboBox.Size = new System.Drawing.Size(93, 21);
            this.filterComparisonComboBox.TabIndex = 1;
            this.filterComparisonComboBox.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.filterValueComboBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(252, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 58);
            this.panel5.TabIndex = 8;
            // 
            // filterValueComboBox
            // 
            this.filterValueComboBox.DataSource = this.tableBindingSource;
            this.filterValueComboBox.FormattingEnabled = true;
            this.filterValueComboBox.Location = new System.Drawing.Point(3, 25);
            this.filterValueComboBox.Name = "filterValueComboBox";
            this.filterValueComboBox.Size = new System.Drawing.Size(292, 21);
            this.filterValueComboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Value";
            // 
            // viewFiltersButton
            // 
            this.viewFiltersButton.Location = new System.Drawing.Point(23, 87);
            this.viewFiltersButton.Name = "viewFiltersButton";
            this.viewFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.viewFiltersButton.TabIndex = 6;
            this.viewFiltersButton.TabStop = false;
            this.viewFiltersButton.Text = "View Filters";
            this.viewFiltersButton.UseVisualStyleBackColor = true;
            this.viewFiltersButton.Click += new System.EventHandler(this.viewFiltersButton_Click);
            // 
            // addFilterButton
            // 
            this.addFilterButton.Location = new System.Drawing.Point(104, 87);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(75, 23);
            this.addFilterButton.TabIndex = 5;
            this.addFilterButton.TabStop = false;
            this.addFilterButton.Text = "Add Filter";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.Location = new System.Drawing.Point(464, 87);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.clearFiltersButton.TabIndex = 4;
            this.clearFiltersButton.TabStop = false;
            this.clearFiltersButton.Text = "Clear Filters";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.filterTypeComboBox);
            this.panel4.Location = new System.Drawing.Point(17, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 58);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.FormattingEnabled = true;
            this.filterTypeComboBox.Location = new System.Drawing.Point(6, 25);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterTypeComboBox.TabIndex = 2;
            this.filterTypeComboBox.TabStop = false;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterTypeComboBox_SelectedIndexChanged);
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
            this.panel15.Controls.Add(this.clearFieldsButton);
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
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(4, 603);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.clearFieldsButton.TabIndex = 12;
            this.clearFieldsButton.TabStop = false;
            this.clearFieldsButton.Text = "Clear";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
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
            this.nextRevisionDateTimePicker.TabStop = false;
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
            this.dateTimePicker.TabStop = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.addRiskButton.TabStop = false;
            this.addRiskButton.Text = "Add";
            this.addRiskButton.UseVisualStyleBackColor = true;
            this.addRiskButton.Click += new System.EventHandler(this.addRiskButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.panel21);
            this.groupBox5.Controls.Add(this.panel22);
            this.groupBox5.Controls.Add(this.panel16);
            this.groupBox5.Location = new System.Drawing.Point(4, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 297);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel18);
            this.groupBox6.Controls.Add(this.panel19);
            this.groupBox6.Controls.Add(this.panel20);
            this.groupBox6.Location = new System.Drawing.Point(19, 171);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(526, 105);
            this.groupBox6.TabIndex = 8;
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
            this.consequenceAfterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consequenceAfterComboBox.FormattingEnabled = true;
            this.consequenceAfterComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
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
            this.probabilityAfterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.probabilityAfterComboBox.FormattingEnabled = true;
            this.probabilityAfterComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.probabilityAfterComboBox.Location = new System.Drawing.Point(76, 3);
            this.probabilityAfterComboBox.Name = "probabilityAfterComboBox";
            this.probabilityAfterComboBox.Size = new System.Drawing.Size(121, 21);
            this.probabilityAfterComboBox.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.responsiblePersonComboBox);
            this.panel21.Controls.Add(this.label19);
            this.panel21.Location = new System.Drawing.Point(111, 129);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(278, 36);
            this.panel21.TabIndex = 7;
            // 
            // responsiblePersonComboBox
            // 
            this.responsiblePersonComboBox.FormattingEnabled = true;
            this.responsiblePersonComboBox.Location = new System.Drawing.Point(110, 7);
            this.responsiblePersonComboBox.Name = "responsiblePersonComboBox";
            this.responsiblePersonComboBox.Size = new System.Drawing.Size(165, 21);
            this.responsiblePersonComboBox.TabIndex = 1;
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
            this.panel22.TabIndex = 6;
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
            // panel16
            // 
            this.panel16.Controls.Add(this.label14);
            this.panel16.Controls.Add(this.controlMeasureTextBox);
            this.panel16.Location = new System.Drawing.Point(6, 19);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(550, 49);
            this.panel16.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Control Measure";
            // 
            // controlMeasureTextBox
            // 
            this.controlMeasureTextBox.Location = new System.Drawing.Point(105, 3);
            this.controlMeasureTextBox.Name = "controlMeasureTextBox";
            this.controlMeasureTextBox.Size = new System.Drawing.Size(441, 42);
            this.controlMeasureTextBox.TabIndex = 0;
            this.controlMeasureTextBox.Text = "";
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
            this.consequenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consequenceComboBox.FormattingEnabled = true;
            this.consequenceComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
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
            this.probabilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
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
            this.groupBox8.Text = "Basic Information";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // side_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 671);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "side_menu";
            this.Text = "Risk Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.side_menu_FormClosed);
            this.Load += new System.EventHandler(this.side_menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.side_menu_KeyDown);
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
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
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage databaseTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
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
        private System.Windows.Forms.RichTextBox controlMeasureTextBox;
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
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button viewFiltersButton;
        private System.Windows.Forms.ContextMenuStrip filterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editRiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRevisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlMeasuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsiblePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probabilityAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consequenceAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteRiskToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsiblePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsequenceAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationAfter;
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
        private System.Windows.Forms.ComboBox responsiblePersonComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox riskResponseTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterComparisonComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox filterValueComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}