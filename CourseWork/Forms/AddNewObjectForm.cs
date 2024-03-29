﻿using System;
using System.Windows.Forms;
using VideoFileClass;
using SecondaryClasses;
using Enums;

namespace CourseWork.Forms
{
    public partial class AddNewObjectForm : Form
    {
        // Результуючий об'єкт VideoFile,
        // який буде повернений у головну форму після коректного відпрацювання цієї форми
        private VideoFile resultObject;

        public AddNewObjectForm()
        {
            InitializeComponent();
        }

        // Оброблення гарячих клавіш для додавання, або скасування додавання об'єкта
        private void AddNewObjectForm_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelButton.PerformClick();
            }
        }

        // Заборона на введення буквенних символів у поля
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

        // Метод, який обробляє введення символу в текстове поле, забороняє вводити буквенні символи
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        // Події для обробки вибору елементів на об'єктах ListBox
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

        // Обробляє вибір елементів на об'єктах ListBox, забороняє обирати більше ніж 1 елемент
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

        // Метод, який пробує отримати значення з текстових полів, якщо є помилки, повертає false
        private bool TryParseTextBoxes()
        {
            try
            {
                if (!ValidateNameAndLocation())
                {
                    return false;
                }

                string name = NameTextBox.Text;

                string location = LocationTextBox.Text;

                if (!TryParseEnum<VideoFormat>(FormatListBox.Text, "Invalid video format data. Try again.", out var videoFormat))
                {
                    return false;
                }

                if (!TryParseEnum<VideoCodec>(VCodecListBox.Text, "Invalid video codec data. Try again.", out var videoCodec))
                {
                    return false;
                }

                if (!TryParseEnum<AudioCodec>(ACodecListBox.Text, "Invalid audio codec data. Try again.", out var audioCodec))
                {
                    return false;
                }

                if (!TryParseEnum<VideoPlayer>(VideoPlayerListBox.Text, "Invalid video player data. Try again.", out var videoPlayer))
                {
                    return false;
                }

                if (!TryParseDuration(out TimeSpan duration))
                {
                    return false;
                }

                if (!TryParseSize(out FileSize size))
                {
                    return false;
                }

                var subtitles = SubtitlesAvaliabilityCheckBox.Checked;

                // Якщо все коректно, створюється новий об'єкт
                resultObject =  new VideoFile(name, location, videoFormat, duration, 
                    audioCodec, videoCodec, subtitles, size, videoPlayer);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Unhandled error. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        // Метод для валідації назви, розміщення
        private bool ValidateNameAndLocation()
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(LocationTextBox.Text))
            {
                MessageBox.Show("Don`t leave empty name or location. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        // Метод для значення в тип enum
        private bool TryParseEnum<T>(string value, string errorMessage, out T result) where T : struct
        {
            if (!Enum.TryParse<T>(value, out result))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        // Метод для конвертації значення в тип TimeSpan
        private bool TryParseDuration(out TimeSpan duration)
        {
            duration = TimeSpan.Zero;

            if (!int.TryParse(HoursTextBox.Text, out var hours)
                || !int.TryParse(MinutesTextBox.Text, out var minutes)
                || !int.TryParse(SecondsTextBox.Text, out var seconds))
            {
                MessageBox.Show("Invalid duration data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            duration = new TimeSpan(hours, minutes, seconds);

            // Заборона на створення об'єкта TimeSpan з нульовими значеннями
            if (duration.TotalSeconds == 0)
            {
                MessageBox.Show("Duration can't be empty. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        // Метод для конвертації значення в тип FileSize
        private bool TryParseSize(out FileSize size)
        {
            size = null;

            if (!ulong.TryParse(SizeTextBox.Text, out ulong rawSize))
            {
                MessageBox.Show("Invalid size data. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            // Заборона на нульовий розмір
            if (rawSize == 0)
            {
                MessageBox.Show("Size can`t be empty. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            // Оброблення значення отриманого з об'єкта ComboBox
            switch (SizeComboBox.Text)
            {
                case "B":

                    break;

                case "KB":

                    rawSize *= FileSize.BYTES_IN_KILOBYTE;

                    break;

                case "MB":

                    rawSize *= (ulong)Math.Pow(FileSize.BYTES_IN_KILOBYTE, 2);

                    break;

                case "GB":

                    rawSize *= (ulong)Math.Pow(FileSize.BYTES_IN_KILOBYTE, 3);

                    break;

                default:

                    MessageBox.Show("Choose size dimension. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
            }

            size = new FileSize(rawSize);

            return true;
        }

        // Скасування додавання нового об'єкта
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        // Підтвердження додавання нового об'єкта
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (TryParseTextBoxes())
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        // Метод для повернення результуючого об'єкта в головну форму
        public VideoFile GetResultObject()
        {
            return resultObject;
        }
    }
}
