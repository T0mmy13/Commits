using System;
using System.Windows.Forms;

namespace SimpleWindowsFormsApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            Text = "Simple Windows Forms App";
            Width = 300;
            Height = 200;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}