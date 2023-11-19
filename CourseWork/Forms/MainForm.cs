using CourseWork.Forms;
using Enums;
using SecondaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoFileClass;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        List<VideoFile> objects = new List<VideoFile>();

        public MainForm()
        {
            InitializeComponent();
        }

        private ListViewItem ConvertToListViewItem(VideoFile obj)
        {
            ListViewItem item = new ListViewItem(obj.NameString);

            var duration = obj.GetDuration();
            string durationFormatted = $"{duration.Hours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";

            item.SubItems.Add(obj.LocationString);
            item.SubItems.Add(obj.FormatString);
            item.SubItems.Add(durationFormatted);
            item.SubItems.Add(obj.VCodecString);
            item.SubItems.Add(obj.ACodecString);
            item.SubItems.Add(obj.SubtitlesAvaliabilityString);
            item.SubItems.Add(obj.SizeString);
            item.SubItems.Add(obj.PlayerString);

            return item;
        }

        private VideoFile ConvertToVideoFile(ListViewItem item)
        {
            return objects[ObjectsListView.Items.IndexOf(item)];
        }

        private void UpdateListView(List<VideoFile> list)
        {
            ObjectsListView.Items.Clear(); 

            foreach (var obj in list)
            {
                ListViewItem item = ConvertToListViewItem(obj);

                ObjectsListView.Items.Add(item);
            }
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
                ObjectsListView.Items.Add(item);
                objects.Add(newObject);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ObjectsListView.SelectedItems)
                {
                    VideoFile obj = ConvertToVideoFile(item);
                    objects.Remove(obj);
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
            FilterForm childForm = new FilterForm();

            var result = childForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var property = childForm.GetResultProperty();

                if (property is string specificProperty1)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty1);
                }
                else if (property is VideoFormat specificProperty2)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty2);
                }
                else if (property is TimeSpan specificProperty3)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty3);
                }
                else if (property is VideoCodec specificProperty4)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty4);
                }
                else if (property is AudioCodec specificProperty5)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty5);
                }
                else if (property is bool specificProperty6)
                {
                    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty6);
                }

                UpdateListView(objects);
            }
        }

        private void OpenMenuStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    try
                    {
                        objects = VideoFileSerializer.DeserializeXml(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    UpdateListView(objects);
                }
            }
        }

        private void SaveMenuStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    try
                    {
                        VideoFileSerializer.SerializeXml(objects, filePath);
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
            objects.Clear();

            ObjectsListView.Clear();
        }
    }
}
