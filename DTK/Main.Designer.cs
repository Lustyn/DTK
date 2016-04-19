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
            "1024",
            "eShop",
            "Vblank Entertainment",
            "CTR-JRXE"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.locationBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.titleView = new System.Windows.Forms.ListView();
            this.titleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.isEncrypted = new System.Windows.Forms.CheckBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.loadKeyDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(182, 12);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(493, 20);
            this.locationBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(681, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
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
            this.size,
            this.type,
            this.publisher,
            this.serial});
            this.titleView.FullRowSelect = true;
            this.titleView.GridLines = true;
            this.titleView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.titleView.Location = new System.Drawing.Point(12, 38);
            this.titleView.Name = "titleView";
            this.titleView.Size = new System.Drawing.Size(744, 206);
            this.titleView.TabIndex = 3;
            this.titleView.UseCompatibleStateImageBehavior = false;
            this.titleView.View = System.Windows.Forms.View.Details;
            this.titleView.ItemActivate += new System.EventHandler(this.titleView_ItemActivate);
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
            this.region.Width = 49;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 36;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 43;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher";
            this.publisher.Width = 113;
            // 
            // serial
            // 
            this.serial.Text = "Serial";
            this.serial.Width = 64;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(163, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // isEncrypted
            // 
            this.isEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.isEncrypted.AutoSize = true;
            this.isEncrypted.Location = new System.Drawing.Point(646, 249);
            this.isEncrypted.Name = "isEncrypted";
            this.isEncrypted.Size = new System.Drawing.Size(110, 17);
            this.isEncrypted.TabIndex = 5;
            this.isEncrypted.Text = "encTitleKeys.bin?";
            this.isEncrypted.UseVisualStyleBackColor = true;
            this.isEncrypted.CheckedChanged += new System.EventHandler(this.isEncrypted_CheckedChanged);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 250);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(75, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "1 titles loaded.";
            this.countLabel.Click += new System.EventHandler(this.countLabel_Click);
            // 
            // loadKeyDB
            // 
            this.loadKeyDB.Location = new System.Drawing.Point(560, 245);
            this.loadKeyDB.Name = "loadKeyDB";
            this.loadKeyDB.Size = new System.Drawing.Size(80, 23);
            this.loadKeyDB.TabIndex = 8;
            this.loadKeyDB.Text = "Load Key DB";
            this.loadKeyDB.UseVisualStyleBackColor = true;
            this.loadKeyDB.Click += new System.EventHandler(this.loadKeyDB_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 272);
            this.Controls.Add(this.loadKeyDB);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.isEncrypted);
            this.Controls.Add(this.searchBox);
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
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.CheckBox isEncrypted;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button loadKeyDB;
    }
}

