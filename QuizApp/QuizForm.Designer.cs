﻿namespace QuizApp
{
    partial class QuizForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnLoadQuestions = new System.Windows.Forms.Button();
            this.lblCountQuestions = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnRandomQuestion = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelTest = new System.Windows.Forms.Panel();
            this.testField03 = new System.Windows.Forms.Label();
            this.testField02 = new System.Windows.Forms.Label();
            this.testField01 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.flpAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelTopScore = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblResultCounter = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblCorrectAnswersCounter = new System.Windows.Forms.Label();
            this.lblIncorrectAnswers = new System.Windows.Forms.Label();
            this.lblIncorrectAnswersCounter = new System.Windows.Forms.Label();
            this.lblAnsweredQuestions = new System.Windows.Forms.Label();
            this.lblAnsweredQuestionsCounter = new System.Windows.Forms.Label();
            this.lblLeftQuestions = new System.Windows.Forms.Label();
            this.lblAllQuestions = new System.Windows.Forms.Label();
            this.lblLeftQuestionsCounter = new System.Windows.Forms.Label();
            this.lblAllQuestionsCounter = new System.Windows.Forms.Label();
            this.panelTest.SuspendLayout();
            this.flpAnswers.SuspendLayout();
            this.flpQuestion.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.flpStatistics.SuspendLayout();
            this.panelTopScore.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.btnA.Location = new System.Drawing.Point(10, 6);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(760, 75);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Odpowiedź A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.btnB.Location = new System.Drawing.Point(10, 87);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(760, 75);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "Odpowiedź B";
            this.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.btnC.Location = new System.Drawing.Point(10, 168);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(760, 75);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Odpowiedź C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.btnD.Location = new System.Drawing.Point(10, 249);
            this.btnD.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(760, 75);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "Odpowiedź D";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnLoadQuestions
            // 
            this.btnLoadQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.btnLoadQuestions.FlatAppearance.BorderSize = 0;
            this.btnLoadQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadQuestions.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLoadQuestions.Location = new System.Drawing.Point(205, 695);
            this.btnLoadQuestions.Name = "btnLoadQuestions";
            this.btnLoadQuestions.Size = new System.Drawing.Size(170, 50);
            this.btnLoadQuestions.TabIndex = 5;
            this.btnLoadQuestions.Text = "Załaduj pytania";
            this.btnLoadQuestions.UseVisualStyleBackColor = false;
            this.btnLoadQuestions.Click += new System.EventHandler(this.btnLoadQuestions_Click);
            // 
            // lblCountQuestions
            // 
            this.lblCountQuestions.AutoSize = true;
            this.lblCountQuestions.Location = new System.Drawing.Point(915, 13);
            this.lblCountQuestions.Name = "lblCountQuestions";
            this.lblCountQuestions.Size = new System.Drawing.Size(91, 13);
            this.lblCountQuestions.TabIndex = 6;
            this.lblCountQuestions.Text = "Ilość pytań w puli:";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(1012, 13);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 7;
            this.lblCounter.Text = "0";
            // 
            // btnRandomQuestion
            // 
            this.btnRandomQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.btnRandomQuestion.FlatAppearance.BorderSize = 0;
            this.btnRandomQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRandomQuestion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRandomQuestion.Location = new System.Drawing.Point(23, 695);
            this.btnRandomQuestion.Name = "btnRandomQuestion";
            this.btnRandomQuestion.Size = new System.Drawing.Size(170, 50);
            this.btnRandomQuestion.TabIndex = 8;
            this.btnRandomQuestion.Text = "Następne pytanie";
            this.btnRandomQuestion.UseVisualStyleBackColor = false;
            this.btnRandomQuestion.Click += new System.EventHandler(this.btnRandomQuestion_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.lblResult.Location = new System.Drawing.Point(91, 129);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 37);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Wynik";
            // 
            // panelTest
            // 
            this.panelTest.BackColor = System.Drawing.Color.RosyBrown;
            this.panelTest.Controls.Add(this.testField03);
            this.panelTest.Controls.Add(this.testField02);
            this.panelTest.Controls.Add(this.testField01);
            this.panelTest.Controls.Add(this.lblCountQuestions);
            this.panelTest.Controls.Add(this.lblCounter);
            this.panelTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTest.Location = new System.Drawing.Point(0, 750);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(1091, 35);
            this.panelTest.TabIndex = 11;
            // 
            // testField03
            // 
            this.testField03.AutoSize = true;
            this.testField03.Location = new System.Drawing.Point(384, 13);
            this.testField03.Name = "testField03";
            this.testField03.Size = new System.Drawing.Size(35, 13);
            this.testField03.TabIndex = 2;
            this.testField03.Text = "label1";
            // 
            // testField02
            // 
            this.testField02.AutoSize = true;
            this.testField02.Location = new System.Drawing.Point(267, 13);
            this.testField02.Name = "testField02";
            this.testField02.Size = new System.Drawing.Size(35, 13);
            this.testField02.TabIndex = 1;
            this.testField02.Text = "label1";
            // 
            // testField01
            // 
            this.testField01.AutoSize = true;
            this.testField01.Location = new System.Drawing.Point(152, 13);
            this.testField01.Name = "testField01";
            this.testField01.Size = new System.Drawing.Size(35, 13);
            this.testField01.TabIndex = 0;
            this.testField01.Text = "label1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(92, 29);
            this.lblQuestion.TabIndex = 12;
            this.lblQuestion.Text = "Pytanie";
            // 
            // flpAnswers
            // 
            this.flpAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.flpAnswers.Controls.Add(this.btnA);
            this.flpAnswers.Controls.Add(this.btnB);
            this.flpAnswers.Controls.Add(this.btnC);
            this.flpAnswers.Controls.Add(this.btnD);
            this.flpAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAnswers.Location = new System.Drawing.Point(15, 352);
            this.flpAnswers.Name = "flpAnswers";
            this.flpAnswers.Padding = new System.Windows.Forms.Padding(7, 3, 10, 3);
            this.flpAnswers.Size = new System.Drawing.Size(780, 330);
            this.flpAnswers.TabIndex = 13;
            // 
            // flpQuestion
            // 
            this.flpQuestion.Controls.Add(this.lblQuestion);
            this.flpQuestion.Location = new System.Drawing.Point(15, 85);
            this.flpQuestion.Name = "flpQuestion";
            this.flpQuestion.Size = new System.Drawing.Size(780, 261);
            this.flpQuestion.TabIndex = 14;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panelInfo.Controls.Add(this.flpStatistics);
            this.panelInfo.Controls.Add(this.btnSettings);
            this.panelInfo.Controls.Add(this.panelTopScore);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfo.Location = new System.Drawing.Point(802, 32);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(289, 718);
            this.panelInfo.TabIndex = 15;
            // 
            // flpStatistics
            // 
            this.flpStatistics.Controls.Add(this.lblCorrectAnswers);
            this.flpStatistics.Controls.Add(this.lblCorrectAnswersCounter);
            this.flpStatistics.Controls.Add(this.lblIncorrectAnswers);
            this.flpStatistics.Controls.Add(this.lblIncorrectAnswersCounter);
            this.flpStatistics.Controls.Add(this.lblAnsweredQuestions);
            this.flpStatistics.Controls.Add(this.lblAnsweredQuestionsCounter);
            this.flpStatistics.Controls.Add(this.lblLeftQuestions);
            this.flpStatistics.Controls.Add(this.lblLeftQuestionsCounter);
            this.flpStatistics.Controls.Add(this.lblAllQuestions);
            this.flpStatistics.Controls.Add(this.lblAllQuestionsCounter);
            this.flpStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpStatistics.Location = new System.Drawing.Point(0, 216);
            this.flpStatistics.Name = "flpStatistics";
            this.flpStatistics.Padding = new System.Windows.Forms.Padding(2);
            this.flpStatistics.Size = new System.Drawing.Size(289, 267);
            this.flpStatistics.TabIndex = 14;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(34, 653);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(219, 50);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelTopScore
            // 
            this.panelTopScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panelTopScore.Controls.Add(this.lblResultCounter);
            this.panelTopScore.Controls.Add(this.lblResult);
            this.panelTopScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopScore.Location = new System.Drawing.Point(0, 0);
            this.panelTopScore.Name = "panelTopScore";
            this.panelTopScore.Size = new System.Drawing.Size(289, 216);
            this.panelTopScore.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnStart.Location = new System.Drawing.Point(265, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(310, 129);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(1061, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(27, 27);
            this.btnCloseApp.TabIndex = 11;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.Image")));
            this.btnMinimizeApp.Location = new System.Drawing.Point(1028, 2);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(27, 27);
            this.btnMinimizeApp.TabIndex = 12;
            this.btnMinimizeApp.UseVisualStyleBackColor = true;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.btnCloseApp);
            this.panelTop.Controls.Add(this.btnMinimizeApp);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1091, 32);
            this.panelTop.TabIndex = 17;
            // 
            // lblResultCounter
            // 
            this.lblResultCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblResultCounter.Location = new System.Drawing.Point(5, 56);
            this.lblResultCounter.Name = "lblResultCounter";
            this.lblResultCounter.Size = new System.Drawing.Size(278, 73);
            this.lblResultCounter.TabIndex = 20;
            this.lblResultCounter.Text = "0,0%";
            this.lblResultCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(5, 2);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(230, 27);
            this.lblCorrectAnswers.TabIndex = 26;
            this.lblCorrectAnswers.Text = "Prawidłowe odpowiedzi:";
            this.lblCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorrectAnswersCounter
            // 
            this.lblCorrectAnswersCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorrectAnswersCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrectAnswersCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblCorrectAnswersCounter.Location = new System.Drawing.Point(241, 2);
            this.lblCorrectAnswersCounter.Name = "lblCorrectAnswersCounter";
            this.lblCorrectAnswersCounter.Size = new System.Drawing.Size(42, 27);
            this.lblCorrectAnswersCounter.TabIndex = 27;
            this.lblCorrectAnswersCounter.Text = "000";
            this.lblCorrectAnswersCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIncorrectAnswers
            // 
            this.lblIncorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblIncorrectAnswers.Location = new System.Drawing.Point(5, 29);
            this.lblIncorrectAnswers.Name = "lblIncorrectAnswers";
            this.lblIncorrectAnswers.Size = new System.Drawing.Size(230, 27);
            this.lblIncorrectAnswers.TabIndex = 28;
            this.lblIncorrectAnswers.Text = "Błędne odpowiedzi:";
            this.lblIncorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncorrectAnswersCounter
            // 
            this.lblIncorrectAnswersCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncorrectAnswersCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncorrectAnswersCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblIncorrectAnswersCounter.Location = new System.Drawing.Point(241, 29);
            this.lblIncorrectAnswersCounter.Name = "lblIncorrectAnswersCounter";
            this.lblIncorrectAnswersCounter.Size = new System.Drawing.Size(42, 27);
            this.lblIncorrectAnswersCounter.TabIndex = 29;
            this.lblIncorrectAnswersCounter.Text = "000";
            this.lblIncorrectAnswersCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnsweredQuestions
            // 
            this.lblAnsweredQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnsweredQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnsweredQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblAnsweredQuestions.Location = new System.Drawing.Point(5, 56);
            this.lblAnsweredQuestions.Name = "lblAnsweredQuestions";
            this.lblAnsweredQuestions.Size = new System.Drawing.Size(230, 27);
            this.lblAnsweredQuestions.TabIndex = 30;
            this.lblAnsweredQuestions.Text = "Udzielonych odpowiedzi:";
            this.lblAnsweredQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnsweredQuestionsCounter
            // 
            this.lblAnsweredQuestionsCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnsweredQuestionsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnsweredQuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblAnsweredQuestionsCounter.Location = new System.Drawing.Point(241, 56);
            this.lblAnsweredQuestionsCounter.Name = "lblAnsweredQuestionsCounter";
            this.lblAnsweredQuestionsCounter.Size = new System.Drawing.Size(42, 27);
            this.lblAnsweredQuestionsCounter.TabIndex = 31;
            this.lblAnsweredQuestionsCounter.Text = "000";
            this.lblAnsweredQuestionsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeftQuestions
            // 
            this.lblLeftQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeftQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeftQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblLeftQuestions.Location = new System.Drawing.Point(5, 83);
            this.lblLeftQuestions.Name = "lblLeftQuestions";
            this.lblLeftQuestions.Size = new System.Drawing.Size(230, 27);
            this.lblLeftQuestions.TabIndex = 32;
            this.lblLeftQuestions.Text = "Pozostało pytań:";
            this.lblLeftQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllQuestions
            // 
            this.lblAllQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAllQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblAllQuestions.Location = new System.Drawing.Point(5, 110);
            this.lblAllQuestions.Name = "lblAllQuestions";
            this.lblAllQuestions.Size = new System.Drawing.Size(230, 27);
            this.lblAllQuestions.TabIndex = 34;
            this.lblAllQuestions.Text = "Ilość wszystkich pytań:";
            this.lblAllQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLeftQuestionsCounter
            // 
            this.lblLeftQuestionsCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeftQuestionsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeftQuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblLeftQuestionsCounter.Location = new System.Drawing.Point(241, 83);
            this.lblLeftQuestionsCounter.Name = "lblLeftQuestionsCounter";
            this.lblLeftQuestionsCounter.Size = new System.Drawing.Size(42, 27);
            this.lblLeftQuestionsCounter.TabIndex = 33;
            this.lblLeftQuestionsCounter.Text = "000";
            this.lblLeftQuestionsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAllQuestionsCounter
            // 
            this.lblAllQuestionsCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllQuestionsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAllQuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblAllQuestionsCounter.Location = new System.Drawing.Point(241, 110);
            this.lblAllQuestionsCounter.Name = "lblAllQuestionsCounter";
            this.lblAllQuestionsCounter.Size = new System.Drawing.Size(42, 27);
            this.lblAllQuestionsCounter.TabIndex = 35;
            this.lblAllQuestionsCounter.Text = "000";
            this.lblAllQuestionsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1091, 785);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flpQuestion);
            this.Controls.Add(this.btnLoadQuestions);
            this.Controls.Add(this.flpAnswers);
            this.Controls.Add(this.btnRandomQuestion);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.Text = "QuizApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuizForm_KeyDown);
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.flpAnswers.ResumeLayout(false);
            this.flpQuestion.ResumeLayout(false);
            this.flpQuestion.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.flpStatistics.ResumeLayout(false);
            this.panelTopScore.ResumeLayout(false);
            this.panelTopScore.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnLoadQuestions;
        private System.Windows.Forms.Label lblCountQuestions;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnRandomQuestion;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Label testField01;
        private System.Windows.Forms.Label testField03;
        private System.Windows.Forms.Label testField02;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.FlowLayoutPanel flpAnswers;
        private System.Windows.Forms.FlowLayoutPanel flpQuestion;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelTopScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMinimizeApp;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.FlowLayoutPanel flpStatistics;
        private System.Windows.Forms.Label lblResultCounter;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblCorrectAnswersCounter;
        private System.Windows.Forms.Label lblIncorrectAnswers;
        private System.Windows.Forms.Label lblIncorrectAnswersCounter;
        private System.Windows.Forms.Label lblAnsweredQuestions;
        private System.Windows.Forms.Label lblAnsweredQuestionsCounter;
        private System.Windows.Forms.Label lblLeftQuestions;
        private System.Windows.Forms.Label lblLeftQuestionsCounter;
        private System.Windows.Forms.Label lblAllQuestions;
        private System.Windows.Forms.Label lblAllQuestionsCounter;
    }
}

