using Enums;
using System;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public enum VideoFilter { Location, VideoFormat, VideoCodec, AudioCodec, Duration, SubtitlesAvaliability, }

    public partial class FilterForm : Form
    {
        // Властивість за якою буде фільтруватися список
        private object resultProperty;

        // Перелічуваний тип, який вказує на те, по якій саме властивості відбувається фільтрування
        private VideoFilter resultFilter;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void SetResultAndClose(VideoFilter filter, object property, DialogResult dialogResult)
        {
            resultFilter = filter;

            resultProperty = property;

            DialogResult = dialogResult;

            Close();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void HandleItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;

            if (checkedListBox != null)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox.SetItemChecked(i, false);
                    }
                }
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

        private void FormatListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            HandleItemCheck(sender, e);
        }

        private void VCodecListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            HandleItemCheck(sender, e);
        }

        private void ACodecListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            HandleItemCheck(sender, e);
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            if (LocationTextBox.Text != string.Empty)
            {
                SetResultAndClose(VideoFilter.Location, LocationTextBox.Text, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty location property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<VideoFormat>(FormatListBox.Text, out var videoFormat))
            {
                SetResultAndClose(VideoFilter.VideoFormat, videoFormat, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty format property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VideoCodecButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<VideoCodec>(VCodecListBox.Text, out var vcodec))
            {
                SetResultAndClose(VideoFilter.VideoCodec, vcodec, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty video codec property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AudioCodecButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<AudioCodec>(ACodecListBox.Text, out var acodec))
            {
                SetResultAndClose(VideoFilter.AudioCodec, acodec, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty audio codec property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DurationButton_Click(object sender, EventArgs e)
        {
            var hours = int.Parse(HoursTextBox.Text);
            var minutes = int.Parse(MinutesTextBox.Text);
            var seconds = int.Parse(SecondsTextBox.Text);

            SetResultAndClose(VideoFilter.Duration, new TimeSpan(hours, minutes, seconds), DialogResult.OK);
        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            SetResultAndClose(VideoFilter.SubtitlesAvaliability, SubtitlesAvaliabilityCheckBox.Checked, DialogResult.OK);
        }

        public VideoFilter GetResultFilter()
        {
            return resultFilter;
        }

        public object GetResultProperty()
        {
            return resultProperty;
        }
    }
}
