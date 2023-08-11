using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Drawing;
using System.Runtime.InteropServices;

namespace QuizApp
{
    public partial class QuizForm : Form
    {



        private List<QuizQuestion> questionList = new List<QuizQuestion>();
        string path = @"I:\_11\QuizSpreadSheet.csv";
        private int correctAnswer = 0;
        private int goodAnswers = 0;
        private int badAnswers = 0;
        private int questionsLeft = 0;
        private List<Button> buttons = new List<Button>();
        private float resultCorrect;
        private float totalResult;
        public QuizForm()
        {
            InitializeComponent();
            LoadQuestions();
            InitializeData();

            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
        }
        #region Moveable Application

        
        private const int WM_NCHITTEST = 0x0084;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private bool isDragging = false;
        private int mouseX, mouseY;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = this.Left + e.X - mouseX;
                int newY = this.Top + e.Y - mouseY;
                this.Location = new System.Drawing.Point(newX, newY);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isDragging = false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
                if (m.Result.ToInt32() == HT_CAPTION)
                    m.Result = IntPtr.Zero;
        }
        #endregion
        public List<QuizQuestion> ParseCsv(string filePath)
        {
            List<QuizQuestion> questions = new List<QuizQuestion>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length == 7) // Assuming 7 columns in the CSV
                    {
                        QuizQuestion question = new QuizQuestion
                        {
                            Question = fields[0],
                            Options = new string[] { fields[1], fields[2], fields[3], fields[4] },
                            CorrectAnswer = int.Parse(fields[5]),
                            QuestionType = fields[6]
                        };

                        questions.Add(question);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format in CSV.");
                    }
                }
            }
            return questions;
        }

        private void btnLoadQuestions_Click(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
            ResetButtonsColor();

            IsButtonEnabled(1);
            DebugInApp();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (correctAnswer == 1)
                CorrectAnswer(btnA);
            else
                IncorrectAnswer(btnA);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (correctAnswer == 2)
                CorrectAnswer(btnB);
            else
                IncorrectAnswer(btnB);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (correctAnswer == 3)
                CorrectAnswer(btnC);
            else 
                IncorrectAnswer(btnC);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (correctAnswer == 4)
                CorrectAnswer(btnD);
            else
                IncorrectAnswer(btnD);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
            questionsLeft = questionList.Count;
            lblLeftQuestionsCounter.Text = questionList.Count.ToString();
            btnStart.Enabled = false;
            btnStart.Visible = false;
            flpQuestion.Visible = true;
            flpAnswers.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GenerateQuestion()
        {
            correctAnswer = 0;
            var random = new Random();
            int randomNumber = random.Next(0, questionList.Count);

            btnRandomQuestion.Enabled = false;
            btnRandomQuestion.Visible = false;

            lblQuestion.Text = questionList[randomNumber].Question.ToString();
            btnA.Text = questionList[randomNumber].Options[0].ToString();
            btnB.Text = questionList[randomNumber].Options[1].ToString();
            btnC.Text = questionList[randomNumber].Options[2].ToString();
            btnD.Text = questionList[randomNumber].Options[3].ToString();

            correctAnswer = questionList[randomNumber].CorrectAnswer;
        }
        private void InitializeData()
        {
            buttons.Add(btnA);
            buttons.Add(btnB);
            buttons.Add(btnC);
            buttons.Add(btnD);

            // default values
            lblCorrectAnswersCounter.Text = "0";
            lblIncorrectAnswersCounter.Text = "0";
            lblLeftQuestionsCounter.Text = "0";
            lblAnsweredQuestionsCounter.Text = "0";
            KeyPreview = true;

            //visibility
            panelTest.Visible = false;
            btnLoadQuestions.Visible = false;
            flpAnswers.Visible = false;
            flpQuestion.Visible = false;
            btnRandomQuestion.Visible = false;
        }
        private void ResetButtonsColor()
        {
            foreach (var item in buttons)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.FromArgb(50, 60, 91);
            }
        }
        private void LoadQuestions()
        {            
            questionList = ParseCsv(path);
            lblCounter.Text = questionList.Count.ToString();
            lblAllQuestionsCounter.Text = questionList.Count.ToString();
            questionsLeft = questionList.Count;
            lblLeftQuestionsCounter.Text= questionList.Count.ToString();
        }
        private void IncorrectAnswer(Button btn)
        {
            btn.BackColor = Color.Crimson;        

            for (int i = 1; i <= buttons.Count+1; i++)
            {
                if (correctAnswer == i)
                {
                    buttons[i-1].BackColor = Color.Green;
                }
            }

            btnRandomQuestion.Enabled = true;
            btnRandomQuestion.Visible = true;
            totalResult++;
            badAnswers++;
            questionsLeft--;
            lblResultCounter.Text = CountPoints();
            lblIncorrectAnswersCounter.Text = badAnswers.ToString();
            lblLeftQuestionsCounter.Text = questionsLeft.ToString();
            int sumAnsweredQuestions = goodAnswers + badAnswers;
            lblAnsweredQuestionsCounter.Text = sumAnsweredQuestions.ToString();

            IsButtonEnabled(0);
            DebugInApp();
        }
        private void CorrectAnswer(Button btn)
        {
            btn.BackColor = Color.LawnGreen;
            btnRandomQuestion.Enabled = true;
            btnRandomQuestion.Visible = true;
            resultCorrect++;
            totalResult++;
            goodAnswers++;
            questionsLeft--;
            lblResultCounter.Text = CountPoints();            
            lblCorrectAnswersCounter.Text = goodAnswers.ToString();
            lblLeftQuestionsCounter.Text = questionsLeft.ToString();
            int sumAnsweredQuestions = goodAnswers + badAnswers;
            lblAnsweredQuestionsCounter.Text = sumAnsweredQuestions.ToString();

            IsButtonEnabled(0);
            DebugInApp();
        }
        /// <summary>
        /// set value: 0 - disabled
        /// or value: 1 - enabled
        /// </summary>
        private void IsButtonEnabled(int isEnabled)
        {
            foreach (var item in buttons)
            {
                if (isEnabled == 0)
                    item.Enabled = false;
                if (isEnabled == 1)
                    item.Enabled = true;
            }
        }
        private string CountPoints()
        {
            if (totalResult <= 0)
            {
                return "0";
            }
            float percentage = resultCorrect/totalResult * 100;
            //return $"{result}/{totalResult} ({percentage.ToString("F1")}%)";
            return $"{percentage.ToString("F1")}%";
        }
        private void QuizForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                panelTest.Visible = !panelTest.Visible;
            }
        }

        private void DebugInApp()
        {
            testField01.Text = correctAnswer.ToString(); //test
            testField02.Text = $"correct: {resultCorrect}"; //test
            testField03.Text = $"total: {totalResult}"; //test
        }
    }
}