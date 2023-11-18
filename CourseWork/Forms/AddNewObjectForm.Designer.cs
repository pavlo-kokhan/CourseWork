﻿namespace CourseWork.Forms
{
    partial class AddNewObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewObjectForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FormatListBox = new System.Windows.Forms.CheckedListBox();
            this.VideoCodecLabel = new System.Windows.Forms.Label();
            this.VCodecListBox = new System.Windows.Forms.CheckedListBox();
            this.AudioCodecLabel = new System.Windows.Forms.Label();
            this.ACodecListBox = new System.Windows.Forms.CheckedListBox();
            this.VideoPlayerLabel = new System.Windows.Forms.Label();
            this.VideoPlayerListBox = new System.Windows.Forms.CheckedListBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.GBLabel = new System.Windows.Forms.Label();
            this.GBTextBox = new System.Windows.Forms.TextBox();
            this.MBLabel = new System.Windows.Forms.Label();
            this.MBTextBox = new System.Windows.Forms.TextBox();
            this.KBLabel = new System.Windows.Forms.Label();
            this.KBTextBox = new System.Windows.Forms.TextBox();
            this.SubtitlesAvaliabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(60, 6);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(229, 9);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(57, 19);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location:";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(292, 6);
            this.LocationTextBox.MaxLength = 200;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(166, 27);
            this.LocationTextBox.TabIndex = 3;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(12, 49);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(50, 19);
            this.FormatLabel.TabIndex = 4;
            this.FormatLabel.Text = "Format:";
            // 
            // FormatListBox
            // 
            this.FormatListBox.FormattingEnabled = true;
            this.FormatListBox.Items.AddRange(new object[] {
            "MP4",
            "AVI",
            "MKV",
            "MOV"});
            this.FormatListBox.Location = new System.Drawing.Point(12, 71);
            this.FormatListBox.Name = "FormatListBox";
            this.FormatListBox.Size = new System.Drawing.Size(92, 92);
            this.FormatListBox.TabIndex = 5;
            // 
            // VideoCodecLabel
            // 
            this.VideoCodecLabel.AutoSize = true;
            this.VideoCodecLabel.Location = new System.Drawing.Point(119, 49);
            this.VideoCodecLabel.Name = "VideoCodecLabel";
            this.VideoCodecLabel.Size = new System.Drawing.Size(73, 19);
            this.VideoCodecLabel.TabIndex = 6;
            this.VideoCodecLabel.Text = "Video Codec:";
            // 
            // VCodecListBox
            // 
            this.VCodecListBox.FormattingEnabled = true;
            this.VCodecListBox.Items.AddRange(new object[] {
            "AVC",
            "HEVC",
            "AVI1",
            "MPEG"});
            this.VCodecListBox.Location = new System.Drawing.Point(123, 71);
            this.VCodecListBox.Name = "VCodecListBox";
            this.VCodecListBox.Size = new System.Drawing.Size(92, 92);
            this.VCodecListBox.TabIndex = 7;
            // 
            // AudioCodecLabel
            // 
            this.AudioCodecLabel.AutoSize = true;
            this.AudioCodecLabel.Location = new System.Drawing.Point(241, 49);
            this.AudioCodecLabel.Name = "AudioCodecLabel";
            this.AudioCodecLabel.Size = new System.Drawing.Size(75, 19);
            this.AudioCodecLabel.TabIndex = 8;
            this.AudioCodecLabel.Text = "Audio Codec:";
            // 
            // ACodecListBox
            // 
            this.ACodecListBox.FormattingEnabled = true;
            this.ACodecListBox.Items.AddRange(new object[] {
            "MP3",
            "AAC",
            "FLAC",
            "Opus"});
            this.ACodecListBox.Location = new System.Drawing.Point(245, 71);
            this.ACodecListBox.Name = "ACodecListBox";
            this.ACodecListBox.Size = new System.Drawing.Size(92, 92);
            this.ACodecListBox.TabIndex = 9;
            // 
            // VideoPlayerLabel
            // 
            this.VideoPlayerLabel.AutoSize = true;
            this.VideoPlayerLabel.Location = new System.Drawing.Point(362, 49);
            this.VideoPlayerLabel.Name = "VideoPlayerLabel";
            this.VideoPlayerLabel.Size = new System.Drawing.Size(76, 19);
            this.VideoPlayerLabel.TabIndex = 10;
            this.VideoPlayerLabel.Text = "Video Player:";
            // 
            // VideoPlayerListBox
            // 
            this.VideoPlayerListBox.FormattingEnabled = true;
            this.VideoPlayerListBox.Items.AddRange(new object[] {
            "VLC",
            "MPC",
            "PotPlayer",
            "Kodi"});
            this.VideoPlayerListBox.Location = new System.Drawing.Point(366, 71);
            this.VideoPlayerListBox.Name = "VideoPlayerListBox";
            this.VideoPlayerListBox.Size = new System.Drawing.Size(92, 92);
            this.VideoPlayerListBox.TabIndex = 11;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(12, 178);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(58, 19);
            this.DurationLabel.TabIndex = 12;
            this.DurationLabel.Text = "Duration:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(123, 175);
            this.HoursTextBox.MaxLength = 10;
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(67, 27);
            this.HoursTextBox.TabIndex = 13;
            this.HoursTextBox.Text = "0";
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox_KeyPress);
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(256, 175);
            this.MinutesTextBox.MaxLength = 2;
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(67, 27);
            this.MinutesTextBox.TabIndex = 14;
            this.MinutesTextBox.Text = "0";
            this.MinutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox_KeyPress);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(149, 178);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(0, 19);
            this.HoursLabel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hours:";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(196, 178);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(54, 19);
            this.MinutesLabel.TabIndex = 17;
            this.MinutesLabel.Text = "Minutes:";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(329, 178);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(56, 19);
            this.SecondsLabel.TabIndex = 18;
            this.SecondsLabel.Text = "Seconds:";
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(391, 175);
            this.SecondsTextBox.MaxLength = 2;
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(67, 27);
            this.SecondsTextBox.TabIndex = 19;
            this.SecondsTextBox.Text = "0";
            this.SecondsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondsTextBox_KeyPress);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(12, 219);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(34, 19);
            this.SizeLabel.TabIndex = 20;
            this.SizeLabel.Text = "Size:";
            // 
            // GBLabel
            // 
            this.GBLabel.AutoSize = true;
            this.GBLabel.Location = new System.Drawing.Point(91, 219);
            this.GBLabel.Name = "GBLabel";
            this.GBLabel.Size = new System.Drawing.Size(26, 19);
            this.GBLabel.TabIndex = 21;
            this.GBLabel.Text = "GB:";
            // 
            // GBTextBox
            // 
            this.GBTextBox.Location = new System.Drawing.Point(123, 216);
            this.GBTextBox.MaxLength = 4;
            this.GBTextBox.Name = "GBTextBox";
            this.GBTextBox.Size = new System.Drawing.Size(67, 27);
            this.GBTextBox.TabIndex = 22;
            this.GBTextBox.Text = "0";
            this.GBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GBTextBox_KeyPress);
            // 
            // MBLabel
            // 
            this.MBLabel.AutoSize = true;
            this.MBLabel.Location = new System.Drawing.Point(220, 222);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(28, 19);
            this.MBLabel.TabIndex = 23;
            this.MBLabel.Text = "MB:";
            // 
            // MBTextBox
            // 
            this.MBTextBox.Location = new System.Drawing.Point(256, 219);
            this.MBTextBox.MaxLength = 4;
            this.MBTextBox.Name = "MBTextBox";
            this.MBTextBox.Size = new System.Drawing.Size(67, 27);
            this.MBTextBox.TabIndex = 24;
            this.MBTextBox.Text = "0";
            this.MBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBTextBox_KeyPress);
            // 
            // KBLabel
            // 
            this.KBLabel.AutoSize = true;
            this.KBLabel.Location = new System.Drawing.Point(359, 219);
            this.KBLabel.Name = "KBLabel";
            this.KBLabel.Size = new System.Drawing.Size(26, 19);
            this.KBLabel.TabIndex = 25;
            this.KBLabel.Text = "KB:";
            // 
            // KBTextBox
            // 
            this.KBTextBox.Location = new System.Drawing.Point(391, 216);
            this.KBTextBox.MaxLength = 4;
            this.KBTextBox.Name = "KBTextBox";
            this.KBTextBox.Size = new System.Drawing.Size(67, 27);
            this.KBTextBox.TabIndex = 26;
            this.KBTextBox.Text = "0";
            this.KBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KBTextBox_KeyPress);
            // 
            // SubtitlesAvaliabilityCheckBox
            // 
            this.SubtitlesAvaliabilityCheckBox.AutoSize = true;
            this.SubtitlesAvaliabilityCheckBox.Location = new System.Drawing.Point(16, 265);
            this.SubtitlesAvaliabilityCheckBox.Name = "SubtitlesAvaliabilityCheckBox";
            this.SubtitlesAvaliabilityCheckBox.Size = new System.Drawing.Size(138, 23);
            this.SubtitlesAvaliabilityCheckBox.TabIndex = 28;
            this.SubtitlesAvaliabilityCheckBox.Text = "Subtitles Avaliability";
            this.SubtitlesAvaliabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackgroundImage = global::CourseWork.Properties.Resources.Apply2;
            this.ApplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplyButton.Location = new System.Drawing.Point(371, 313);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(87, 36);
            this.ApplyButton.TabIndex = 30;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = global::CourseWork.Properties.Resources.Cancel;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton.Location = new System.Drawing.Point(278, 313);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 36);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubtitlesAvaliabilityCheckBox);
            this.Controls.Add(this.KBTextBox);
            this.Controls.Add(this.KBLabel);
            this.Controls.Add(this.MBTextBox);
            this.Controls.Add(this.MBLabel);
            this.Controls.Add(this.GBTextBox);
            this.Controls.Add(this.GBLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SecondsTextBox);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.VideoPlayerListBox);
            this.Controls.Add(this.VideoPlayerLabel);
            this.Controls.Add(this.ACodecListBox);
            this.Controls.Add(this.AudioCodecLabel);
            this.Controls.Add(this.VCodecListBox);
            this.Controls.Add(this.VideoCodecLabel);
            this.Controls.Add(this.FormatListBox);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(490, 400);
            this.MinimumSize = new System.Drawing.Size(490, 400);
            this.Name = "AddNewObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.CheckedListBox FormatListBox;
        private System.Windows.Forms.Label VideoCodecLabel;
        private System.Windows.Forms.CheckedListBox VCodecListBox;
        private System.Windows.Forms.Label AudioCodecLabel;
        private System.Windows.Forms.CheckedListBox ACodecListBox;
        private System.Windows.Forms.Label VideoPlayerLabel;
        private System.Windows.Forms.CheckedListBox VideoPlayerListBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.TextBox SecondsTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label GBLabel;
        private System.Windows.Forms.TextBox GBTextBox;
        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.TextBox MBTextBox;
        private System.Windows.Forms.Label KBLabel;
        private System.Windows.Forms.TextBox KBTextBox;
        private System.Windows.Forms.CheckBox SubtitlesAvaliabilityCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}