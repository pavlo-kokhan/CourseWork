using CourseWork.Forms;
using Enums;
using SecondaryClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork
{
    using System.Linq;
    using Video;
    using Video.Filters;
    using Video.Filters.Abstract;

    public partial class MainForm : Form
    {
        private List<VideoFile> _videoFiles = new List<VideoFile>();

        public MainForm()
        {
            InitializeComponent();
        }

        private static ListViewItem ConvertToListViewItem(VideoFile videoFile)
        {
            var item = new ListViewItem(videoFile.Name);

            var duration = videoFile.GetDuration();
            var durationFormatted = $"{duration.Hours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";

            item.SubItems.Add(videoFile.Location);
            item.SubItems.Add(videoFile.Format.ToString());
            item.SubItems.Add(durationFormatted);
            item.SubItems.Add(videoFile.VCodec.ToString());
            item.SubItems.Add(videoFile.ACodec.ToString());
            item.SubItems.Add(videoFile.SubtitlesAvailability.ToString());
            item.SubItems.Add(videoFile.Size.ToString());
            item.SubItems.Add(videoFile.Player.ToString());

            return item;
        }

        private VideoFile ConvertToVideoFile(ListViewItem item)
        {
            return _videoFiles[ObjectsListView.Items.IndexOf(item)];
        }

        private void UpdateListView()
        {
            ObjectsListView.Items.Clear();

            foreach (var item in _videoFiles.Select(ConvertToListViewItem))
            {
                ObjectsListView.Items.Add(item);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var childForm = new AddNewObjectForm();
            var result = childForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            var newObject = childForm.GetResultObject();
            var item = ConvertToListViewItem(newObject);
            
            ObjectsListView.Items.Add(item);
            _videoFiles.Add(newObject);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ObjectsListView.SelectedItems)
                {
                    var obj = ConvertToVideoFile(item);
                    _videoFiles.Remove(obj);
                    ObjectsListView.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var childForm = new FilterForm();
            var result = childForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            _videoFiles = GetFilteredVideoFiles(childForm.Filter);

            UpdateListView();
        }

        private List<VideoFile> GetFilteredVideoFiles(IFilter filter)
        {
            switch (filter)
            {
                // case string specificProperty1:
                //     return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, specificProperty1);
                // case VideoFormat specificProperty2:
                //     return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, specificProperty2);
                case DurationFilter durationFilter:
                    return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, durationFilter.Duration);
                // case VideoCodec specificProperty4:
                //     return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, specificProperty4);
                // case AudioCodec specificProperty5:
                //     return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, specificProperty5);
                case SubtitlesAvailabilityFilter subtitlesAvailabilityFilter:
                    return VideoFile.FindObjectsWithCorrespondingProperties(_videoFiles, subtitlesAvailabilityFilter.IsAvailable);
            }

            return new List<VideoFile>();
        }

        private void OpenMenuStripButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                var filePath = ofd.FileName;

                try
                {
                    _videoFiles = VideoFileSerializer.DeserializeXml(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                UpdateListView();
            }
        }

        private void SaveMenuStripButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    try
                    {
                        VideoFileSerializer.SerializeXml(_videoFiles, filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _videoFiles.Clear();
            ObjectsListView.Clear();
        }
    }
}
