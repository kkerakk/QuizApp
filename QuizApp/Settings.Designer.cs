namespace QuizApp
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnChangeColor01 = new System.Windows.Forms.Button();
            this.btnChangeColor02 = new System.Windows.Forms.Button();
            this.btnChangeColor03 = new System.Windows.Forms.Button();
            this.btnChangeColor04 = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.flpUIColorButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUIColorButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lblPath.Location = new System.Drawing.Point(12, 83);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(274, 16);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Ścieżka do pliku z pytaniami(w formacie .csv)";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPath.Location = new System.Drawing.Point(15, 102);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(505, 35);
            this.txtPath.TabIndex = 2;
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnPath.FlatAppearance.BorderSize = 0;
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Image = ((System.Drawing.Image)(resources.GetObject("btnPath.Image")));
            this.btnPath.Location = new System.Drawing.Point(538, 102);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(35, 35);
            this.btnPath.TabIndex = 3;
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnChangeColor01
            // 
            this.btnChangeColor01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnChangeColor01.FlatAppearance.BorderSize = 0;
            this.btnChangeColor01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeColor01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnChangeColor01.Location = new System.Drawing.Point(8, 8);
            this.btnChangeColor01.Name = "btnChangeColor01";
            this.btnChangeColor01.Size = new System.Drawing.Size(115, 40);
            this.btnChangeColor01.TabIndex = 4;
            this.btnChangeColor01.Text = "Klasyczny";
            this.btnChangeColor01.UseVisualStyleBackColor = false;
            this.btnChangeColor01.Click += new System.EventHandler(this.btnChangeColor01_Click);
            // 
            // btnChangeColor02
            // 
            this.btnChangeColor02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnChangeColor02.FlatAppearance.BorderSize = 0;
            this.btnChangeColor02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeColor02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnChangeColor02.Location = new System.Drawing.Point(129, 8);
            this.btnChangeColor02.Name = "btnChangeColor02";
            this.btnChangeColor02.Size = new System.Drawing.Size(115, 40);
            this.btnChangeColor02.TabIndex = 5;
            this.btnChangeColor02.Text = "Ciemny";
            this.btnChangeColor02.UseVisualStyleBackColor = false;
            this.btnChangeColor02.Click += new System.EventHandler(this.btnChangeColor02_Click);
            // 
            // btnChangeColor03
            // 
            this.btnChangeColor03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnChangeColor03.FlatAppearance.BorderSize = 0;
            this.btnChangeColor03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeColor03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnChangeColor03.Location = new System.Drawing.Point(250, 8);
            this.btnChangeColor03.Name = "btnChangeColor03";
            this.btnChangeColor03.Size = new System.Drawing.Size(115, 40);
            this.btnChangeColor03.TabIndex = 6;
            this.btnChangeColor03.Text = "Jasny";
            this.btnChangeColor03.UseVisualStyleBackColor = false;
            // 
            // btnChangeColor04
            // 
            this.btnChangeColor04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnChangeColor04.FlatAppearance.BorderSize = 0;
            this.btnChangeColor04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeColor04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.btnChangeColor04.Location = new System.Drawing.Point(371, 8);
            this.btnChangeColor04.Name = "btnChangeColor04";
            this.btnChangeColor04.Size = new System.Drawing.Size(115, 40);
            this.btnChangeColor04.TabIndex = 7;
            this.btnChangeColor04.Text = "Nieokreślony";
            this.btnChangeColor04.UseVisualStyleBackColor = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(583, 1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(27, 27);
            this.btnCloseApp.TabIndex = 12;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // flpUIColorButtons
            // 
            this.flpUIColorButtons.Controls.Add(this.btnChangeColor01);
            this.flpUIColorButtons.Controls.Add(this.btnChangeColor02);
            this.flpUIColorButtons.Controls.Add(this.btnChangeColor03);
            this.flpUIColorButtons.Controls.Add(this.btnChangeColor04);
            this.flpUIColorButtons.Location = new System.Drawing.Point(15, 12);
            this.flpUIColorButtons.Name = "flpUIColorButtons";
            this.flpUIColorButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flpUIColorButtons.Size = new System.Drawing.Size(505, 56);
            this.flpUIColorButtons.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(611, 342);
            this.Controls.Add(this.flpUIColorButtons);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.flpUIColorButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnChangeColor01;
        private System.Windows.Forms.Button btnChangeColor02;
        private System.Windows.Forms.Button btnChangeColor03;
        private System.Windows.Forms.Button btnChangeColor04;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.FlowLayoutPanel flpUIColorButtons;
    }
}