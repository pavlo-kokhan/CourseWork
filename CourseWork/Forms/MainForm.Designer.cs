namespace CourseWork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.HeadMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new System.Windows.Forms.Button();
            this.OpenMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ObjectsListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VCodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubtitlesAvaliabilityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonsPanel.SuspendLayout();
            this.HeadMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.BackColor = System.Drawing.Color.White;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.ClearButton);
            this.ButtonsPanel.Controls.Add(this.FilterButton);
            this.ButtonsPanel.Controls.Add(this.RemoveButton);
            this.ButtonsPanel.Controls.Add(this.AddButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 33);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(88, 415);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // HeadMenuStrip
            // 
            this.HeadMenuStrip.BackColor = System.Drawing.Color.LightSlateGray;
            this.HeadMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.HelpMenuStrip});
            this.HeadMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HeadMenuStrip.Name = "HeadMenuStrip";
            this.HeadMenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.HeadMenuStrip.Size = new System.Drawing.Size(884, 29);
            this.HeadMenuStrip.TabIndex = 2;
            this.HeadMenuStrip.Text = "MenuStrip";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.BackColor = System.Drawing.Color.LightSlateGray;
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuStripButton,
            this.SaveMenuStripButton});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(40, 23);
            this.FileMenuStrip.Text = "File";
            // 
            // SaveMenuStripButton
            // 
            this.SaveMenuStripButton.Name = "SaveMenuStripButton";
            this.SaveMenuStripButton.Size = new System.Drawing.Size(180, 24);
            this.SaveMenuStripButton.Text = "Save";
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuStripButton});
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.Size = new System.Drawing.Size(44, 23);
            this.HelpMenuStrip.Text = "Help";
            // 
            // AboutMenuStripButton
            // 
            this.AboutMenuStripButton.Name = "AboutMenuStripButton";
            this.AboutMenuStripButton.Size = new System.Drawing.Size(108, 24);
            this.AboutMenuStripButton.Text = "About";
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(3, 76);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(80, 28);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // OpenMenuStripButton
            // 
            this.OpenMenuStripButton.Name = "OpenMenuStripButton";
            this.OpenMenuStripButton.Size = new System.Drawing.Size(180, 24);
            this.OpenMenuStripButton.Text = "Open";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(3, 40);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(80, 28);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(3, 4);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 28);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(3, 112);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 28);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ObjectsListView
            // 
            this.ObjectsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.LocationHeader,
            this.FormatHeader,
            this.DurationHeader,
            this.VCodecHeader,
            this.ACodecHeader,
            this.SubtitlesAvaliabilityHeader,
            this.SizeHeader,
            this.PlayerHeader});
            this.ObjectsListView.HideSelection = false;
            this.ObjectsListView.Location = new System.Drawing.Point(106, 33);
            this.ObjectsListView.Name = "ObjectsListView";
            this.ObjectsListView.Size = new System.Drawing.Size(766, 416);
            this.ObjectsListView.TabIndex = 3;
            this.ObjectsListView.UseCompatibleStateImageBehavior = false;
            this.ObjectsListView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 94;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 121;
            // 
            // FormatHeader
            // 
            this.FormatHeader.Text = "Format";
            this.FormatHeader.Width = 101;
            // 
            // DurationHeader
            // 
            this.DurationHeader.Text = "Duration";
            this.DurationHeader.Width = 78;
            // 
            // VCodecHeader
            // 
            this.VCodecHeader.Text = "Video Codec";
            this.VCodecHeader.Width = 83;
            // 
            // ACodecHeader
            // 
            this.ACodecHeader.Text = "Audio Codec";
            this.ACodecHeader.Width = 82;
            // 
            // SubtitlesAvaliabilityHeader
            // 
            this.SubtitlesAvaliabilityHeader.Text = "Subtitles";
            this.SubtitlesAvaliabilityHeader.Width = 69;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Size";
            this.SizeHeader.Width = 66;
            // 
            // PlayerHeader
            // 
            this.PlayerHeader.Text = "Player";
            this.PlayerHeader.Width = 63;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ObjectsListView);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.HeadMenuStrip);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.HeadMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseWork";
            this.ButtonsPanel.ResumeLayout(false);
            this.HeadMenuStrip.ResumeLayout(false);
            this.HeadMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.MenuStrip HeadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuStripButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuStripButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ListView ObjectsListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader FormatHeader;
        private System.Windows.Forms.ColumnHeader DurationHeader;
        private System.Windows.Forms.ColumnHeader VCodecHeader;
        private System.Windows.Forms.ColumnHeader ACodecHeader;
        private System.Windows.Forms.ColumnHeader SubtitlesAvaliabilityHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader PlayerHeader;
    }
}

