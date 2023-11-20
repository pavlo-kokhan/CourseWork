using Enums;
using System;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }
        
        public object Filter { get; private set; }

        private void SetFilterAndClose(object result, DialogResult dialogResult)
        {
            Filter = result;
            DialogResult = dialogResult;
            Close();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LocationTextBox.Text))
            {
                MessageBox.Show("Invalid or empty location property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetFilterAndClose(LocationTextBox.Text, DialogResult.OK);
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<VideoFormat>(FormatListBox.Text, out var format))
            {
                SetFilterAndClose(format, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty format property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VideoCodecButton_Click(object sender, EventArgs e)
        {

            if (!Enum.TryParse<VideoCodec>(VCodecListBox.Text, out var vCodec))
            {
                MessageBox.Show("Invalid or empty video codec property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetFilterAndClose(vCodec, DialogResult.OK);
            }
        }

        private void AudioCodecButton_Click(object sender, EventArgs e)
        {

            if (!Enum.TryParse<AudioCodec>(ACodecListBox.Text, out var acodec))
            {
                MessageBox.Show("Invalid or empty audio codec property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetFilterAndClose(acodec, DialogResult.OK);
            }
        }

        private void DurationButton_Click(object sender, EventArgs e)
        {
            var hours = int.Parse(HoursTextBox.Text);
            var minutes = int.Parse(MinutesTextBox.Text);
            var seconds = int.Parse(SecondsTextBox.Text);

            SetFilterAndClose(new TimeSpan(hours, minutes, seconds), DialogResult.OK);
        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            SetFilterAndClose(SubtitlesAvaliabilityCheckBox.Checked, DialogResult.OK);
        }
    }
}
