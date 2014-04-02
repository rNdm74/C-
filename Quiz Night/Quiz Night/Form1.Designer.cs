namespace Quiz_Night
{
    partial class Form1
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
            this.bCalculate = new System.Windows.Forms.Button();
            this.gbAdultTeamScore = new System.Windows.Forms.GroupBox();
            this.gbTeamResult = new System.Windows.Forms.GroupBox();
            this.rbAdultTeam = new System.Windows.Forms.RadioButton();
            this.rbChildTeam = new System.Windows.Forms.RadioButton();
            this.nUpDownTeamScore = new System.Windows.Forms.NumericUpDown();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.nUpDownIncorrect = new System.Windows.Forms.NumericUpDown();
            this.lIncorrect = new System.Windows.Forms.Label();
            this.lCorrect = new System.Windows.Forms.Label();
            this.nUpDownCorrect = new System.Windows.Forms.NumericUpDown();
            this.gbAdultTeamScore.SuspendLayout();
            this.gbTeamResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTeamScore)).BeginInit();
            this.gbAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // bCalculate
            // 
            this.bCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.Location = new System.Drawing.Point(13, 13);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(398, 44);
            this.bCalculate.TabIndex = 0;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // gbAdultTeamScore
            // 
            this.gbAdultTeamScore.Controls.Add(this.nUpDownTeamScore);
            this.gbAdultTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdultTeamScore.Location = new System.Drawing.Point(211, 72);
            this.gbAdultTeamScore.Name = "gbAdultTeamScore";
            this.gbAdultTeamScore.Size = new System.Drawing.Size(200, 100);
            this.gbAdultTeamScore.TabIndex = 1;
            this.gbAdultTeamScore.TabStop = false;
            this.gbAdultTeamScore.Text = "Team Score";
            // 
            // gbTeamResult
            // 
            this.gbTeamResult.Controls.Add(this.rbChildTeam);
            this.gbTeamResult.Controls.Add(this.rbAdultTeam);
            this.gbTeamResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeamResult.Location = new System.Drawing.Point(13, 72);
            this.gbTeamResult.Name = "gbTeamResult";
            this.gbTeamResult.Size = new System.Drawing.Size(192, 100);
            this.gbTeamResult.TabIndex = 3;
            this.gbTeamResult.TabStop = false;
            this.gbTeamResult.Text = "Team Result";
            // 
            // rbAdultTeam
            // 
            this.rbAdultTeam.AutoSize = true;
            this.rbAdultTeam.Checked = true;
            this.rbAdultTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdultTeam.Location = new System.Drawing.Point(24, 30);
            this.rbAdultTeam.Name = "rbAdultTeam";
            this.rbAdultTeam.Size = new System.Drawing.Size(139, 29);
            this.rbAdultTeam.TabIndex = 0;
            this.rbAdultTeam.TabStop = true;
            this.rbAdultTeam.Text = "Adult Team";
            this.rbAdultTeam.UseVisualStyleBackColor = true;
            // 
            // rbChildTeam
            // 
            this.rbChildTeam.AutoSize = true;
            this.rbChildTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChildTeam.Location = new System.Drawing.Point(24, 59);
            this.rbChildTeam.Name = "rbChildTeam";
            this.rbChildTeam.Size = new System.Drawing.Size(139, 29);
            this.rbChildTeam.TabIndex = 1;
            this.rbChildTeam.Text = "Child Team";
            this.rbChildTeam.UseVisualStyleBackColor = true;
            // 
            // nUpDownTeamScore
            // 
            this.nUpDownTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownTeamScore.Location = new System.Drawing.Point(33, 40);
            this.nUpDownTeamScore.Name = "nUpDownTeamScore";
            this.nUpDownTeamScore.Size = new System.Drawing.Size(120, 31);
            this.nUpDownTeamScore.TabIndex = 0;
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.nUpDownIncorrect);
            this.gbAnswers.Controls.Add(this.lIncorrect);
            this.gbAnswers.Controls.Add(this.lCorrect);
            this.gbAnswers.Controls.Add(this.nUpDownCorrect);
            this.gbAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnswers.Location = new System.Drawing.Point(13, 177);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(192, 100);
            this.gbAnswers.TabIndex = 4;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Answers";
            // 
            // nUpDownIncorrect
            // 
            this.nUpDownIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownIncorrect.Location = new System.Drawing.Point(120, 58);
            this.nUpDownIncorrect.Name = "nUpDownIncorrect";
            this.nUpDownIncorrect.Size = new System.Drawing.Size(51, 31);
            this.nUpDownIncorrect.TabIndex = 9;
            // 
            // lIncorrect
            // 
            this.lIncorrect.AutoSize = true;
            this.lIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIncorrect.Location = new System.Drawing.Point(19, 60);
            this.lIncorrect.Name = "lIncorrect";
            this.lIncorrect.Size = new System.Drawing.Size(95, 25);
            this.lIncorrect.TabIndex = 8;
            this.lIncorrect.Text = "Incorrect";
            // 
            // lCorrect
            // 
            this.lCorrect.AutoSize = true;
            this.lCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorrect.Location = new System.Drawing.Point(19, 27);
            this.lCorrect.Name = "lCorrect";
            this.lCorrect.Size = new System.Drawing.Size(82, 25);
            this.lCorrect.TabIndex = 7;
            this.lCorrect.Text = "Correct";
            // 
            // nUpDownCorrect
            // 
            this.nUpDownCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownCorrect.Location = new System.Drawing.Point(120, 25);
            this.nUpDownCorrect.Name = "nUpDownCorrect";
            this.nUpDownCorrect.Size = new System.Drawing.Size(51, 31);
            this.nUpDownCorrect.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 289);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.gbTeamResult);
            this.Controls.Add(this.gbAdultTeamScore);
            this.Controls.Add(this.bCalculate);
            this.Name = "Form1";
            this.Text = "Quiz Night";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAdultTeamScore.ResumeLayout(false);
            this.gbTeamResult.ResumeLayout(false);
            this.gbTeamResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTeamScore)).EndInit();
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCorrect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.GroupBox gbAdultTeamScore;
        private System.Windows.Forms.NumericUpDown nUpDownTeamScore;
        private System.Windows.Forms.GroupBox gbTeamResult;
        private System.Windows.Forms.RadioButton rbChildTeam;
        private System.Windows.Forms.RadioButton rbAdultTeam;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.NumericUpDown nUpDownIncorrect;
        private System.Windows.Forms.Label lIncorrect;
        private System.Windows.Forms.Label lCorrect;
        private System.Windows.Forms.NumericUpDown nUpDownCorrect;
    }
}

