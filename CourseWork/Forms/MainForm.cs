using CourseWork.Forms;
using Enums;
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

        private void AddObjectToListView(VideoFile obj)
        {
            ListViewItem item = ConvertToListViewItem(obj);

            ObjectsListView.Items.Add(item);

            objects.Add(obj);
        }

        private void UpdateListView(List<VideoFile> list)
        {
            foreach (var obj in list)
            {
                AddObjectToListView(obj);
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

                AddObjectToListView(newObject);
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

                //if (property is string specificProperty1)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty1);
                //}
                //else if (property is VideoFormat specificProperty2)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty2);
                //}
                //else if (property is TimeSpan specificProperty3)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty3);
                //}
                //else if (property is VideoCodec specificProperty4)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty4);
                //}
                //else if (property is AudioCodec specificProperty5)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty5);
                //}
                //else if (property is bool specificProperty6)
                //{
                //    objects = VideoFile.FindObjectsWithCorespondingProperties(objects, specificProperty6);
                //}
            }

            // update list view
        }
    }
}
