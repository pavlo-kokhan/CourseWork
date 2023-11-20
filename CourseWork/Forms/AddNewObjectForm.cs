﻿using Enums;
using System;
using System.Windows.Forms;
using SecondaryClasses;

namespace CourseWork.Forms
{
    using Video;

    public partial class AddNewObjectForm : Form
    {
        private VideoFile resultObject;

        public AddNewObjectForm()
        {
            InitializeComponent();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void MinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void SecondsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void GBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void MBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void KBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private bool TryParseTextBoxes()
        {
            try
            {
                if (NameTextBox.Text == string.Empty || LocationTextBox.Text == string.Empty)
                {
                    throw new Exception();
                }

                string Name = NameTextBox.Text;

                string Location = LocationTextBox.Text;

                var Format = (VideoFormat)Enum.Parse(typeof(VideoFormat), FormatListBox.Text);

                var VCodec = (VideoCodec)Enum.Parse(typeof(VideoCodec), VCodecListBox.Text);

                var ACodec = (AudioCodec)Enum.Parse(typeof(AudioCodec), ACodecListBox.Text);

                var Player = (VideoPlayer)Enum.Parse(typeof(VideoPlayer), VideoPlayerListBox.Text);

                var hours = int.Parse(HoursTextBox.Text);
                var minutes = int.Parse(MinutesTextBox.Text);
                var seconds = int.Parse(SecondsTextBox.Text);

                TimeSpan Duration = new TimeSpan(hours, minutes, seconds);

                var GB = uint.Parse(GBTextBox.Text);
                var MB = uint.Parse(MBTextBox.Text);
                var KB = uint.Parse(KBTextBox.Text);

                FileSize Size = new FileSize(KB, MB, GB);

                var SubtitlesAvaliability = SubtitlesAvaliabilityCheckBox.Checked;

                resultObject =  new VideoFile(Name, Location, Format, Duration, ACodec, VCodec, SubtitlesAvaliability, Size, Player);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dont leave empty properties. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (TryParseTextBoxes())
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        public VideoFile GetResultObject()
        {
            return resultObject;
        }
    }
}
