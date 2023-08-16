using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            LoadDefaultColors();
            Helper.Instance.AttachMoveableWindow(this, panelTop); // panelTop należy dostosować do Twojego kodu
        }
        private void LoadDefaultColors()
        {
            panelTop.BackColor = GlobalSettings.TopBarBackColor;
            this.BackColor = GlobalSettings.BackColor;
            SetButtonBackColor(GlobalSettings.ButtonBackColor, GlobalSettings.FontColor);

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

        private void SetButtonBackColor(Color backColor, Color fontColor)
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.ForeColor = fontColor;
                    button.BackColor = backColor;
                }
            }

            foreach (Control control in flpUIColorButtons.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.ForeColor = fontColor;
                    button.BackColor = backColor;
                }
            }

            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label button = (Label)control;
                    button.ForeColor = fontColor;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox button = (CheckBox)control;
                    button.ForeColor = fontColor;
                }
            }
        }

        private void btnChangeColor01_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = Color.Gray;
            GlobalSettings.TopBarBackColor = Color.DarkGray;

            LoadDefaultColors();
        }

        private void btnChangeColor02_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = ColorTranslator.FromHtml("#32364A");
            GlobalSettings.TopBarBackColor = ColorTranslator.FromHtml("#272838");
            GlobalSettings.ButtonBackColor = ColorTranslator.FromHtml("#272838");

            GlobalSettings.FontColor = ColorTranslator.FromHtml("#CFA3FC");

            LoadDefaultColors();
        }

        private void btnChangeColor03_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = Color.FromArgb(46, 50, 68);
            GlobalSettings.TopBarBackColor = Color.FromArgb(39, 40, 56);

            LoadDefaultColors();
        }

        private void btnChangeColor04_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = ColorTranslator.FromHtml("#DDDBDE");
            GlobalSettings.TopBarBackColor = ColorTranslator.FromHtml("#656E77");
            GlobalSettings.ButtonBackColor = ColorTranslator.FromHtml("#CAD4DF");

            GlobalSettings.FontColor = ColorTranslator.FromHtml("#3B373B");

            LoadDefaultColors();
        }
    }
}
