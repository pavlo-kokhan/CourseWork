using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VideoFileClass;
using SecondaryClasses;

namespace CourseWork.Forms
{
    public partial class AddNewObjectForm : Form
    {
        private VideoFile resultObject;

        public AddNewObjectForm()
        {
            InitializeComponent();
        }

        private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void MinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void SecondsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void GBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void MBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void KBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void CreateResultVideoFile()
        {
            try
            {
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

                resultObject = new VideoFile(Name, Location, Format, Duration, ACodec, VCodec, SubtitlesAvaliability, Size, Player);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            CreateResultVideoFile();

            Close();
        }

        public VideoFile GetResultVideoFile()
        {
            return resultObject;
        }
    }
}
