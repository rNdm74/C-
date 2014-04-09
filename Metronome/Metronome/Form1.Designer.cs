namespace Metronome
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
            this.bStartMetronome = new System.Windows.Forms.Button();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            this.gbCounter = new System.Windows.Forms.GroupBox();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.lTime = new System.Windows.Forms.Label();
            this.gbInterval.SuspendLayout();
            this.gbCounter.SuspendLayout();
            this.gbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bStartMetronome
            // 
            this.bStartMetronome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStartMetronome.Location = new System.Drawing.Point(12, 271);
            this.bStartMetronome.Name = "bStartMetronome";
            this.bStartMetronome.Size = new System.Drawing.Size(303, 49);
            this.bStartMetronome.TabIndex = 0;
            this.bStartMetronome.Text = "Start Metronome";
            this.bStartMetronome.UseVisualStyleBackColor = true;
            this.bStartMetronome.Click += new System.EventHandler(this.bStartMetronome_Click);
            // 
            // gbInterval
            // 
            this.gbInterval.Controls.Add(this.tbInterval);
            this.gbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInterval.Location = new System.Drawing.Point(13, 13);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.Size = new System.Drawing.Size(302, 76);
            this.gbInterval.TabIndex = 1;
            this.gbInterval.TabStop = false;
            this.gbInterval.Text = "Interval";
            // 
            // gbCounter
            // 
            this.gbCounter.Controls.Add(this.nUpDown);
            this.gbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCounter.Location = new System.Drawing.Point(13, 95);
            this.gbCounter.Name = "gbCounter";
            this.gbCounter.Size = new System.Drawing.Size(302, 76);
            this.gbCounter.TabIndex = 2;
            this.gbCounter.TabStop = false;
            this.gbCounter.Text = "Counter";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.lTime);
            this.gbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.Location = new System.Drawing.Point(13, 177);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(302, 76);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // tbInterval
            // 
            this.tbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterval.Location = new System.Drawing.Point(7, 30);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(289, 31);
            this.tbInterval.TabIndex = 0;
            this.tbInterval.Text = "1000";
            // 
            // nUpDown
            // 
            this.nUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown.Location = new System.Drawing.Point(7, 30);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(289, 31);
            this.nUpDown.TabIndex = 0;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(6, 37);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 25);
            this.lTime.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 332);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbCounter);
            this.Controls.Add(this.gbInterval);
            this.Controls.Add(this.bStartMetronome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInterval.ResumeLayout(false);
            this.gbInterval.PerformLayout();
            this.gbCounter.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStartMetronome;
        private System.Windows.Forms.GroupBox gbInterval;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.GroupBox gbCounter;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label lTime;
    }
}

