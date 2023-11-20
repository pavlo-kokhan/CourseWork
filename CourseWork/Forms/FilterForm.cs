using Enums;
using System;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FilterForm : Form
    {
        private object resultProperty;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void SetResultAndClose(object result, DialogResult dialogResult)
        {
            resultProperty = result;

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
                SetResultAndClose(LocationTextBox.Text, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty location property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            VideoFormat format;

            if (Enum.TryParse<VideoFormat>(FormatListBox.Text, out format))
            {
                SetResultAndClose(format, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty format property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VideoCodecButton_Click(object sender, EventArgs e)
        {
            VideoCodec vcodec;

            if (Enum.TryParse<VideoCodec>(VCodecListBox.Text, out vcodec))
            {
                SetResultAndClose(vcodec, DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Invalid or empty video codec property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AudioCodecButton_Click(object sender, EventArgs e)
        {
            AudioCodec acodec;

            if (Enum.TryParse<AudioCodec>(ACodecListBox.Text, out acodec))
            {
                SetResultAndClose(acodec, DialogResult.OK);
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

            SetResultAndClose(new TimeSpan(hours, minutes, seconds), DialogResult.OK);
        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            SetResultAndClose(SubtitlesAvaliabilityCheckBox.Checked, DialogResult.OK);
        }

        public object GetResultProperty()
        {
            return resultProperty;
        }
    }
}
