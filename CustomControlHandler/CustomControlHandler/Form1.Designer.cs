﻿namespace CustomControlHandler
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
            this.bTestHandlers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTestHandlers
            // 
            this.bTestHandlers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTestHandlers.Location = new System.Drawing.Point(13, 13);
            this.bTestHandlers.Name = "bTestHandlers";
            this.bTestHandlers.Size = new System.Drawing.Size(259, 236);
            this.bTestHandlers.TabIndex = 0;
            this.bTestHandlers.Text = "Test Handlers";
            this.bTestHandlers.UseVisualStyleBackColor = true;
            this.bTestHandlers.Click += new System.EventHandler(this.bTestHandlers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bTestHandlers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTestHandlers;
    }
}

