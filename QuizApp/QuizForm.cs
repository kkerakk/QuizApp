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
        private string selectedFilePath = "";
        private int correctAnswer = 0;
        private int goodAnswers = 0;
        private int badAnswers = 0;
        private int amountQuestionsLeft = 0;
        private List<Button> buttons = new List<Button>();
        private float resultCorrect;
        private float totalResult;
        private int amountAllQuestions = 0;
        private static int progressBarValue = 0;
        public QuizForm()
        {
            InitializeComponent();
            LoadPath();
            LoadQuestions();
            InitializeData();
            ResetStatistics();

            Helper.Instance.AttachMoveableWindow(this, panelTop); // Moveable window
        }

        private void btnLoadQuestions_Click(object sender, EventArgs e)
        {
            selectedFilePath = Helper.OpenFileWithDialog("*.csv", "*.json");
            if (String.IsNullOrEmpty(selectedFilePath))
                return;
            LoadQuestions();
            ResetStatistics();
        }

        private void btnRandomQuestion_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
            ResetButtonsColor();
            IsButtonEnabled(1);
            Debug();
        }

        private void Debug()
        {
            lblDebugCorrectAnswerCounter.Text = correctAnswer.ToString();
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
            //questionsLeft = questionList.Count;
            //lblLeftQuestionsCounter.Text = questionList.Count.ToString();
            //btnStart.Enabled = false;
            btnStart.Visible = false;
            flpQuestion.Visible = true;
            flpAnswers.Visible = true;
            IsButtonEnabled(1);
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

        //private void GenerateQuestion()
        //{
        //    correctAnswer = 0;
        //    var random = new Random();
        //    int randomNumber = random.Next(0, questionList.Count);

        //    btnRandomQuestion.Enabled = false;
        //    btnRandomQuestion.Visible = false;

        //    lblQuestion.Text = questionList[randomNumber].Question.ToString();
        //    btnA.Text = questionList[randomNumber].Options[0].ToString();
        //    btnB.Text = questionList[randomNumber].Options[1].ToString();
        //    btnC.Text = questionList[randomNumber].Options[2].ToString();
        //    btnD.Text = questionList[randomNumber].Options[3].ToString();

        //    correctAnswer = questionList[randomNumber].CorrectAnswer;
        //}
        private void GenerateQuestion()
        {
            if (questionList.Count == 0)
            {
                lblSummaryCounter.Text = CountPoints();
                pbCompleted.Visible = false;
                flpQuestion.Visible = false;
                flpAnswers.Visible=false;
                btnRandomQuestion.Visible = false;
                panelSummary.Visible = true;
                return;
            }

            int randomNumber = new Random().Next(0, questionList.Count);

            QuizQuestion selectedQuestion = questionList[randomNumber];
            questionList.RemoveAt(randomNumber);

            btnRandomQuestion.Enabled = false;
            btnRandomQuestion.Visible = false;

            lblQuestion.Text = selectedQuestion.Question.ToString();
            btnA.Text = selectedQuestion.Options[0].ToString();
            btnB.Text = selectedQuestion.Options[1].ToString();
            btnC.Text = selectedQuestion.Options[2].ToString();
            btnD.Text = selectedQuestion.Options[3].ToString();

            correctAnswer = selectedQuestion.CorrectAnswer;
        }
        private void InitializeData()
        {
            buttons.Add(btnA);
            buttons.Add(btnB);
            buttons.Add(btnC);
            buttons.Add(btnD);

            KeyPreview = true;

            // visibility
            flpDebug.Visible = false;
            flpAnswers.Visible = false;
            flpQuestion.Visible = false;
            btnRandomQuestion.Visible = false;
        }
        private void ResetStatistics()
        {
            lblCorrectAnswersCounter.Text = "0";
            lblIncorrectAnswersCounter.Text = "0";
            lblProgressCounter.Text = "0";
            lblAnsweredQuestionsCounter.Text = "0";

            goodAnswers = 0;
            badAnswers = 0;
            resultCorrect = 0;
            totalResult = 0;

            ResetButtonsColor();

            flpAnswers.Visible = false;
            flpQuestion.Visible=false;
            btnStart.Visible = true;
            btnRandomQuestion.Visible=false;
        }
        private void ResetButtonsColor()
        {
            foreach (var item in buttons)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.FromArgb(50, 60, 91);
            }
        }
        private void LoadPath()
        {
            selectedFilePath = @"I:\_11\QuizSpreadSheet.csv";
        }
        private void LoadQuestions()
        {            
            questionList = Helper.ParseCsv(selectedFilePath);
            amountAllQuestions = questionList.Count;
            amountQuestionsLeft = questionList.Count;
            pbCompleted.Value = 0;
            lblAllQuestionsCounter.Text = amountAllQuestions.ToString();
            lblLeftQuestionsCounter.Text= amountAllQuestions.ToString();
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
            amountQuestionsLeft--;
            lblProgressCounter.Text = CalcProgressDouble().ToString()+"%";
            lblIncorrectAnswersCounter.Text = badAnswers.ToString();
            lblLeftQuestionsCounter.Text = amountQuestionsLeft.ToString();
            int sumAnsweredQuestions = goodAnswers + badAnswers;
            lblAnsweredQuestionsCounter.Text = sumAnsweredQuestions.ToString();

            pbCompleted.Value = CalcProgress();
            IsButtonEnabled(0);
        }
        private void CorrectAnswer(Button btn)
        {
            btn.BackColor = Color.LawnGreen;
            btnRandomQuestion.Enabled = true;
            btnRandomQuestion.Visible = true;
            resultCorrect++;
            totalResult++;
            goodAnswers++;
            amountQuestionsLeft--;
            lblProgressCounter.Text = CalcProgressDouble().ToString()+"%";
            lblCorrectAnswersCounter.Text = goodAnswers.ToString();
            lblLeftQuestionsCounter.Text = amountQuestionsLeft.ToString();
            int sumAnsweredQuestions = goodAnswers + badAnswers;
            lblAnsweredQuestionsCounter.Text = sumAnsweredQuestions.ToString();

            pbCompleted.Value = CalcProgress();
            IsButtonEnabled(0);
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
        private int CalcProgress()
        {

            progressBarValue = (int)Math.Round((double)(amountAllQuestions - amountQuestionsLeft) * 100 / amountAllQuestions);
            return progressBarValue;
        }
        private double CalcProgressDouble()
        {
            double progress = (double)(amountAllQuestions - amountQuestionsLeft) * 100 / amountAllQuestions;
            double roundedProgress = Math.Round(progress, 2);
            return roundedProgress;
        }

        private string CountPoints()
        {
            if (totalResult <= 0)
            {
                return "0";
            }
            float percentage = resultCorrect/totalResult * 100;
            return $"{percentage.ToString("F1")}%";
        }
        private void QuizForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                flpDebug.Visible = !flpDebug.Visible;
            }
        }
        public void ChangeColor()
        {
            panelTop.BackColor = GlobalSettings.Background1;
            panelInfo.BackColor = GlobalSettings.Background1;
            panelTopScore.BackColor = GlobalSettings.Background2;

            lblProgressCounter.ForeColor = GlobalSettings.Font1;
        }
    }
}