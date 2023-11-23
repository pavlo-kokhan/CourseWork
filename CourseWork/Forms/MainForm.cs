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

        private VideoFile ConvertToVideoFile(ListViewItem item)
        {
            return currentVideoFiles[VideoFilesListView.Items.IndexOf(item)];
        }

        private void UpdateListView(List<VideoFile> list)
        {
            VideoFilesListView.Items.Clear(); 

            foreach (var obj in list)
            {
                ListViewItem item = ConvertToListViewItem(obj);

                VideoFilesListView.Items.Add(item);
            }
        }

        private void SortVideoFilesAndUpdate(Comparison<VideoFile> comparison, bool ascending)
        {
            currentVideoFiles.Sort(comparison);

            if (!ascending)
            {
                currentVideoFiles.Reverse();
            }

            UpdateListView(currentVideoFiles);
        }

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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm childForm = new FilterForm();

            var result = childForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filter = childForm.GetResultFilter();

                var property = childForm.GetResultProperty();

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

        private void VideoFilesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string columnName = VideoFilesListView.Columns[e.Column].Text;

            ascendingOrder = e.Column != lastSortedColumn ? true : !ascendingOrder;

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

                        foreach (var file in sourceVideoFiles)
                        {
                            currentVideoFiles.Add(file);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("File penning error, make sure you open.json file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    UpdateListView(currentVideoFiles);
                }
            }
        }

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
                }
            }
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            UpdateListView(sourceVideoFiles);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentVideoFiles.Clear();

            UpdateListView(currentVideoFiles);
        }

        private void AboutMenuStripButton_Click(object sender, EventArgs e)
        {
            string message = "Objective-oriented programming course work\n";
            message += "Made by Pavlo Kokhan PZ-23";

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VideoFilesListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show(VideoFilesListView, e.Location);
            }
        }

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
