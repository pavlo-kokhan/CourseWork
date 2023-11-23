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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.SourceButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeadMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoFilesListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VCodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubtitlesAvaliabilityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NameSortContextMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NameSortContextMenuAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.NameSortContextMenuDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.DurationSortContextMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DurationSortContextMenuAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.DurationSortContextMenuDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeSortContextMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeSortContextMenuAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeSortContextMenuDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearContextMenuStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.ToolStripRemove = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFilter = new System.Windows.Forms.ToolStripButton();
            this.ToolStripClear = new System.Windows.Forms.ToolStripButton();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.HeadMenuStrip.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.BackColor = System.Drawing.Color.White;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.CurrentButton);
            this.ButtonsPanel.Controls.Add(this.SourceButton);
            this.ButtonsPanel.Controls.Add(this.ClearButton);
            this.ButtonsPanel.Controls.Add(this.FilterButton);
            this.ButtonsPanel.Controls.Add(this.RemoveButton);
            this.ButtonsPanel.Controls.Add(this.AddButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 60);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(88, 388);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // SourceButton
            // 
            this.SourceButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceButton.Location = new System.Drawing.Point(3, 112);
            this.SourceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(80, 28);
            this.SourceButton.TabIndex = 4;
            this.SourceButton.Text = "Source";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(3, 182);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 28);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
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
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
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
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
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
            this.FileMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileMenuStrip.Size = new System.Drawing.Size(40, 23);
            this.FileMenuStrip.Text = "File";
            // 
            // OpenMenuStripButton
            // 
            this.OpenMenuStripButton.Name = "OpenMenuStripButton";
            this.OpenMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuStripButton.Size = new System.Drawing.Size(145, 24);
            this.OpenMenuStripButton.Text = "Open";
            this.OpenMenuStripButton.Click += new System.EventHandler(this.OpenMenuStripButton_Click);
            // 
            // SaveMenuStripButton
            // 
            this.SaveMenuStripButton.Name = "SaveMenuStripButton";
            this.SaveMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuStripButton.Size = new System.Drawing.Size(145, 24);
            this.SaveMenuStripButton.Text = "Save";
            this.SaveMenuStripButton.Click += new System.EventHandler(this.SaveMenuStripButton_Click);
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
            this.AboutMenuStripButton.Click += new System.EventHandler(this.AboutMenuStripButton_Click);
            // 
            // VideoFilesListView
            // 
            this.VideoFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoFilesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.LocationHeader,
            this.FormatHeader,
            this.DurationHeader,
            this.VCodecHeader,
            this.ACodecHeader,
            this.SubtitlesAvaliabilityHeader,
            this.SizeHeader,
            this.PlayerHeader});
            this.VideoFilesListView.FullRowSelect = true;
            this.VideoFilesListView.HideSelection = false;
            this.VideoFilesListView.Location = new System.Drawing.Point(106, 60);
            this.VideoFilesListView.Name = "VideoFilesListView";
            this.VideoFilesListView.Size = new System.Drawing.Size(766, 389);
            this.VideoFilesListView.TabIndex = 1;
            this.VideoFilesListView.UseCompatibleStateImageBehavior = false;
            this.VideoFilesListView.View = System.Windows.Forms.View.Details;
            this.VideoFilesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.VideoFilesListView_ColumnClick);
            this.VideoFilesListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoFilesListView_KeyDown);
            this.VideoFilesListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFilesListView_MouseDown);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 97;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 121;
            // 
            // FormatHeader
            // 
            this.FormatHeader.Text = "Format";
            this.FormatHeader.Width = 56;
            // 
            // DurationHeader
            // 
            this.DurationHeader.Text = "Duration";
            this.DurationHeader.Width = 78;
            // 
            // VCodecHeader
            // 
            this.VCodecHeader.Text = "Video Codec";
            this.VCodecHeader.Width = 75;
            // 
            // ACodecHeader
            // 
            this.ACodecHeader.Text = "Audio Codec";
            this.ACodecHeader.Width = 79;
            // 
            // SubtitlesAvaliabilityHeader
            // 
            this.SubtitlesAvaliabilityHeader.Text = "Subtitles";
            this.SubtitlesAvaliabilityHeader.Width = 62;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Size";
            this.SizeHeader.Width = 124;
            // 
            // PlayerHeader
            // 
            this.PlayerHeader.Text = "Player";
            this.PlayerHeader.Width = 63;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenContextMenuStripButton,
            this.SaveContextMenuStripButton,
            this.AddContextMenuStripButton,
            this.RemoveContextMenuStripButton,
            this.FilterContextMenuStripButton,
            this.SortContextMenuStripButton,
            this.ClearContextMenuStripButton});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(159, 158);
            // 
            // OpenContextMenuStripButton
            // 
            this.OpenContextMenuStripButton.Name = "OpenContextMenuStripButton";
            this.OpenContextMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.OpenContextMenuStripButton.Text = "Open";
            this.OpenContextMenuStripButton.Click += new System.EventHandler(this.OpenContextMenuStripButton_Click);
            // 
            // SaveContextMenuStripButton
            // 
            this.SaveContextMenuStripButton.Name = "SaveContextMenuStripButton";
            this.SaveContextMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.SaveContextMenuStripButton.Text = "Save";
            this.SaveContextMenuStripButton.Click += new System.EventHandler(this.SaveContextMenuStripButton_Click);
            // 
            // AddContextMenuStripButton
            // 
            this.AddContextMenuStripButton.Name = "AddContextMenuStripButton";
            this.AddContextMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.AddContextMenuStripButton.Text = "Add";
            this.AddContextMenuStripButton.Click += new System.EventHandler(this.AddContextMenuStripButton_Click);
            // 
            // RemoveContextMenuStripButton
            // 
            this.RemoveContextMenuStripButton.Name = "RemoveContextMenuStripButton";
            this.RemoveContextMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RemoveContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.RemoveContextMenuStripButton.Text = "Remove";
            this.RemoveContextMenuStripButton.Click += new System.EventHandler(this.RemoveContextMenuStripButton_Click);
            // 
            // FilterContextMenuStripButton
            // 
            this.FilterContextMenuStripButton.Name = "FilterContextMenuStripButton";
            this.FilterContextMenuStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FilterContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.FilterContextMenuStripButton.Text = "Filter";
            this.FilterContextMenuStripButton.Click += new System.EventHandler(this.FilterContextMenuStripButton_Click);
            // 
            // SortContextMenuStripButton
            // 
            this.SortContextMenuStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameSortContextMenuButton,
            this.DurationSortContextMenuButton,
            this.SizeSortContextMenuButton});
            this.SortContextMenuStripButton.Name = "SortContextMenuStripButton";
            this.SortContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.SortContextMenuStripButton.Text = "Sort";
            // 
            // NameSortContextMenuButton
            // 
            this.NameSortContextMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameSortContextMenuAscending,
            this.NameSortContextMenuDescending});
            this.NameSortContextMenuButton.Name = "NameSortContextMenuButton";
            this.NameSortContextMenuButton.Size = new System.Drawing.Size(120, 22);
            this.NameSortContextMenuButton.Text = "Name";
            // 
            // NameSortContextMenuAscending
            // 
            this.NameSortContextMenuAscending.Name = "NameSortContextMenuAscending";
            this.NameSortContextMenuAscending.Size = new System.Drawing.Size(136, 22);
            this.NameSortContextMenuAscending.Text = "Ascending";
            this.NameSortContextMenuAscending.Click += new System.EventHandler(this.NameSortContextMenuAscending_Click);
            // 
            // NameSortContextMenuDescending
            // 
            this.NameSortContextMenuDescending.Name = "NameSortContextMenuDescending";
            this.NameSortContextMenuDescending.Size = new System.Drawing.Size(136, 22);
            this.NameSortContextMenuDescending.Text = "Descending";
            this.NameSortContextMenuDescending.Click += new System.EventHandler(this.NameSortContextMenuDescending_Click);
            // 
            // DurationSortContextMenuButton
            // 
            this.DurationSortContextMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DurationSortContextMenuAscending,
            this.DurationSortContextMenuDescending});
            this.DurationSortContextMenuButton.Name = "DurationSortContextMenuButton";
            this.DurationSortContextMenuButton.Size = new System.Drawing.Size(120, 22);
            this.DurationSortContextMenuButton.Text = "Duration";
            // 
            // DurationSortContextMenuAscending
            // 
            this.DurationSortContextMenuAscending.Name = "DurationSortContextMenuAscending";
            this.DurationSortContextMenuAscending.Size = new System.Drawing.Size(136, 22);
            this.DurationSortContextMenuAscending.Text = "Ascending";
            this.DurationSortContextMenuAscending.Click += new System.EventHandler(this.DurationSortContextMenuAscending_Click);
            // 
            // DurationSortContextMenuDescending
            // 
            this.DurationSortContextMenuDescending.Name = "DurationSortContextMenuDescending";
            this.DurationSortContextMenuDescending.Size = new System.Drawing.Size(136, 22);
            this.DurationSortContextMenuDescending.Text = "Descending";
            this.DurationSortContextMenuDescending.Click += new System.EventHandler(this.DurationSortContextMenuDescending_Click);
            // 
            // SizeSortContextMenuButton
            // 
            this.SizeSortContextMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeSortContextMenuAscending,
            this.SizeSortContextMenuDescending});
            this.SizeSortContextMenuButton.Name = "SizeSortContextMenuButton";
            this.SizeSortContextMenuButton.Size = new System.Drawing.Size(120, 22);
            this.SizeSortContextMenuButton.Text = "Size";
            // 
            // SizeSortContextMenuAscending
            // 
            this.SizeSortContextMenuAscending.Name = "SizeSortContextMenuAscending";
            this.SizeSortContextMenuAscending.Size = new System.Drawing.Size(136, 22);
            this.SizeSortContextMenuAscending.Text = "Ascending";
            this.SizeSortContextMenuAscending.Click += new System.EventHandler(this.SizeSortContextMenuAscending_Click);
            // 
            // SizeSortContextMenuDescending
            // 
            this.SizeSortContextMenuDescending.Name = "SizeSortContextMenuDescending";
            this.SizeSortContextMenuDescending.Size = new System.Drawing.Size(136, 22);
            this.SizeSortContextMenuDescending.Text = "Descending";
            this.SizeSortContextMenuDescending.Click += new System.EventHandler(this.SizeSortContextMenuDescending_Click);
            // 
            // ClearContextMenuStripButton
            // 
            this.ClearContextMenuStripButton.Name = "ClearContextMenuStripButton";
            this.ClearContextMenuStripButton.Size = new System.Drawing.Size(158, 22);
            this.ClearContextMenuStripButton.Text = "Clear";
            this.ClearContextMenuStripButton.Click += new System.EventHandler(this.ClearContextMenuStripButton_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.LightSlateGray;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOpen,
            this.ToolStripSave,
            this.ToolStripAdd,
            this.ToolStripRemove,
            this.ToolStripFilter,
            this.ToolStripClear});
            this.ToolStrip.Location = new System.Drawing.Point(12, 29);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(147, 27);
            this.ToolStrip.TabIndex = 4;
            this.ToolStrip.Text = "Tool Strip";
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripOpen.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripOpen.Image = global::CourseWork.Properties.Resources.Open;
            this.ToolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(24, 24);
            this.ToolStripOpen.Text = "Open file (Ctrl + O)";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripSave.Image = global::CourseWork.Properties.Resources.Save;
            this.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(24, 24);
            this.ToolStripSave.Text = "Save to file (Ctrl + S)";
            this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // ToolStripAdd
            // 
            this.ToolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripAdd.Image = global::CourseWork.Properties.Resources.Add;
            this.ToolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAdd.Name = "ToolStripAdd";
            this.ToolStripAdd.Size = new System.Drawing.Size(24, 24);
            this.ToolStripAdd.Text = "Add new object (Ctrl + A)";
            this.ToolStripAdd.Click += new System.EventHandler(this.ToolStripAdd_Click);
            // 
            // ToolStripRemove
            // 
            this.ToolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripRemove.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripRemove.Image = global::CourseWork.Properties.Resources.Remove1;
            this.ToolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripRemove.Name = "ToolStripRemove";
            this.ToolStripRemove.Size = new System.Drawing.Size(24, 24);
            this.ToolStripRemove.Text = "Remove object (Ctrl + R)";
            this.ToolStripRemove.Click += new System.EventHandler(this.ToolStripRemove_Click);
            // 
            // ToolStripFilter
            // 
            this.ToolStripFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripFilter.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripFilter.Image = global::CourseWork.Properties.Resources.FilterForm;
            this.ToolStripFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFilter.Name = "ToolStripFilter";
            this.ToolStripFilter.Size = new System.Drawing.Size(24, 24);
            this.ToolStripFilter.Text = "Filter current objects (Ctrl + F)";
            this.ToolStripFilter.Click += new System.EventHandler(this.ToolStripFilter_Click);
            // 
            // ToolStripClear
            // 
            this.ToolStripClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripClear.Image = global::CourseWork.Properties.Resources.Cancel1;
            this.ToolStripClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripClear.Name = "ToolStripClear";
            this.ToolStripClear.Size = new System.Drawing.Size(24, 24);
            this.ToolStripClear.Text = "Clear list view";
            this.ToolStripClear.Click += new System.EventHandler(this.ToolStripClear_Click);
            // 
            // CurrentButton
            // 
            this.CurrentButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentButton.Location = new System.Drawing.Point(3, 146);
            this.CurrentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(80, 28);
            this.CurrentButton.TabIndex = 5;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.VideoFilesListView);
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
            this.ContextMenuStrip.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
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
        private System.Windows.Forms.ListView VideoFilesListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader FormatHeader;
        private System.Windows.Forms.ColumnHeader DurationHeader;
        private System.Windows.Forms.ColumnHeader VCodecHeader;
        private System.Windows.Forms.ColumnHeader ACodecHeader;
        private System.Windows.Forms.ColumnHeader SubtitlesAvaliabilityHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader PlayerHeader;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem RemoveContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem FilterContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem ClearContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem SortContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem NameSortContextMenuButton;
        private System.Windows.Forms.ToolStripMenuItem DurationSortContextMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SizeSortContextMenuButton;
        private System.Windows.Forms.ToolStripMenuItem NameSortContextMenuAscending;
        private System.Windows.Forms.ToolStripMenuItem NameSortContextMenuDescending;
        private System.Windows.Forms.ToolStripMenuItem DurationSortContextMenuAscending;
        private System.Windows.Forms.ToolStripMenuItem DurationSortContextMenuDescending;
        private System.Windows.Forms.ToolStripMenuItem SizeSortContextMenuAscending;
        private System.Windows.Forms.ToolStripMenuItem SizeSortContextMenuDescending;
        private System.Windows.Forms.ToolStripMenuItem OpenContextMenuStripButton;
        private System.Windows.Forms.ToolStripMenuItem SaveContextMenuStripButton;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripOpen;
        private System.Windows.Forms.ToolStripButton ToolStripSave;
        private System.Windows.Forms.ToolStripButton ToolStripAdd;
        private System.Windows.Forms.ToolStripButton ToolStripRemove;
        private System.Windows.Forms.ToolStripButton ToolStripFilter;
        private System.Windows.Forms.ToolStripButton ToolStripClear;
        private System.Windows.Forms.Button CurrentButton;
    }
}

