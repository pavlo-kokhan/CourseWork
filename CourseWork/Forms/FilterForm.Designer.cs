namespace CourseWork.Forms
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.LocationButton = new System.Windows.Forms.Button();
            this.FormatButton = new System.Windows.Forms.Button();
            this.DurationButton = new System.Windows.Forms.Button();
            this.VideoCodecButton = new System.Windows.Forms.Button();
            this.AudioCodecButton = new System.Windows.Forms.Button();
            this.SubtitlesButton = new System.Windows.Forms.Button();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.FormatListBox = new System.Windows.Forms.CheckedListBox();
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.VCodecListBox = new System.Windows.Forms.CheckedListBox();
            this.ACodecListBox = new System.Windows.Forms.CheckedListBox();
            this.SubtitlesAvaliabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LocationButton
            // 
            this.LocationButton.BackColor = System.Drawing.Color.White;
            this.LocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationButton.Location = new System.Drawing.Point(12, 12);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(180, 30);
            this.LocationButton.TabIndex = 0;
            this.LocationButton.Text = "Location";
            this.LocationButton.UseVisualStyleBackColor = false;
            this.LocationButton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // FormatButton
            // 
            this.FormatButton.BackColor = System.Drawing.Color.White;
            this.FormatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormatButton.Location = new System.Drawing.Point(12, 48);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(180, 30);
            this.FormatButton.TabIndex = 1;
            this.FormatButton.Text = "Format";
            this.FormatButton.UseVisualStyleBackColor = false;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // DurationButton
            // 
            this.DurationButton.BackColor = System.Drawing.Color.White;
            this.DurationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DurationButton.Location = new System.Drawing.Point(12, 156);
            this.DurationButton.Name = "DurationButton";
            this.DurationButton.Size = new System.Drawing.Size(180, 30);
            this.DurationButton.TabIndex = 2;
            this.DurationButton.Text = "Duration";
            this.DurationButton.UseVisualStyleBackColor = false;
            this.DurationButton.Click += new System.EventHandler(this.DurationButton_Click);
            // 
            // VideoCodecButton
            // 
            this.VideoCodecButton.BackColor = System.Drawing.Color.White;
            this.VideoCodecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoCodecButton.Location = new System.Drawing.Point(12, 84);
            this.VideoCodecButton.Name = "VideoCodecButton";
            this.VideoCodecButton.Size = new System.Drawing.Size(180, 30);
            this.VideoCodecButton.TabIndex = 3;
            this.VideoCodecButton.Text = "Video Codec";
            this.VideoCodecButton.UseVisualStyleBackColor = false;
            this.VideoCodecButton.Click += new System.EventHandler(this.VideoCodecButton_Click);
            // 
            // AudioCodecButton
            // 
            this.AudioCodecButton.BackColor = System.Drawing.Color.White;
            this.AudioCodecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioCodecButton.Location = new System.Drawing.Point(12, 120);
            this.AudioCodecButton.Name = "AudioCodecButton";
            this.AudioCodecButton.Size = new System.Drawing.Size(180, 30);
            this.AudioCodecButton.TabIndex = 4;
            this.AudioCodecButton.Text = "Audio Codec";
            this.AudioCodecButton.UseVisualStyleBackColor = false;
            this.AudioCodecButton.Click += new System.EventHandler(this.AudioCodecButton_Click);
            // 
            // SubtitlesButton
            // 
            this.SubtitlesButton.BackColor = System.Drawing.Color.White;
            this.SubtitlesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtitlesButton.Location = new System.Drawing.Point(12, 243);
            this.SubtitlesButton.Name = "SubtitlesButton";
            this.SubtitlesButton.Size = new System.Drawing.Size(180, 30);
            this.SubtitlesButton.TabIndex = 5;
            this.SubtitlesButton.Text = "Subtitles";
            this.SubtitlesButton.UseVisualStyleBackColor = false;
            this.SubtitlesButton.Click += new System.EventHandler(this.SubtitlesButton_Click);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(198, 15);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(262, 27);
            this.LocationTextBox.TabIndex = 6;
            // 
            // FormatListBox
            // 
            this.FormatListBox.FormattingEnabled = true;
            this.FormatListBox.Items.AddRange(new object[] {
            "MP4",
            "AVI",
            "MKV",
            "MOV"});
            this.FormatListBox.Location = new System.Drawing.Point(198, 52);
            this.FormatListBox.Name = "FormatListBox";
            this.FormatListBox.Size = new System.Drawing.Size(92, 26);
            this.FormatListBox.TabIndex = 7;
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(393, 201);
            this.SecondsTextBox.MaxLength = 2;
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(67, 27);
            this.SecondsTextBox.TabIndex = 27;
            this.SecondsTextBox.Text = "0";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(331, 204);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(56, 19);
            this.SecondsLabel.TabIndex = 26;
            this.SecondsLabel.Text = "Seconds:";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(198, 204);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(54, 19);
            this.MinutesLabel.TabIndex = 25;
            this.MinutesLabel.Text = "Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hours:";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(151, 204);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(0, 19);
            this.HoursLabel.TabIndex = 23;
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(258, 201);
            this.MinutesTextBox.MaxLength = 2;
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(67, 27);
            this.MinutesTextBox.TabIndex = 22;
            this.MinutesTextBox.Text = "0";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(125, 201);
            this.HoursTextBox.MaxLength = 10;
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(67, 27);
            this.HoursTextBox.TabIndex = 21;
            this.HoursTextBox.Text = "0";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(14, 204);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(58, 19);
            this.DurationLabel.TabIndex = 20;
            this.DurationLabel.Text = "Duration:";
            // 
            // VCodecListBox
            // 
            this.VCodecListBox.FormattingEnabled = true;
            this.VCodecListBox.Items.AddRange(new object[] {
            "AVC",
            "HEVC",
            "AVI1",
            "MPEG"});
            this.VCodecListBox.Location = new System.Drawing.Point(198, 88);
            this.VCodecListBox.Name = "VCodecListBox";
            this.VCodecListBox.Size = new System.Drawing.Size(92, 26);
            this.VCodecListBox.TabIndex = 28;
            // 
            // ACodecListBox
            // 
            this.ACodecListBox.FormattingEnabled = true;
            this.ACodecListBox.Items.AddRange(new object[] {
            "MP3",
            "AAC",
            "FLAC",
            "Opus"});
            this.ACodecListBox.Location = new System.Drawing.Point(198, 124);
            this.ACodecListBox.Name = "ACodecListBox";
            this.ACodecListBox.Size = new System.Drawing.Size(92, 26);
            this.ACodecListBox.TabIndex = 29;
            // 
            // SubtitlesAvaliabilityCheckBox
            // 
            this.SubtitlesAvaliabilityCheckBox.AutoSize = true;
            this.SubtitlesAvaliabilityCheckBox.Location = new System.Drawing.Point(204, 248);
            this.SubtitlesAvaliabilityCheckBox.Name = "SubtitlesAvaliabilityCheckBox";
            this.SubtitlesAvaliabilityCheckBox.Size = new System.Drawing.Size(138, 23);
            this.SubtitlesAvaliabilityCheckBox.TabIndex = 30;
            this.SubtitlesAvaliabilityCheckBox.Text = "Subtitles Avaliability";
            this.SubtitlesAvaliabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(474, 291);
            this.Controls.Add(this.SubtitlesAvaliabilityCheckBox);
            this.Controls.Add(this.ACodecListBox);
            this.Controls.Add(this.VCodecListBox);
            this.Controls.Add(this.SecondsTextBox);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.FormatListBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.SubtitlesButton);
            this.Controls.Add(this.AudioCodecButton);
            this.Controls.Add(this.VideoCodecButton);
            this.Controls.Add(this.DurationButton);
            this.Controls.Add(this.FormatButton);
            this.Controls.Add(this.LocationButton);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(490, 330);
            this.MinimumSize = new System.Drawing.Size(490, 330);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chose Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocationButton;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.Button DurationButton;
        private System.Windows.Forms.Button VideoCodecButton;
        private System.Windows.Forms.Button AudioCodecButton;
        private System.Windows.Forms.Button SubtitlesButton;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.CheckedListBox FormatListBox;
        private System.Windows.Forms.TextBox SecondsTextBox;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.CheckedListBox VCodecListBox;
        private System.Windows.Forms.CheckedListBox ACodecListBox;
        private System.Windows.Forms.CheckBox SubtitlesAvaliabilityCheckBox;
    }
}