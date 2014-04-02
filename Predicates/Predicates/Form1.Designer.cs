namespace Predicates
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
            this.bEvenNumbers = new System.Windows.Forms.Button();
            this.lbSource = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.bLessThanTen = new System.Windows.Forms.Button();
            this.lSource = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEvenNumbers
            // 
            this.bEvenNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEvenNumbers.Location = new System.Drawing.Point(13, 13);
            this.bEvenNumbers.Name = "bEvenNumbers";
            this.bEvenNumbers.Size = new System.Drawing.Size(165, 63);
            this.bEvenNumbers.TabIndex = 0;
            this.bEvenNumbers.Text = "Even Numbers";
            this.bEvenNumbers.UseVisualStyleBackColor = true;
            this.bEvenNumbers.Click += new System.EventHandler(this.bEvenNumbers_Click);
            // 
            // lbSource
            // 
            this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.FormattingEnabled = true;
            this.lbSource.ItemHeight = 25;
            this.lbSource.Location = new System.Drawing.Point(13, 132);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(165, 229);
            this.lbSource.TabIndex = 1;
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 25;
            this.lbResult.Location = new System.Drawing.Point(185, 132);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(165, 229);
            this.lbResult.TabIndex = 2;
            // 
            // bLessThanTen
            // 
            this.bLessThanTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLessThanTen.Location = new System.Drawing.Point(185, 13);
            this.bLessThanTen.Name = "bLessThanTen";
            this.bLessThanTen.Size = new System.Drawing.Size(165, 63);
            this.bLessThanTen.TabIndex = 3;
            this.bLessThanTen.Text = "Numbers < 10";
            this.bLessThanTen.UseVisualStyleBackColor = true;
            this.bLessThanTen.Click += new System.EventHandler(this.bLessThanTen_Click);
            // 
            // lSource
            // 
            this.lSource.AutoSize = true;
            this.lSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSource.Location = new System.Drawing.Point(12, 104);
            this.lSource.Name = "lSource";
            this.lSource.Size = new System.Drawing.Size(80, 25);
            this.lSource.TabIndex = 4;
            this.lSource.Text = "Source";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(184, 104);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(73, 25);
            this.lResult.TabIndex = 5;
            this.lResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 378);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lSource);
            this.Controls.Add(this.bLessThanTen);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.bEvenNumbers);
            this.Name = "Form1";
            this.Text = "Predicates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEvenNumbers;
        private System.Windows.Forms.ListBox lbSource;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button bLessThanTen;
        private System.Windows.Forms.Label lSource;
        private System.Windows.Forms.Label lResult;
    }
}

