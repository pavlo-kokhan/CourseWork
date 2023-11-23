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
            this.SecondsTextBoxFirst = new System.Windows.Forms.TextBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesTextBoxFirst = new System.Windows.Forms.TextBox();
            this.HoursTextBoxFirst = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.VCodecListBox = new System.Windows.Forms.CheckedListBox();
            this.ACodecListBox = new System.Windows.Forms.CheckedListBox();
            this.SubtitlesAvaliabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SecondsTextBoxSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinutesTextBoxSecond = new System.Windows.Forms.TextBox();
            this.HoursTextBoxSecond = new System.Windows.Forms.TextBox();
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
            this.SubtitlesButton.Location = new System.Drawing.Point(6, 277);
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
            this.FormatListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FormatListBox_ItemCheck);
            // 
            // SecondsTextBoxFirst
            // 
            this.SecondsTextBoxFirst.Location = new System.Drawing.Point(357, 201);
            this.SecondsTextBoxFirst.MaxLength = 2;
            this.SecondsTextBoxFirst.Name = "SecondsTextBoxFirst";
            this.SecondsTextBoxFirst.Size = new System.Drawing.Size(42, 27);
            this.SecondsTextBoxFirst.TabIndex = 27;
            this.SecondsTextBoxFirst.Text = "0";
            this.SecondsTextBoxFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondsTextBox_KeyPress);
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(295, 204);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(56, 19);
            this.SecondsLabel.TabIndex = 26;
            this.SecondsLabel.Text = "Seconds:";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(181, 204);
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
            // MinutesTextBoxFirst
            // 
            this.MinutesTextBoxFirst.Location = new System.Drawing.Point(241, 201);
            this.MinutesTextBoxFirst.MaxLength = 2;
            this.MinutesTextBoxFirst.Name = "MinutesTextBoxFirst";
            this.MinutesTextBoxFirst.Size = new System.Drawing.Size(43, 27);
            this.MinutesTextBoxFirst.TabIndex = 22;
            this.MinutesTextBoxFirst.Text = "0";
            this.MinutesTextBoxFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox_KeyPress);
            // 
            // HoursTextBoxFirst
            // 
            this.HoursTextBoxFirst.Location = new System.Drawing.Point(125, 201);
            this.HoursTextBoxFirst.MaxLength = 10;
            this.HoursTextBoxFirst.Name = "HoursTextBoxFirst";
            this.HoursTextBoxFirst.Size = new System.Drawing.Size(45, 27);
            this.HoursTextBoxFirst.TabIndex = 21;
            this.HoursTextBoxFirst.Text = "0";
            this.HoursTextBoxFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox_KeyPress);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(12, 204);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(39, 19);
            this.FromLabel.TabIndex = 20;
            this.FromLabel.Text = "From:";
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
            this.VCodecListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.VCodecListBox_ItemCheck);
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
            this.ACodecListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ACodecListBox_ItemCheck);
            // 
            // SubtitlesAvaliabilityCheckBox
            // 
            this.SubtitlesAvaliabilityCheckBox.AutoSize = true;
            this.SubtitlesAvaliabilityCheckBox.Location = new System.Drawing.Point(198, 282);
            this.SubtitlesAvaliabilityCheckBox.Name = "SubtitlesAvaliabilityCheckBox";
            this.SubtitlesAvaliabilityCheckBox.Size = new System.Drawing.Size(138, 23);
            this.SubtitlesAvaliabilityCheckBox.TabIndex = 30;
            this.SubtitlesAvaliabilityCheckBox.Text = "Subtitles Avaliability";
            this.SubtitlesAvaliabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(12, 239);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 19);
            this.ToLabel.TabIndex = 31;
            this.ToLabel.Text = "To:";
            // 
            // SecondsTextBoxSecond
            // 
            this.SecondsTextBoxSecond.Location = new System.Drawing.Point(357, 236);
            this.SecondsTextBoxSecond.MaxLength = 2;
            this.SecondsTextBoxSecond.Name = "SecondsTextBoxSecond";
            this.SecondsTextBoxSecond.Size = new System.Drawing.Size(42, 27);
            this.SecondsTextBoxSecond.TabIndex = 38;
            this.SecondsTextBoxSecond.Text = "0";
            this.SecondsTextBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondsTextBoxSecond_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seconds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 34;
            // 
            // MinutesTextBoxSecond
            // 
            this.MinutesTextBoxSecond.Location = new System.Drawing.Point(241, 236);
            this.MinutesTextBoxSecond.MaxLength = 2;
            this.MinutesTextBoxSecond.Name = "MinutesTextBoxSecond";
            this.MinutesTextBoxSecond.Size = new System.Drawing.Size(43, 27);
            this.MinutesTextBoxSecond.TabIndex = 33;
            this.MinutesTextBoxSecond.Text = "0";
            this.MinutesTextBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBoxSecond_KeyPress);
            // 
            // HoursTextBoxSecond
            // 
            this.HoursTextBoxSecond.Location = new System.Drawing.Point(125, 236);
            this.HoursTextBoxSecond.MaxLength = 10;
            this.HoursTextBoxSecond.Name = "HoursTextBoxSecond";
            this.HoursTextBoxSecond.Size = new System.Drawing.Size(45, 27);
            this.HoursTextBoxSecond.TabIndex = 32;
            this.HoursTextBoxSecond.Text = "0";
            this.HoursTextBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBoxSecond_KeyPress);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(474, 333);
            this.Controls.Add(this.SecondsTextBoxSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinutesTextBoxSecond);
            this.Controls.Add(this.HoursTextBoxSecond);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.SubtitlesAvaliabilityCheckBox);
            this.Controls.Add(this.ACodecListBox);
            this.Controls.Add(this.VCodecListBox);
            this.Controls.Add(this.SecondsTextBoxFirst);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.MinutesTextBoxFirst);
            this.Controls.Add(this.HoursTextBoxFirst);
            this.Controls.Add(this.FromLabel);
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
            this.MaximumSize = new System.Drawing.Size(490, 372);
            this.MinimumSize = new System.Drawing.Size(490, 372);
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
        private System.Windows.Forms.TextBox SecondsTextBoxFirst;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox MinutesTextBoxFirst;
        private System.Windows.Forms.TextBox HoursTextBoxFirst;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.CheckedListBox VCodecListBox;
        private System.Windows.Forms.CheckedListBox ACodecListBox;
        private System.Windows.Forms.CheckBox SubtitlesAvaliabilityCheckBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox SecondsTextBoxSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinutesTextBoxSecond;
        private System.Windows.Forms.TextBox HoursTextBoxSecond;
    }
}