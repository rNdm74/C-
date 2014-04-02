namespace Delegates_Progress
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
            this.bStart = new System.Windows.Forms.Button();
            this.gbFeedBack = new System.Windows.Forms.GroupBox();
            this.rbSpinBox = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.gbFeedBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.gbDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(12, 12);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(517, 61);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // gbFeedBack
            // 
            this.gbFeedBack.Controls.Add(this.rbTrackBar);
            this.gbFeedBack.Controls.Add(this.rbProgressBar);
            this.gbFeedBack.Controls.Add(this.rbSpinBox);
            this.gbFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFeedBack.Location = new System.Drawing.Point(12, 79);
            this.gbFeedBack.Name = "gbFeedBack";
            this.gbFeedBack.Size = new System.Drawing.Size(213, 228);
            this.gbFeedBack.TabIndex = 1;
            this.gbFeedBack.TabStop = false;
            this.gbFeedBack.Text = "Feedback";
            // 
            // rbSpinBox
            // 
            this.rbSpinBox.AutoSize = true;
            this.rbSpinBox.Checked = true;
            this.rbSpinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpinBox.Location = new System.Drawing.Point(31, 48);
            this.rbSpinBox.Name = "rbSpinBox";
            this.rbSpinBox.Size = new System.Drawing.Size(116, 29);
            this.rbSpinBox.TabIndex = 0;
            this.rbSpinBox.TabStop = true;
            this.rbSpinBox.Text = "Spin Box";
            this.rbSpinBox.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProgressBar.Location = new System.Drawing.Point(31, 103);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(155, 29);
            this.rbProgressBar.TabIndex = 1;
            this.rbProgressBar.Text = "Progress Bar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrackBar.Location = new System.Drawing.Point(31, 157);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(123, 29);
            this.rbTrackBar.TabIndex = 2;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(6, 100);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(286, 32);
            this.pBar.TabIndex = 2;
            // 
            // nUpDown
            // 
            this.nUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown.Location = new System.Drawing.Point(6, 46);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(286, 31);
            this.nUpDown.TabIndex = 3;
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(6, 157);
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(286, 45);
            this.tBar.TabIndex = 4;
            // 
            // gbDisplay
            // 
            this.gbDisplay.Controls.Add(this.nUpDown);
            this.gbDisplay.Controls.Add(this.tBar);
            this.gbDisplay.Controls.Add(this.pBar);
            this.gbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisplay.Location = new System.Drawing.Point(231, 79);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(298, 228);
            this.gbDisplay.TabIndex = 5;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "Display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 319);
            this.Controls.Add(this.gbDisplay);
            this.Controls.Add(this.gbFeedBack);
            this.Controls.Add(this.bStart);
            this.Name = "Form1";
            this.Text = "Progress Inidcator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFeedBack.ResumeLayout(false);
            this.gbFeedBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.GroupBox gbFeedBack;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbSpinBox;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.GroupBox gbDisplay;
    }
}

