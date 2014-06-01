namespace charlal1.project.DiscreteEventSimulator
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
            this.dTPStartSimulationTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dTPEndSimulationTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbCalender = new System.Windows.Forms.GroupBox();
            this.lbCalender = new System.Windows.Forms.ListBox();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.lbOtherQueue = new System.Windows.Forms.ListBox();
            this.gbCarStereo = new System.Windows.Forms.GroupBox();
            this.lbCarStereoQueue = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCalender.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gbCarStereo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPStartSimulationTime
            // 
            this.dTPStartSimulationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStartSimulationTime.Location = new System.Drawing.Point(6, 19);
            this.dTPStartSimulationTime.Name = "dTPStartSimulationTime";
            this.dTPStartSimulationTime.Size = new System.Drawing.Size(200, 20);
            this.dTPStartSimulationTime.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPStartSimulationTime);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Simulation Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dTPEndSimulationTime);
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Simulation Time";
            // 
            // dTPEndSimulationTime
            // 
            this.dTPEndSimulationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPEndSimulationTime.Location = new System.Drawing.Point(6, 19);
            this.dTPEndSimulationTime.Name = "dTPEndSimulationTime";
            this.dTPEndSimulationTime.Size = new System.Drawing.Size(200, 20);
            this.dTPEndSimulationTime.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(13, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Simulation";
            // 
            // gbCalender
            // 
            this.gbCalender.Controls.Add(this.lbCalender);
            this.gbCalender.Location = new System.Drawing.Point(240, 13);
            this.gbCalender.Name = "gbCalender";
            this.gbCalender.Size = new System.Drawing.Size(328, 174);
            this.gbCalender.TabIndex = 5;
            this.gbCalender.TabStop = false;
            this.gbCalender.Text = "Calender";
            // 
            // lbCalender
            // 
            this.lbCalender.FormattingEnabled = true;
            this.lbCalender.Location = new System.Drawing.Point(7, 19);
            this.lbCalender.Name = "lbCalender";
            this.lbCalender.Size = new System.Drawing.Size(315, 147);
            this.lbCalender.TabIndex = 0;
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lbOtherQueue);
            this.gbOther.Location = new System.Drawing.Point(240, 193);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(161, 174);
            this.gbOther.TabIndex = 6;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other Queue";
            // 
            // lbOtherQueue
            // 
            this.lbOtherQueue.FormattingEnabled = true;
            this.lbOtherQueue.Location = new System.Drawing.Point(7, 19);
            this.lbOtherQueue.Name = "lbOtherQueue";
            this.lbOtherQueue.Size = new System.Drawing.Size(148, 147);
            this.lbOtherQueue.TabIndex = 0;
            // 
            // gbCarStereo
            // 
            this.gbCarStereo.Controls.Add(this.lbCarStereoQueue);
            this.gbCarStereo.Location = new System.Drawing.Point(407, 193);
            this.gbCarStereo.Name = "gbCarStereo";
            this.gbCarStereo.Size = new System.Drawing.Size(161, 174);
            this.gbCarStereo.TabIndex = 7;
            this.gbCarStereo.TabStop = false;
            this.gbCarStereo.Text = "Car Stereo Queue";
            // 
            // lbCarStereoQueue
            // 
            this.lbCarStereoQueue.FormattingEnabled = true;
            this.lbCarStereoQueue.Location = new System.Drawing.Point(7, 19);
            this.lbCarStereoQueue.Name = "lbCarStereoQueue";
            this.lbCarStereoQueue.Size = new System.Drawing.Size(148, 147);
            this.lbCarStereoQueue.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.gbCarStereo);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbCalender);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbCalender.ResumeLayout(false);
            this.gbOther.ResumeLayout(false);
            this.gbCarStereo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPStartSimulationTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dTPEndSimulationTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbCalender;
        private System.Windows.Forms.ListBox lbCalender;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.ListBox lbOtherQueue;
        private System.Windows.Forms.GroupBox gbCarStereo;
        private System.Windows.Forms.ListBox lbCarStereoQueue;
    }
}

