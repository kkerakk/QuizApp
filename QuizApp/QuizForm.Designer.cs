namespace QuizApp
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
            this.btnRandomQuestion = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.flpAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.flpDebug = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDebugCorrectAnswer = new System.Windows.Forms.Label();
            this.lblDebugCorrectAnswerCounter = new System.Windows.Forms.Label();
            this.lblTest01 = new System.Windows.Forms.Label();
            this.lblTestCounter01 = new System.Windows.Forms.Label();
            this.btnLoadQuestions = new System.Windows.Forms.Button();
            this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblCorrectAnswersCounter = new System.Windows.Forms.Label();
            this.lblIncorrectAnswers = new System.Windows.Forms.Label();
            this.lblIncorrectAnswersCounter = new System.Windows.Forms.Label();
            this.lblAnsweredQuestions = new System.Windows.Forms.Label();
            this.lblAnsweredQuestionsCounter = new System.Windows.Forms.Label();
            this.lblLeftQuestions = new System.Windows.Forms.Label();
            this.lblLeftQuestionsCounter = new System.Windows.Forms.Label();
            this.lblAllQuestions = new System.Windows.Forms.Label();
            this.lblAllQuestionsCounter = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelTopScore = new System.Windows.Forms.Panel();
            this.pbCompleted = new System.Windows.Forms.ProgressBar();
            this.lblProgressCounter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpTime = new System.Windows.Forms.FlowLayoutPanel();
            this.flpResult = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpOrdinalNr = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSummaryCounter = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.flpAnswers.SuspendLayout();
            this.flpQuestion.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.flpDebug.SuspendLayout();
            this.flpStatistics.SuspendLayout();
            this.panelTopScore.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSummary.SuspendLayout();
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
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.lblProgress.Location = new System.Drawing.Point(69, 136);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(151, 31);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Text = "Ukończono";
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
            this.panelInfo.Controls.Add(this.flpDebug);
            this.panelInfo.Controls.Add(this.btnLoadQuestions);
            this.panelInfo.Controls.Add(this.flpStatistics);
            this.panelInfo.Controls.Add(this.btnSettings);
            this.panelInfo.Controls.Add(this.panelTopScore);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfo.Location = new System.Drawing.Point(802, 32);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(289, 753);
            this.panelInfo.TabIndex = 15;
            // 
            // flpDebug
            // 
            this.flpDebug.Controls.Add(this.lblDebugCorrectAnswer);
            this.flpDebug.Controls.Add(this.lblDebugCorrectAnswerCounter);
            this.flpDebug.Controls.Add(this.lblTest01);
            this.flpDebug.Controls.Add(this.lblTestCounter01);
            this.flpDebug.Controls.Add(this.btnTest);
            this.flpDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDebug.Location = new System.Drawing.Point(0, 358);
            this.flpDebug.Name = "flpDebug";
            this.flpDebug.Padding = new System.Windows.Forms.Padding(2);
            this.flpDebug.Size = new System.Drawing.Size(289, 142);
            this.flpDebug.TabIndex = 16;
            // 
            // lblDebugCorrectAnswer
            // 
            this.lblDebugCorrectAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebugCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDebugCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDebugCorrectAnswer.Location = new System.Drawing.Point(5, 2);
            this.lblDebugCorrectAnswer.Name = "lblDebugCorrectAnswer";
            this.lblDebugCorrectAnswer.Size = new System.Drawing.Size(230, 27);
            this.lblDebugCorrectAnswer.TabIndex = 26;
            this.lblDebugCorrectAnswer.Text = "Prawidłowa odpowiedź";
            this.lblDebugCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDebugCorrectAnswerCounter
            // 
            this.lblDebugCorrectAnswerCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebugCorrectAnswerCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDebugCorrectAnswerCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDebugCorrectAnswerCounter.Location = new System.Drawing.Point(241, 2);
            this.lblDebugCorrectAnswerCounter.Name = "lblDebugCorrectAnswerCounter";
            this.lblDebugCorrectAnswerCounter.Size = new System.Drawing.Size(42, 27);
            this.lblDebugCorrectAnswerCounter.TabIndex = 27;
            this.lblDebugCorrectAnswerCounter.Text = "0";
            this.lblDebugCorrectAnswerCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTest01
            // 
            this.lblTest01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTest01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTest01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTest01.Location = new System.Drawing.Point(5, 29);
            this.lblTest01.Name = "lblTest01";
            this.lblTest01.Size = new System.Drawing.Size(230, 27);
            this.lblTest01.TabIndex = 28;
            this.lblTest01.Text = "Prawidłowa odpowiedź";
            this.lblTest01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCounter01
            // 
            this.lblTestCounter01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTestCounter01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTestCounter01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTestCounter01.Location = new System.Drawing.Point(241, 29);
            this.lblTestCounter01.Name = "lblTestCounter01";
            this.lblTestCounter01.Size = new System.Drawing.Size(42, 27);
            this.lblTestCounter01.TabIndex = 29;
            this.lblTestCounter01.Text = "0";
            this.lblTestCounter01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoadQuestions
            // 
            this.btnLoadQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnLoadQuestions.FlatAppearance.BorderSize = 0;
            this.btnLoadQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnLoadQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadQuestions.Location = new System.Drawing.Point(34, 607);
            this.btnLoadQuestions.Name = "btnLoadQuestions";
            this.btnLoadQuestions.Size = new System.Drawing.Size(219, 50);
            this.btnLoadQuestions.TabIndex = 15;
            this.btnLoadQuestions.Text = "Załaduj pytania";
            this.btnLoadQuestions.UseVisualStyleBackColor = false;
            this.btnLoadQuestions.Click += new System.EventHandler(this.btnLoadQuestions_Click);
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
            this.flpStatistics.Size = new System.Drawing.Size(289, 142);
            this.flpStatistics.TabIndex = 14;
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
            this.lblCorrectAnswersCounter.Text = "0";
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
            this.lblIncorrectAnswersCounter.Text = "0";
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
            this.lblAnsweredQuestionsCounter.Text = "0";
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
            // lblLeftQuestionsCounter
            // 
            this.lblLeftQuestionsCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeftQuestionsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeftQuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblLeftQuestionsCounter.Location = new System.Drawing.Point(241, 83);
            this.lblLeftQuestionsCounter.Name = "lblLeftQuestionsCounter";
            this.lblLeftQuestionsCounter.Size = new System.Drawing.Size(42, 27);
            this.lblLeftQuestionsCounter.TabIndex = 33;
            this.lblLeftQuestionsCounter.Text = "0";
            this.lblLeftQuestionsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblAllQuestionsCounter
            // 
            this.lblAllQuestionsCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAllQuestionsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAllQuestionsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblAllQuestionsCounter.Location = new System.Drawing.Point(241, 110);
            this.lblAllQuestionsCounter.Name = "lblAllQuestionsCounter";
            this.lblAllQuestionsCounter.Size = new System.Drawing.Size(42, 27);
            this.lblAllQuestionsCounter.TabIndex = 35;
            this.lblAllQuestionsCounter.Text = "0";
            this.lblAllQuestionsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(34, 663);
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
            this.panelTopScore.Controls.Add(this.pbCompleted);
            this.panelTopScore.Controls.Add(this.lblProgressCounter);
            this.panelTopScore.Controls.Add(this.lblProgress);
            this.panelTopScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopScore.Location = new System.Drawing.Point(0, 0);
            this.panelTopScore.Name = "panelTopScore";
            this.panelTopScore.Size = new System.Drawing.Size(289, 216);
            this.panelTopScore.TabIndex = 11;
            // 
            // pbCompleted
            // 
            this.pbCompleted.BackColor = System.Drawing.Color.Red;
            this.pbCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCompleted.Location = new System.Drawing.Point(0, 0);
            this.pbCompleted.Margin = new System.Windows.Forms.Padding(0);
            this.pbCompleted.Name = "pbCompleted";
            this.pbCompleted.Size = new System.Drawing.Size(289, 8);
            this.pbCompleted.TabIndex = 21;
            // 
            // lblProgressCounter
            // 
            this.lblProgressCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgressCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProgressCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblProgressCounter.Location = new System.Drawing.Point(5, 63);
            this.lblProgressCounter.Name = "lblProgressCounter";
            this.lblProgressCounter.Size = new System.Drawing.Size(278, 73);
            this.lblProgressCounter.TabIndex = 20;
            this.lblProgressCounter.Text = "0,0%";
            this.lblProgressCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panelSummary.Controls.Add(this.flowLayoutPanel1);
            this.panelSummary.Controls.Add(this.label3);
            this.panelSummary.Controls.Add(this.flpTime);
            this.panelSummary.Controls.Add(this.flpResult);
            this.panelSummary.Controls.Add(this.flowLayoutPanel2);
            this.panelSummary.Controls.Add(this.flpOrdinalNr);
            this.panelSummary.Controls.Add(this.label5);
            this.panelSummary.Controls.Add(this.label4);
            this.panelSummary.Controls.Add(this.flpName);
            this.panelSummary.Controls.Add(this.label2);
            this.panelSummary.Controls.Add(this.panel2);
            this.panelSummary.Controls.Add(this.lblSummaryCounter);
            this.panelSummary.Controls.Add(this.lblSummary);
            this.panelSummary.Location = new System.Drawing.Point(0, 32);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(801, 753);
            this.panelSummary.TabIndex = 18;
            this.panelSummary.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(631, 284);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 457);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(654, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 40);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpTime
            // 
            this.flpTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.flpTime.Location = new System.Drawing.Point(485, 284);
            this.flpTime.Name = "flpTime";
            this.flpTime.Size = new System.Drawing.Size(140, 457);
            this.flpTime.TabIndex = 31;
            // 
            // flpResult
            // 
            this.flpResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.flpResult.Location = new System.Drawing.Point(339, 284);
            this.flpResult.Name = "flpResult";
            this.flpResult.Size = new System.Drawing.Size(140, 457);
            this.flpResult.TabIndex = 30;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(76, 284);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(257, 457);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // flpOrdinalNr
            // 
            this.flpOrdinalNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.flpOrdinalNr.Location = new System.Drawing.Point(25, 284);
            this.flpOrdinalNr.Name = "flpOrdinalNr";
            this.flpOrdinalNr.Size = new System.Drawing.Size(36, 457);
            this.flpOrdinalNr.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(367, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = "Czas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(506, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 26;
            this.label4.Text = "Wynik";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpName
            // 
            this.flpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.flpName.Location = new System.Drawing.Point(145, 229);
            this.flpName.Name = "flpName";
            this.flpName.Size = new System.Drawing.Size(105, 40);
            this.flpName.TabIndex = 25;
            this.flpName.Text = "Nazwa";
            this.flpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 40);
            this.label2.TabIndex = 24;
            this.label2.Text = "L.P.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.panel2.Location = new System.Drawing.Point(21, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 5);
            this.panel2.TabIndex = 23;
            // 
            // lblSummaryCounter
            // 
            this.lblSummaryCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSummaryCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSummaryCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.lblSummaryCounter.Location = new System.Drawing.Point(278, 106);
            this.lblSummaryCounter.Name = "lblSummaryCounter";
            this.lblSummaryCounter.Size = new System.Drawing.Size(278, 73);
            this.lblSummaryCounter.TabIndex = 22;
            this.lblSummaryCounter.Text = "0,0%";
            this.lblSummaryCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.lblSummary.Location = new System.Drawing.Point(18, 20);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(764, 73);
            this.lblSummary.TabIndex = 21;
            this.lblSummary.Text = "Twój wynik to:";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(5, 59);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(219, 50);
            this.btnTest.TabIndex = 30;
            this.btnTest.Text = "Zmiana koloru";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1091, 785);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flpQuestion);
            this.Controls.Add(this.flpAnswers);
            this.Controls.Add(this.btnRandomQuestion);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.Text = "QuizApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuizForm_KeyDown);
            this.flpAnswers.ResumeLayout(false);
            this.flpQuestion.ResumeLayout(false);
            this.flpQuestion.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.flpDebug.ResumeLayout(false);
            this.flpStatistics.ResumeLayout(false);
            this.panelTopScore.ResumeLayout(false);
            this.panelTopScore.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnRandomQuestion;
        private System.Windows.Forms.Label lblProgress;
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
        private System.Windows.Forms.Label lblProgressCounter;
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
        private System.Windows.Forms.Button btnLoadQuestions;
        private System.Windows.Forms.FlowLayoutPanel flpDebug;
        private System.Windows.Forms.Label lblDebugCorrectAnswer;
        private System.Windows.Forms.Label lblDebugCorrectAnswerCounter;
        private System.Windows.Forms.ProgressBar pbCompleted;
        private System.Windows.Forms.Label lblTest01;
        private System.Windows.Forms.Label lblTestCounter01;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSummaryCounter;
        private System.Windows.Forms.FlowLayoutPanel flpOrdinalNr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label flpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpTime;
        private System.Windows.Forms.FlowLayoutPanel flpResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
    }
}

