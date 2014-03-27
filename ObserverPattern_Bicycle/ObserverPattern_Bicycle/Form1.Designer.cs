namespace ObserverPattern_Bicycle
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
            this.bChangeSpeed = new System.Windows.Forms.Button();
            this.gbRpm = new System.Windows.Forms.GroupBox();
            this.lRpm = new System.Windows.Forms.Label();
            this.gbCaloriesPerHour = new System.Windows.Forms.GroupBox();
            this.lCph = new System.Windows.Forms.Label();
            this.gbKmh = new System.Windows.Forms.GroupBox();
            this.lKmh = new System.Windows.Forms.Label();
            this.nChangeSpeed = new System.Windows.Forms.NumericUpDown();
            this.gbRpm.SuspendLayout();
            this.gbCaloriesPerHour.SuspendLayout();
            this.gbKmh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nChangeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // bChangeSpeed
            // 
            this.bChangeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangeSpeed.Location = new System.Drawing.Point(13, 49);
            this.bChangeSpeed.Name = "bChangeSpeed";
            this.bChangeSpeed.Size = new System.Drawing.Size(310, 53);
            this.bChangeSpeed.TabIndex = 0;
            this.bChangeSpeed.Text = "Change Speed";
            this.bChangeSpeed.UseVisualStyleBackColor = true;
            this.bChangeSpeed.Click += new System.EventHandler(this.bChangeSpeed_Click);
            // 
            // gbRpm
            // 
            this.gbRpm.Controls.Add(this.lRpm);
            this.gbRpm.Location = new System.Drawing.Point(13, 108);
            this.gbRpm.Name = "gbRpm";
            this.gbRpm.Size = new System.Drawing.Size(310, 100);
            this.gbRpm.TabIndex = 2;
            this.gbRpm.TabStop = false;
            this.gbRpm.Text = "RPM";
            // 
            // lRpm
            // 
            this.lRpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRpm.Location = new System.Drawing.Point(6, 16);
            this.lRpm.Name = "lRpm";
            this.lRpm.Size = new System.Drawing.Size(298, 81);
            this.lRpm.TabIndex = 0;
            this.lRpm.Text = "0.0";
            this.lRpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCaloriesPerHour
            // 
            this.gbCaloriesPerHour.Controls.Add(this.lCph);
            this.gbCaloriesPerHour.Location = new System.Drawing.Point(13, 214);
            this.gbCaloriesPerHour.Name = "gbCaloriesPerHour";
            this.gbCaloriesPerHour.Size = new System.Drawing.Size(310, 100);
            this.gbCaloriesPerHour.TabIndex = 3;
            this.gbCaloriesPerHour.TabStop = false;
            this.gbCaloriesPerHour.Text = "Calories Per Hour";
            // 
            // lCph
            // 
            this.lCph.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCph.Location = new System.Drawing.Point(6, 16);
            this.lCph.Name = "lCph";
            this.lCph.Size = new System.Drawing.Size(298, 81);
            this.lCph.TabIndex = 0;
            this.lCph.Text = "0.0";
            this.lCph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbKmh
            // 
            this.gbKmh.Controls.Add(this.lKmh);
            this.gbKmh.Location = new System.Drawing.Point(13, 320);
            this.gbKmh.Name = "gbKmh";
            this.gbKmh.Size = new System.Drawing.Size(310, 100);
            this.gbKmh.TabIndex = 3;
            this.gbKmh.TabStop = false;
            this.gbKmh.Text = "KM/H";
            // 
            // lKmh
            // 
            this.lKmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKmh.Location = new System.Drawing.Point(6, 16);
            this.lKmh.Name = "lKmh";
            this.lKmh.Size = new System.Drawing.Size(298, 81);
            this.lKmh.TabIndex = 0;
            this.lKmh.Text = "0.0";
            this.lKmh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nChangeSpeed
            // 
            this.nChangeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nChangeSpeed.Location = new System.Drawing.Point(13, 12);
            this.nChangeSpeed.Name = "nChangeSpeed";
            this.nChangeSpeed.Size = new System.Drawing.Size(310, 31);
            this.nChangeSpeed.TabIndex = 4;
            this.nChangeSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 443);
            this.Controls.Add(this.nChangeSpeed);
            this.Controls.Add(this.gbKmh);
            this.Controls.Add(this.gbCaloriesPerHour);
            this.Controls.Add(this.gbRpm);
            this.Controls.Add(this.bChangeSpeed);
            this.Name = "Form1";
            this.Text = "Bicycle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRpm.ResumeLayout(false);
            this.gbCaloriesPerHour.ResumeLayout(false);
            this.gbKmh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nChangeSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bChangeSpeed;
        private System.Windows.Forms.GroupBox gbRpm;
        private System.Windows.Forms.Label lRpm;
        private System.Windows.Forms.GroupBox gbCaloriesPerHour;
        private System.Windows.Forms.Label lCph;
        private System.Windows.Forms.GroupBox gbKmh;
        private System.Windows.Forms.Label lKmh;
        private System.Windows.Forms.NumericUpDown nChangeSpeed;
    }
}

