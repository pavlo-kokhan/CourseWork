using System;
using System.Windows.Forms;

namespace CourseWork
{
    internal static class Program
    {
        // Точка входу у програму
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
