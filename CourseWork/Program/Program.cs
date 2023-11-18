using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Enums;
using VideoFileClass;
using SecondaryClasses;
using CourseWork.Forms;

namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //AddNewObjectForm anof = new AddNewObjectForm();

            //DialogResult dialogResult = anof.ShowDialog();

            //if (dialogResult == DialogResult.OK)
            //{
            //    try
            //    {
            //        var result = anof.GetResultVideoFile();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            //    }
            //}
        }
    }
}
