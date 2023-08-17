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
        QuizForm quizForm = new QuizForm();
        public Settings()
        {
            InitializeComponent();
            LoadDefaultColors();
            LoadColors();
            Helper.Instance.AttachMoveableWindow(this, panelTop);
        }
        private void LoadDefaultColors()
        {
            GlobalSettings.Background1 = ColorTranslator.FromHtml("#32364A");
            GlobalSettings.Background2 = ColorTranslator.FromHtml("#272838");
            GlobalSettings.Background3 = ColorTranslator.FromHtml("#272838");
            GlobalSettings.Font1 = ColorTranslator.FromHtml("#CFA3FC");
            GlobalSettings.Font2 = ColorTranslator.FromHtml("#414357");
        }
        private void LoadColors()
        {
            panelTop.BackColor = GlobalSettings.Background3;
            this.BackColor = GlobalSettings.Background1;
            SetButtonBackColor(GlobalSettings.Background2, GlobalSettings.Font1);
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
            GlobalSettings.Background1 = ColorTranslator.FromHtml("#32364A");
            GlobalSettings.Background2 = ColorTranslator.FromHtml("#272838");
            GlobalSettings.Background3 = ColorTranslator.FromHtml("#272838");
            GlobalSettings.Font1 = ColorTranslator.FromHtml("#02cfc1");
            LoadColors();
            quizForm.ChangeColor();
        }

        private void btnChangeColor02_Click(object sender, EventArgs e)
        {
            GlobalSettings.Background1 = ColorTranslator.FromHtml("#32364A");
            GlobalSettings.Background2 = ColorTranslator.FromHtml("#272838");
            GlobalSettings.Background3 = ColorTranslator.FromHtml("#272838"); 
            GlobalSettings.Font1 = ColorTranslator.FromHtml("#CFA3FC");
            LoadColors();
            quizForm.ChangeColor();
        }

        private void btnChangeColor03_Click(object sender, EventArgs e)
        {
            GlobalSettings.Background1 = ColorTranslator.FromHtml("#212123");
            GlobalSettings.Background2 = ColorTranslator.FromHtml("#303030");
            GlobalSettings.Background3 = ColorTranslator.FromHtml("#febf12");
            GlobalSettings.Font1 = ColorTranslator.FromHtml("#cfcdcf");
            LoadColors();
            quizForm.ChangeColor();
        }

        private void btnChangeColor04_Click(object sender, EventArgs e)
        {
            GlobalSettings.Background1 = ColorTranslator.FromHtml("#DDDBDE");
            GlobalSettings.Background2 = ColorTranslator.FromHtml("#CAD4DF");
            GlobalSettings.Background3 = ColorTranslator.FromHtml("#656E77");
            GlobalSettings.Font1 = ColorTranslator.FromHtml("#3B373B");
            LoadColors();
            quizForm.ChangeColor();
        }
    }
}
