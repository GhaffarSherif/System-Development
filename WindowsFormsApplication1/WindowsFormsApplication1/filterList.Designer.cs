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
            this.removeFilterButton = new System.Windows.Forms.Button();
            this.filterListBox = new System.Windows.Forms.ListBox();
            this.groupAndButton = new System.Windows.Forms.Button();
            this.groupOrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeFilterButton
            // 
            this.removeFilterButton.Location = new System.Drawing.Point(12, 226);
            this.removeFilterButton.Name = "removeFilterButton";
            this.removeFilterButton.Size = new System.Drawing.Size(80, 23);
            this.removeFilterButton.TabIndex = 1;
            this.removeFilterButton.Text = "Remove Filter";
            this.removeFilterButton.UseVisualStyleBackColor = true;
            this.removeFilterButton.Click += new System.EventHandler(this.removeFilterButton_Click);
            // 
            // filterListBox
            // 
            this.filterListBox.FormattingEnabled = true;
            this.filterListBox.HorizontalScrollbar = true;
            this.filterListBox.Location = new System.Drawing.Point(12, 9);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filterListBox.Size = new System.Drawing.Size(256, 212);
            this.filterListBox.TabIndex = 2;
            // 
            // groupAndButton
            // 
            this.groupAndButton.Location = new System.Drawing.Point(124, 226);
            this.groupAndButton.Name = "groupAndButton";
            this.groupAndButton.Size = new System.Drawing.Size(72, 23);
            this.groupAndButton.TabIndex = 3;
            this.groupAndButton.Tag = "";
            this.groupAndButton.Text = "Group AND";
            this.groupAndButton.UseVisualStyleBackColor = true;
            this.groupAndButton.Click += new System.EventHandler(this.groupAndButton_Click);
            // 
            // groupOrButton
            // 
            this.groupOrButton.Location = new System.Drawing.Point(202, 226);
            this.groupOrButton.Name = "groupOrButton";
            this.groupOrButton.Size = new System.Drawing.Size(66, 23);
            this.groupOrButton.TabIndex = 4;
            this.groupOrButton.Tag = "";
            this.groupOrButton.Text = "Group OR";
            this.groupOrButton.UseVisualStyleBackColor = true;
            this.groupOrButton.Click += new System.EventHandler(this.groupOrButton_Click);
            // 
            // filterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupOrButton);
            this.Controls.Add(this.groupAndButton);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.removeFilterButton);
            this.Name = "filterList";
            this.Text = "Filter List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.filterList_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeFilterButton;
        private System.Windows.Forms.ListBox filterListBox;
        private System.Windows.Forms.Button groupAndButton;
        private System.Windows.Forms.Button groupOrButton;
    }
}