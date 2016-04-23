using System;
using System.Reflection;
using System.Windows.Forms;

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
            this.TitleName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleRegion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitlePublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TitleSerial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.renameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleView)).BeginInit();
            this.SuspendLayout();
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(182, 11);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(540, 20);
            this.locationBox.TabIndex = 1;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(728, 9);
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
            this.isEncrypted.Location = new System.Drawing.Point(693, 249);
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
            this.loadKeyDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadKeyDB.Location = new System.Drawing.Point(551, 245);
            this.loadKeyDB.Name = "loadKeyDB";
            this.loadKeyDB.Size = new System.Drawing.Size(136, 23);
            this.loadKeyDB.TabIndex = 8;
            this.loadKeyDB.Text = "Download/Load Key DB";
            this.loadKeyDB.UseVisualStyleBackColor = true;
            this.loadKeyDB.Click += new System.EventHandler(this.loadKeyDB_Click);
            // 
            // titleView
            // 
            this.titleView.AllColumns.Add(this.TitleName);
            this.titleView.AllColumns.Add(this.TitleID);
            this.titleView.AllColumns.Add(this.TitleKey);
            this.titleView.AllColumns.Add(this.TitleRegion);
            this.titleView.AllColumns.Add(this.TitleSize);
            this.titleView.AllColumns.Add(this.TitleType);
            this.titleView.AllColumns.Add(this.TitlePublisher);
            this.titleView.AllColumns.Add(this.TitleSerial);
            this.titleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleName,
            this.TitleID,
            this.TitleKey,
            this.TitleRegion,
            this.TitleSize,
            this.TitleType,
            this.TitlePublisher,
            this.TitleSerial});
            this.titleView.FullRowSelect = true;
            this.titleView.GridLines = true;
            this.titleView.Location = new System.Drawing.Point(13, 38);
            this.titleView.Name = "titleView";
            this.titleView.ShowGroups = false;
            this.titleView.Size = new System.Drawing.Size(790, 201);
            this.titleView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.titleView.TabIndex = 11;
            this.titleView.UseCompatibleStateImageBehavior = false;
            this.titleView.View = System.Windows.Forms.View.Details;
            this.titleView.ItemActivate += new System.EventHandler(this.titleView_ItemActivate);
            // 
            // TitleName
            // 
            this.TitleName.AspectName = "Name";
            this.TitleName.Text = "Title Name";
            this.TitleName.Width = 138;
            // 
            // TitleID
            // 
            this.TitleID.AspectName = "TitleId";
            this.TitleID.Text = "Title ID";
            this.TitleID.Width = 115;
            // 
            // TitleKey
            // 
            this.TitleKey.AspectName = "TitleKey";
            this.TitleKey.Text = "Title Key";
            this.TitleKey.Width = 206;
            // 
            // TitleRegion
            // 
            this.TitleRegion.AspectName = "Region";
            this.TitleRegion.Text = "Region";
            this.TitleRegion.Width = 47;
            // 
            // TitleSize
            // 
            this.TitleSize.AspectName = "SizeInMegabytes";
            this.TitleSize.AspectToStringFormat = "{0}MB";
            this.TitleSize.Text = "Size";
            this.TitleSize.Width = 36;
            // 
            // TitleType
            // 
            this.TitleType.AspectName = "Type";
            this.TitleType.Text = "Type";
            this.TitleType.Width = 43;
            // 
            // TitlePublisher
            // 
            this.TitlePublisher.AspectName = "Publisher";
            this.TitlePublisher.Text = "Publisher";
            this.TitlePublisher.Width = 113;
            // 
            // TitleSerial
            // 
            this.TitleSerial.AspectName = "Serial";
            this.TitleSerial.Text = "Serial";
            this.TitleSerial.Width = 64;
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(470, 245);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 12;
            this.renameButton.Text = "Sort CIAs";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 272);
            this.Controls.Add(this.renameButton);
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

        }

        #endregion
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.CheckBox isEncrypted;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button loadKeyDB;
        private BrightIdeasSoftware.ObjectListView titleView;
        private BrightIdeasSoftware.OLVColumn TitleName;
        private BrightIdeasSoftware.OLVColumn TitleID;
        private BrightIdeasSoftware.OLVColumn TitleKey;
        private BrightIdeasSoftware.OLVColumn TitleRegion;
        private BrightIdeasSoftware.OLVColumn TitleSize;
        private BrightIdeasSoftware.OLVColumn TitleType;
        private BrightIdeasSoftware.OLVColumn TitlePublisher;
        private BrightIdeasSoftware.OLVColumn TitleSerial;
        private Button renameButton;
    }
}

