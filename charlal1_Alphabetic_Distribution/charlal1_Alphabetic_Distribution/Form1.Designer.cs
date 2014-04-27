namespace charlal1_Alphabetic_Distribution
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.bLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lTotalChars = new System.Windows.Forms.Label();
            this.lMaxChar = new System.Windows.Forms.Label();
            this.lFilename = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 25;
            this.lbResult.Location = new System.Drawing.Point(6, 25);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(135, 279);
            this.lbResult.TabIndex = 0;
            // 
            // bLoadFile
            // 
            this.bLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoadFile.Location = new System.Drawing.Point(166, 331);
            this.bLoadFile.Name = "bLoadFile";
            this.bLoadFile.Size = new System.Drawing.Size(200, 98);
            this.bLoadFile.TabIndex = 3;
            this.bLoadFile.Text = "Attach Text File";
            this.bLoadFile.UseVisualStyleBackColor = true;
            this.bLoadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 310);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribution";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lTotalChars);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(166, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Chars";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lMaxChar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(166, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max Char";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lFilename);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filename";
            // 
            // lTotalChars
            // 
            this.lTotalChars.AutoSize = true;
            this.lTotalChars.Location = new System.Drawing.Point(86, 43);
            this.lTotalChars.Name = "lTotalChars";
            this.lTotalChars.Size = new System.Drawing.Size(24, 25);
            this.lTotalChars.TabIndex = 0;
            this.lTotalChars.Text = "0";
            // 
            // lMaxChar
            // 
            this.lMaxChar.AutoSize = true;
            this.lMaxChar.Location = new System.Drawing.Point(86, 48);
            this.lMaxChar.Name = "lMaxChar";
            this.lMaxChar.Size = new System.Drawing.Size(0, 25);
            this.lMaxChar.TabIndex = 1;
            // 
            // lFilename
            // 
            this.lFilename.AutoSize = true;
            this.lFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilename.Location = new System.Drawing.Point(6, 48);
            this.lFilename.Name = "lFilename";
            this.lFilename.Size = new System.Drawing.Size(0, 20);
            this.lFilename.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 440);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bLoadFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Char Distribution";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button bLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lTotalChars;
        private System.Windows.Forms.Label lMaxChar;
        private System.Windows.Forms.Label lFilename;
    }
}

