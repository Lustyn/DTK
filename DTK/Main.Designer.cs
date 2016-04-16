namespace DTK
{
    partial class Main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Retro City Rampage: DX",
            "000400000010d200",
            "[REDACTED]",
            "USA",
            "True"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.locationBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.titleView = new System.Windows.Forms.ListView();
            this.titleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isLegit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(12, 12);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(460, 20);
            this.locationBox.TabIndex = 1;
            this.locationBox.Text = "C:\\Users\\justy\\Desktop\\DTK\\decTitleKeys.bin";
            this.locationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(478, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 20);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // titleView
            // 
            this.titleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleName,
            this.titleID,
            this.titleKey,
            this.region,
            this.isLegit});
            this.titleView.GridLines = true;
            this.titleView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.titleView.Location = new System.Drawing.Point(12, 38);
            this.titleView.Name = "titleView";
            this.titleView.Size = new System.Drawing.Size(541, 211);
            this.titleView.TabIndex = 3;
            this.titleView.UseCompatibleStateImageBehavior = false;
            this.titleView.View = System.Windows.Forms.View.Details;
            // 
            // titleName
            // 
            this.titleName.Text = "Title Name";
            this.titleName.Width = 126;
            // 
            // titleID
            // 
            this.titleID.Text = "Title ID";
            this.titleID.Width = 108;
            // 
            // titleKey
            // 
            this.titleKey.Text = "Title Key";
            this.titleKey.Width = 201;
            // 
            // region
            // 
            this.region.Text = "Region";
            this.region.Width = 46;
            // 
            // isLegit
            // 
            this.isLegit.Text = "Is Legit?";
            this.isLegit.Width = 55;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.titleView);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.locationBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "D.T.K. - D.T.K. Takes Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListView titleView;
        private System.Windows.Forms.ColumnHeader titleName;
        private System.Windows.Forms.ColumnHeader titleID;
        private System.Windows.Forms.ColumnHeader titleKey;
        private System.Windows.Forms.ColumnHeader region;
        private System.Windows.Forms.ColumnHeader isLegit;
    }
}

