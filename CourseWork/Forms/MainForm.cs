using CourseWork.Forms;
using Enums;
using SecondaryClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VideoFileClass;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        // Зберігає основні об'єкти VideoFile для зручнішого використання програми
        List<VideoFile> sourceVideoFiles = new List<VideoFile>();

        // Зберігає об'єкти VideoFile в такій послідовності, що і відображено на формі
        List<VideoFile> currentVideoFiles = new List<VideoFile>();

        // Зберігає індекс стовпця, який був вибраний користувачем, як критерій для сортування
        private int lastSortedColumn = -1;

        // Зберігає значення, яке відповідає за порядок сортування
        private bool ascendingOrder = true;

        public MainForm()
        {
            InitializeComponent();
        }

        // Конвертує значення з об'єкта VideoFiles у об'єкт ListViewItem
        // Використовується для візуального представлення списку
        private ListViewItem ConvertToListViewItem(VideoFile obj)
        {
            ListViewItem item = new ListViewItem(obj.Name);

            item.SubItems.Add(obj.Location);
            item.SubItems.Add(obj.Format.ToString());
            item.SubItems.Add(obj.Duration.ToString());
            item.SubItems.Add(obj.VCodec.ToString());
            item.SubItems.Add(obj.ACodec.ToString());
            item.SubItems.Add(obj.SubtitlesAvaliability.ToString());
            item.SubItems.Add(obj.Size.ToString());
            item.SubItems.Add(obj.Player.ToString());

            return item;
        }

        // Конвертує об'єкт ListViewItem зі списку в об'єкт VideoFile
        // Використовується для видалення вибраного елемента зі списку
        private VideoFile ConvertToVideoFile(ListViewItem item)
        {
            return currentVideoFiles[VideoFilesListView.Items.IndexOf(item)];
        }

        // Метод, який візуально виводить список об'єктів VideoFile у ListView
        // Викоритовується після багатьох операцій над списком
        private void UpdateListView(List<VideoFile> list)
        {
            VideoFilesListView.Items.Clear(); 

            foreach (var obj in list)
            {
                ListViewItem item = ConvertToListViewItem(obj);

                VideoFilesListView.Items.Add(item);
            }
        }

        // Метод для сортування списку і виводу у ListView
        private void SortVideoFilesAndUpdate(Comparison<VideoFile> comparison, bool ascending)
        {
            currentVideoFiles.Sort(comparison);

            if (!ascending)
            {
                currentVideoFiles.Reverse();
            }

            UpdateListView(currentVideoFiles);
        }

        // Оброблення події кнопки додавання нового об'єкта VideoFile
        private void AddButton_Click(object sender, EventArgs e)
        {
            VideoFile newObject;

            AddNewObjectForm childForm = new AddNewObjectForm();

            var result = childForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                newObject = childForm.GetResultObject();

                ListViewItem item = ConvertToListViewItem(newObject);
                VideoFilesListView.Items.Add(item);
                currentVideoFiles.Add(newObject);
            }
        }

        // Оброблення події кнопки видалення вибраних об'єктів зі списку
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (VideoFilesListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in VideoFilesListView.SelectedItems)
                {
                    VideoFile obj = ConvertToVideoFile(item);
                    currentVideoFiles.Remove(obj);
                    VideoFilesListView.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Оброблення події кнопки фільтрування списку 
        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm childForm = new FilterForm();

            // Відкривається нова форма для вибору критерію фільтрування
            var result = childForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Отримання фільтру і властивості з форми
                var filter = childForm.GetResultFilter();
                var property = childForm.GetResultProperty();

                // В залежності від фільтру шукаємо лише ті об'єкти, які відповідають критерію
                switch (filter)
                {
                    case VideoFilter.Location:

                        string locationFilter = property as string;

                        if (!string.IsNullOrEmpty(locationFilter))
                        {
                            currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles, 
                                file => file.Location == locationFilter);
                        }

                        break;

                    case VideoFilter.AudioCodec:

                        currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles,
                            file => file.ACodec == (AudioCodec)property);

                        break;

                    case VideoFilter.VideoCodec:

                        currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles, 
                            file => file.VCodec == (VideoCodec)property);

                        break;

                    case VideoFilter.VideoFormat:

                        currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles, 
                            file => file.Format == (VideoFormat)property);

                        break;

                    case VideoFilter.Duration:

                        var range = (TimeSpan[])property;

                        currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles,
                            file => (file.Duration >= range[0]) && (file.Duration <= range[1]));

                        break;

                    case VideoFilter.SubtitlesAvaliability:

                        currentVideoFiles = VideoFile.FindObjectsWithCorespondingProperties(sourceVideoFiles,
                            file => file.SubtitlesAvaliability == (bool)property);

                        break;

                    default:

                        break;
                }

                UpdateListView(currentVideoFiles);
            }
        }

        // Оброблення події натискання на головний елемент стовпня ListView
        // Використовується для сортування об'єктів
        private void VideoFilesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string columnName = VideoFilesListView.Columns[e.Column].Text;

            // Якщо було натиснуто перший раз, сортується за зростанням, другий - за спаданням...
            ascendingOrder = e.Column != lastSortedColumn ? true : !ascendingOrder;

            // Сортування за тривалістю, іменем, розміром
            if (columnName == "Duration")
            {
                SortVideoFilesAndUpdate((obj1, obj2) => obj1.Duration.CompareTo(obj2.Duration), ascendingOrder);
            }
            else if (columnName == "Name")
            {
                SortVideoFilesAndUpdate((obj1, obj2) => obj1.Name.CompareTo(obj2.Name), ascendingOrder);
            }
            else if (columnName == "Size")
            {
                SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Bytes.CompareTo(obj2.Size.Bytes), ascendingOrder);
            }

            lastSortedColumn = e.Column;
        }

        // Оброблення події натискання на кнопку відкриття файлу з об'єктами VideoFile
        // Використовується для отримання списку об'єктів з файлу
        private void OpenMenuStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    try
                    {
                        sourceVideoFiles = VideoFileSerializer.DeserializeJson(filePath);

                        currentVideoFiles.Clear();

                        foreach (var file in sourceVideoFiles)
                        {
                            currentVideoFiles.Add(file);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("File openning error, make sure you open.json file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    UpdateListView(currentVideoFiles);
                }
            }
        }


        // Оброблення події натискання на кнопку збереження об'єктів зі списку у файл
        private void SaveMenuStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    try
                    {
                        VideoFileSerializer.SerializeJson(currentVideoFiles, filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Data is saved successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Виведення на екран вхідного списку (того, що прочитаний з файлу)
        private void SourceButton_Click(object sender, EventArgs e)
        {
            UpdateListView(sourceVideoFiles);
        }

        // Виведення на екран поточного списку (того, з яким зараз працює користувач)
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            UpdateListView(currentVideoFiles);
        }

        // Очищає поточний список об'єктів
        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentVideoFiles.Clear();

            UpdateListView(currentVideoFiles);
        }

        // Подія натискання на кнопку About в головному меню
        // Виводить Прізвище, ім'я, групу розробника курсової роботи
        private void AboutMenuStripButton_Click(object sender, EventArgs e)
        {
            string message = "Objective-oriented programming course work\n";
            message += "Made by Pavlo Kokhan PZ-23";

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Оброблення події відкриття контекстного меню на панелі зі списком
        private void VideoFilesListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show(VideoFilesListView, e.Location);
            }
        }

        // Обробленння натискання кнопок на панелі інструментів
        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            OpenMenuStripButton.PerformClick();
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            SaveMenuStripButton.PerformClick();
        }

        private void ToolStripAdd_Click(object sender, EventArgs e)
        {
            AddButton.PerformClick();
        }

        private void ToolStripRemove_Click(object sender, EventArgs e)
        {
            RemoveButton.PerformClick();
        }

        private void ToolStripFilter_Click(object sender, EventArgs e)
        {
            FilterButton.PerformClick();
        }

        private void ToolStripClear_Click(object sender, EventArgs e)
        {
            ClearButton.PerformClick();
        }

        // Оброблення подій натискання кнопок в контекстному меню
        private void OpenContextMenuStripButton_Click(object sender, EventArgs e)
        {
            OpenMenuStripButton_Click(sender, e);
        }

        private void SaveContextMenuStripButton_Click(object sender, EventArgs e)
        {
            SaveMenuStripButton_Click(sender, e);
        }

        private void AddContextMenuStripButton_Click(object sender, EventArgs e)
        {
            AddButton_Click(sender, e);
        }

        private void RemoveContextMenuStripButton_Click(object sender, EventArgs e)
        {
            RemoveButton_Click(sender, e);  
        }

        private void FilterContextMenuStripButton_Click(object sender, EventArgs e)
        {
            FilterButton_Click(sender, e);  
        }

        private void ClearContextMenuStripButton_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }

        private void NameSortContextMenuAscending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Name.CompareTo(obj2.Name), true);
        }

        private void NameSortContextMenuDescending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Name.CompareTo(obj2.Name), false);
        }

        private void DurationSortContextMenuAscending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Duration.CompareTo(obj2.Duration), true);
        }

        private void DurationSortContextMenuDescending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Duration.CompareTo(obj2.Duration), false);
        }

        private void SizeSortContextMenuAscending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Bytes.CompareTo(obj2.Size.Bytes), true);
        }

        private void SizeSortContextMenuDescending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Bytes.CompareTo(obj2.Size.Bytes), false);
        }

        // Гарячі клавіші для додавання, видалення, фільтрування об'єктів у списку
        private void VideoFilesListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:

                        AddButton.PerformClick();

                        break;

                    case Keys.R:

                        RemoveButton.PerformClick();

                        break;

                    case Keys.F:

                        FilterButton.PerformClick();

                        break;

                    default:

                        break;
                }
            }
        }
    }
}
