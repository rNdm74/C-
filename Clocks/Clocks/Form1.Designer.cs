namespace Clocks
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
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(411, 231);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(150, 150);
            this.analogClock.TabIndex = 0;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analogClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

