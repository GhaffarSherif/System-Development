namespace WindowsFormsApplication1
{
    partial class filterList
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
            this.filterListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.filterTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // filterListView
            // 
            this.filterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filterTypeColumn,
            this.filterValueColumn});
            this.filterListView.Location = new System.Drawing.Point(12, 12);
            this.filterListView.Name = "filterListView";
            this.filterListView.Size = new System.Drawing.Size(260, 208);
            this.filterListView.TabIndex = 0;
            this.filterListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filterTypeColumn
            // 
            this.filterTypeColumn.Text = "Filter Type";
            // 
            // filterValueColumn
            // 
            this.filterValueColumn.Text = "Filter Value";
            // 
            // filterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterListView);
            this.Name = "filterList";
            this.Text = "Filter List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.filterList_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView filterListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader filterTypeColumn;
        private System.Windows.Forms.ColumnHeader filterValueColumn;
    }
}