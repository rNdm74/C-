namespace charlal1_Astro_Sign
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
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rbWestern = new System.Windows.Forms.RadioButton();
            this.rbChinese = new System.Windows.Forms.RadioButton();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.lAstroSign = new System.Windows.Forms.Label();
            this.lYourSign = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.bGetSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(32, 54);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(341, 29);
            this.dtpBirthDate.TabIndex = 0;
            // 
            // rbWestern
            // 
            this.rbWestern.AutoSize = true;
            this.rbWestern.Checked = true;
            this.rbWestern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWestern.Location = new System.Drawing.Point(32, 140);
            this.rbWestern.Name = "rbWestern";
            this.rbWestern.Size = new System.Drawing.Size(110, 29);
            this.rbWestern.TabIndex = 1;
            this.rbWestern.TabStop = true;
            this.rbWestern.Text = "Western";
            this.rbWestern.UseVisualStyleBackColor = true;
            // 
            // rbChinese
            // 
            this.rbChinese.AutoSize = true;
            this.rbChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChinese.Location = new System.Drawing.Point(148, 140);
            this.rbChinese.Name = "rbChinese";
            this.rbChinese.Size = new System.Drawing.Size(109, 29);
            this.rbChinese.TabIndex = 2;
            this.rbChinese.Text = "Chinese";
            this.rbChinese.UseVisualStyleBackColor = true;
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthDate.Location = new System.Drawing.Point(13, 13);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(164, 25);
            this.lBirthDate.TabIndex = 5;
            this.lBirthDate.Text = "Enter Birth Date";
            // 
            // lAstroSign
            // 
            this.lAstroSign.AutoSize = true;
            this.lAstroSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAstroSign.Location = new System.Drawing.Point(13, 99);
            this.lAstroSign.Name = "lAstroSign";
            this.lAstroSign.Size = new System.Drawing.Size(173, 25);
            this.lAstroSign.TabIndex = 6;
            this.lAstroSign.Text = "Astrological Sign";
            // 
            // lYourSign
            // 
            this.lYourSign.AutoSize = true;
            this.lYourSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYourSign.Location = new System.Drawing.Point(13, 192);
            this.lYourSign.Name = "lYourSign";
            this.lYourSign.Size = new System.Drawing.Size(107, 25);
            this.lYourSign.TabIndex = 7;
            this.lYourSign.Text = "Your Sign";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(27, 226);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 25);
            this.lResult.TabIndex = 8;
            // 
            // bGetSign
            // 
            this.bGetSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGetSign.Location = new System.Drawing.Point(248, 280);
            this.bGetSign.Name = "bGetSign";
            this.bGetSign.Size = new System.Drawing.Size(125, 42);
            this.bGetSign.TabIndex = 9;
            this.bGetSign.Text = "Get Sign";
            this.bGetSign.UseVisualStyleBackColor = true;
            this.bGetSign.Click += new System.EventHandler(this.bGetSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 334);
            this.Controls.Add(this.bGetSign);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lYourSign);
            this.Controls.Add(this.rbWestern);
            this.Controls.Add(this.rbChinese);
            this.Controls.Add(this.lAstroSign);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lBirthDate);
            this.Name = "Form1";
            this.Text = "Astrology Sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rbWestern;
        private System.Windows.Forms.RadioButton rbChinese;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.Label lAstroSign;
        private System.Windows.Forms.Label lYourSign;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Button bGetSign;
    }
}

