using System.Collections;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.locationBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.isEncrypted = new System.Windows.Forms.CheckBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.loadKeyDB = new System.Windows.Forms.Button();
            this.titleView = new BrightIdeasSoftware.ObjectListView();
            this.titleName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titleId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titleKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titleRegion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titleSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titileType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titlePublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.titleSerial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.titleView)).BeginInit();
            this.SuspendLayout();
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(182, 12);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(647, 20);
            this.locationBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(835, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
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
            this.isEncrypted.Location = new System.Drawing.Point(800, 308);
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
            this.countLabel.Location = new System.Drawing.Point(12, 309);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(75, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "1 titles loaded.";
            this.countLabel.Click += new System.EventHandler(this.countLabel_Click);
            // 
            // loadKeyDB
            // 
            this.loadKeyDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadKeyDB.Location = new System.Drawing.Point(658, 304);
            this.loadKeyDB.Name = "loadKeyDB";
            this.loadKeyDB.Size = new System.Drawing.Size(136, 23);
            this.loadKeyDB.TabIndex = 8;
            this.loadKeyDB.Text = "Download/Load Key DB";
            this.loadKeyDB.UseVisualStyleBackColor = true;
            this.loadKeyDB.Click += new System.EventHandler(this.loadKeyDB_Click);
            // 
            // titleView
            // 
            this.titleView.AllColumns.Add(this.titleName);
            this.titleView.AllColumns.Add(this.titleId);
            this.titleView.AllColumns.Add(this.titleKey);
            this.titleView.AllColumns.Add(this.titleRegion);
            this.titleView.AllColumns.Add(this.titleSize);
            this.titleView.AllColumns.Add(this.titileType);
            this.titleView.AllColumns.Add(this.titlePublisher);
            this.titleView.AllColumns.Add(this.titleSerial);
            this.titleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleName,
            this.titleId,
            this.titleKey,
            this.titleRegion,
            this.titleSize,
            this.titileType,
            this.titlePublisher,
            this.titleSerial});
            this.titleView.FullRowSelect = true;
            this.titleView.GridLines = true;
            this.titleView.Location = new System.Drawing.Point(12, 38);
            this.titleView.MultiSelect = false;
            this.titleView.Name = "titleView";
            this.titleView.ShowGroups = false;
            this.titleView.Size = new System.Drawing.Size(898, 260);
            this.titleView.TabIndex = 9;
            this.titleView.UseCompatibleStateImageBehavior = false;
            this.titleView.View = System.Windows.Forms.View.Details;
            this.titleView.VirtualMode = true;
            // 
            // titleName
            // 
            this.titleName.Text = "Title Name";
            this.titleName.Width = 130;
            // 
            // titleId
            // 
            this.titleId.Text = "Title ID";
            this.titleId.Width = 130;
            // 
            // titleKey
            // 
            this.titleKey.Text = "Title Key";
            this.titleKey.Width = 230;
            // 
            // titleRegion
            // 
            this.titleRegion.Text = "Region";
            this.titleRegion.Width = 70;
            // 
            // titleSize
            // 
            this.titleSize.Text = "Size";
            this.titleSize.Width = 45;
            // 
            // titileType
            // 
            this.titileType.Text = "Type";
            this.titileType.Width = 70;
            // 
            // titlePublisher
            // 
            this.titlePublisher.Text = "Publisher";
            this.titlePublisher.Width = 120;
            // 
            // titleSerial
            // 
            this.titleSerial.MaximumWidth = 100;
            this.titleSerial.MinimumWidth = 70;
            this.titleSerial.Text = "Serial";
            this.titleSerial.Width = 70;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 331);
            this.Controls.Add(this.titleView);
            this.Controls.Add(this.loadKeyDB);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.isEncrypted);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.locationBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "D.T.K. - D.T.K. Takes Keys";
            ((System.ComponentModel.ISupportInitialize)(this.titleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            //this.titleView.SetObjects();

        }

        #endregion
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.CheckBox isEncrypted;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button loadKeyDB;
        private BrightIdeasSoftware.ObjectListView titleView;
        private BrightIdeasSoftware.OLVColumn titleName;
        private BrightIdeasSoftware.OLVColumn titleId;
        private BrightIdeasSoftware.OLVColumn titleKey;
        private BrightIdeasSoftware.OLVColumn titleRegion;
        private BrightIdeasSoftware.OLVColumn titleSize;
        private BrightIdeasSoftware.OLVColumn titileType;
        private BrightIdeasSoftware.OLVColumn titlePublisher;
        private BrightIdeasSoftware.OLVColumn titleSerial;
    }
}

