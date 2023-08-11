using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Settings : Form
    {
        private static string selectedFilePath = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            selectedFilePath = Helper.OpenFileWithDialog("*.csv", "*.json");

            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                txtPath.Text = selectedFilePath;
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetButtonFontColor(Color color)
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.ForeColor = color;
                }
            }
            Settings s = new Settings();
            s.BackColor = color;
        }

        private void btnChangeColor01_Click(object sender, EventArgs e)
        {
            SetButtonFontColor(Color.Red);
            Settings s = new Settings();
            s.BackColor= Color.Red;
        }

        private void btnChangeColor02_Click(object sender, EventArgs e)
        {
            SetButtonFontColor(Color.Blue);
        }
    }
}
