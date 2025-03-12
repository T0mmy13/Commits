using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleWindowsFormsApp
{
    public class MainForm : Form
    {
        private Button showMessageButton;

        public MainForm()
        {
            Text = "Simple Windows Forms App";
            Width = 300;
            Height = 200;

            showMessageButton = new Button();
            showMessageButton.Text = "Show Message";
            showMessageButton.Width = 120;
            showMessageButton.Location = new System.Drawing.Point(90, 70);
            showMessageButton.BackColor = Color.LightBlue;
            showMessageButton.Font = new Font("Arial", 10, FontStyle.Bold);
            showMessageButton.Click += ShowMessageButton_Click;

            Controls.Add(showMessageButton);
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Windows Forms!");
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
