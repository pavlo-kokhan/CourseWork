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
        // Зберігає об'єкти VideoFile в такій послідовності, що і відображено на формі
        List<VideoFile> videoFiles = new List<VideoFile>();

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
            return videoFiles[VideoFilesListView.Items.IndexOf(item)];
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
            videoFiles.Sort(comparison);

            if (!ascending)
            {
                videoFiles.Reverse();
            }

            UpdateListView(videoFiles);
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
                videoFiles.Add(newObject);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (VideoFilesListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in VideoFilesListView.SelectedItems)
                {
                    VideoFile obj = ConvertToVideoFile(item);
                    videoFiles.Remove(obj);
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
                            videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles, 
                                file => file.Location == locationFilter);
                        }

                        break;

                    case VideoFilter.AudioCodec:

                        videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles,
                            file => file.ACodec == (AudioCodec)property);

                        break;

                    case VideoFilter.VideoCodec:

                        videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles, 
                            file => file.VCodec == (VideoCodec)property);

                        break;

                    case VideoFilter.VideoFormat:

                        videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles, 
                            file => file.Format == (VideoFormat)property);

                        break;

                    case VideoFilter.Duration:

                        videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles,
                            file => file.Duration == (TimeSpan)property);

                        break;

                    case VideoFilter.SubtitlesAvaliability:

                        videoFiles = VideoFile.FindObjectsWithCorespondingProperties(videoFiles,
                            file => file.SubtitlesAvaliability == (bool)property);

                        break;
                }

                UpdateListView(videoFiles);
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
                SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Kilobytes.CompareTo(obj2.Size.Kilobytes), ascendingOrder);
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
                        videoFiles = VideoFileSerializer.DeserializeJson(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failde to open: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    UpdateListView(videoFiles);
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
                        VideoFileSerializer.SerializeJson(videoFiles, filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            videoFiles.Clear();

            UpdateListView(videoFiles);
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
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Kilobytes.CompareTo(obj2.Size.Kilobytes), true);
        }

        private void SizeSortContextMenuDescending_Click(object sender, EventArgs e)
        {
            SortVideoFilesAndUpdate((obj1, obj2) => obj1.Size.Kilobytes.CompareTo(obj2.Size.Kilobytes), false);
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
                }
            }
        }
    }
}
