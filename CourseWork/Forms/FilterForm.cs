using System;
using System.Windows.Forms;
using Enums;

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

        // Обробка введення символьного значення в текстові поля з часом
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

        private void HoursTextBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void MinutesTextBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        private void SecondsTextBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }

        // Метод, який забороняє вводити символьні значення в текстове поле
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        // Обробка вибору елементів в об'єктах ListBox
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

        // Метод, який не дозволяє вибір більше ніж 1 елемента в об'єкті ListBox
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

        // Оброблення натискання кнопок, які вказують на фінальний фільтр для списку
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
            var hoursFirst = int.Parse(HoursTextBoxFirst.Text);
            var minutesFirst = int.Parse(MinutesTextBoxFirst.Text);
            var secondsFirst = int.Parse(SecondsTextBoxFirst.Text);

            var hoursSecond = int.Parse(HoursTextBoxSecond.Text);
            var minutesSecond = int.Parse(MinutesTextBoxSecond.Text);
            var secondsSecond = int.Parse(SecondsTextBoxSecond.Text);

            TimeSpan[] range =
            {
                new TimeSpan(hoursFirst, minutesFirst, secondsFirst),
                new TimeSpan(hoursSecond, minutesSecond, secondsSecond)
            };

            if (range[0].TotalSeconds > range[1].TotalSeconds)
            {
                MessageBox.Show("Invalid range of duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SetResultAndClose(VideoFilter.Duration, range, DialogResult.OK);
        }

        private void SubtitlesButton_Click(object sender, EventArgs e)
        {
            SetResultAndClose(VideoFilter.SubtitlesAvaliability, SubtitlesAvaliabilityCheckBox.Checked, DialogResult.OK);
        }

        // Метод для встановлення влативості і фільтру і закриття цієї форми
        private void SetResultAndClose(VideoFilter filter, object property, DialogResult dialogResult)
        {
            resultFilter = filter;

            resultProperty = property;

            DialogResult = dialogResult;

            Close();
        }

        // Метод для повернення фінального фільтру
        public VideoFilter GetResultFilter()
        {
            return resultFilter;
        }

        // Метод для повернення фінальної властивості
        public object GetResultProperty()
        {
            return resultProperty;
        }
    }
}
