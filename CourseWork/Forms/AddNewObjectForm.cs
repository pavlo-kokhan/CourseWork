using Enums;
using System;
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

        private void VideoPlayerListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            HandleItemCheck(sender, e);
        }

        private bool TryParseTextBoxes()
        {
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(LocationTextBox.Text))
                {
                    MessageBox.Show("Dont leave empty name or location. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                string name = NameTextBox.Text;

                string location = LocationTextBox.Text;

                if (!Enum.TryParse<VideoFormat>(FormatListBox.Text, out var videoFormat))
                {
                    MessageBox.Show("Invalid video format data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (!Enum.TryParse<VideoCodec>(VCodecListBox.Text, out var videoCodec))
                {
                    MessageBox.Show("Invalid video codec data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (!Enum.TryParse<AudioCodec>(ACodecListBox.Text, out var audioCodec))
                {
                    MessageBox.Show("Invalid audio codec data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (!Enum.TryParse<VideoPlayer>(VideoPlayerListBox.Text, out var videoPlayer))
                {
                    MessageBox.Show("Invalid video player data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (!int.TryParse(HoursTextBox.Text, out var hours) 
                    || !int.TryParse(MinutesTextBox.Text, out var minutes) 
                    || !int.TryParse(SecondsTextBox.Text, out var seconds))
                {
                    MessageBox.Show("Invalid duration data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                TimeSpan duration = new TimeSpan(hours, minutes, seconds);

                if (!uint.TryParse(GBTextBox.Text, out var gb)
                    || !uint.TryParse(MBTextBox.Text, out var mb)
                    || !uint.TryParse(KBTextBox.Text, out var kb)) 
                {
                    MessageBox.Show("Invalid size data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                FileSize size = new FileSize(kb, mb, gb);

                var subtitles = SubtitlesAvaliabilityCheckBox.Checked;

                resultObject =  new VideoFile(name, location, videoFormat, duration, audioCodec, 
                    videoCodec, subtitles, size, videoPlayer);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
