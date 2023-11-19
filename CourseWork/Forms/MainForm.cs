using CourseWork.Forms;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddObjectToListView(VideoFile obj)
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

            ObjectsListView.Items.Add(item);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            VideoFile newObject;

            AddNewObjectForm childForm = new AddNewObjectForm();

            DialogResult = childForm.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                newObject = childForm.GetResultObject();

                AddObjectToListView(newObject);
            }
        }
    }
}
