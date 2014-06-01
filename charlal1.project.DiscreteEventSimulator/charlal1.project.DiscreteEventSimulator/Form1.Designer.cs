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
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbStatisticsResults = new System.Windows.Forms.ListBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.tbSimulationSpeed = new System.Windows.Forms.TrackBar();
            this.lSimulationSpeed = new System.Windows.Forms.Label();
            this.gbGraphicalDisplay = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nUpDownMaxOther = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCalender.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gbCarStereo.SuspendLayout();
            this.gbStatistics.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimulationSpeed)).BeginInit();
            this.gbGraphicalDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMaxOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dTPStartSimulationTime
            // 
            this.dTPStartSimulationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStartSimulationTime.Location = new System.Drawing.Point(6, 19);
            this.dTPStartSimulationTime.Name = "dTPStartSimulationTime";
            this.dTPStartSimulationTime.Size = new System.Drawing.Size(208, 26);
            this.dTPStartSimulationTime.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPStartSimulationTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dTPEndSimulationTime.Size = new System.Drawing.Size(208, 26);
            this.dTPEndSimulationTime.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gbCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbCalender.ItemHeight = 20;
            this.lbCalender.Location = new System.Drawing.Point(7, 19);
            this.lbCalender.Name = "lbCalender";
            this.lbCalender.Size = new System.Drawing.Size(315, 144);
            this.lbCalender.TabIndex = 0;
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lbOtherQueue);
            this.gbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOther.Location = new System.Drawing.Point(264, 193);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(137, 174);
            this.gbOther.TabIndex = 6;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other Queue";
            // 
            // lbOtherQueue
            // 
            this.lbOtherQueue.FormattingEnabled = true;
            this.lbOtherQueue.ItemHeight = 20;
            this.lbOtherQueue.Location = new System.Drawing.Point(7, 19);
            this.lbOtherQueue.Name = "lbOtherQueue";
            this.lbOtherQueue.Size = new System.Drawing.Size(124, 144);
            this.lbOtherQueue.TabIndex = 0;
            // 
            // gbCarStereo
            // 
            this.gbCarStereo.Controls.Add(this.lbCarStereoQueue);
            this.gbCarStereo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbCarStereoQueue.ItemHeight = 20;
            this.lbCarStereoQueue.Location = new System.Drawing.Point(7, 19);
            this.lbCarStereoQueue.Name = "lbCarStereoQueue";
            this.lbCarStereoQueue.Size = new System.Drawing.Size(148, 144);
            this.lbCarStereoQueue.TabIndex = 0;
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lbStatistics);
            this.gbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatistics.Location = new System.Drawing.Point(13, 373);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(555, 234);
            this.gbStatistics.TabIndex = 8;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Statistics";
            // 
            // lbStatistics
            // 
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 20;
            this.lbStatistics.Location = new System.Drawing.Point(7, 19);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(542, 184);
            this.lbStatistics.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbStatisticsResults);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 174);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics Results";
            // 
            // lbStatisticsResults
            // 
            this.lbStatisticsResults.FormattingEnabled = true;
            this.lbStatisticsResults.ItemHeight = 20;
            this.lbStatisticsResults.Location = new System.Drawing.Point(7, 19);
            this.lbStatisticsResults.Name = "lbStatisticsResults";
            this.lbStatisticsResults.Size = new System.Drawing.Size(232, 144);
            this.lbStatisticsResults.TabIndex = 0;
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.numericUpDown1);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.nUpDownMaxOther);
            this.gbConfig.Controls.Add(this.lSimulationSpeed);
            this.gbConfig.Controls.Add(this.tbSimulationSpeed);
            this.gbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfig.Location = new System.Drawing.Point(575, 373);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(327, 234);
            this.gbConfig.TabIndex = 9;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Config";
            // 
            // tbSimulationSpeed
            // 
            this.tbSimulationSpeed.Location = new System.Drawing.Point(6, 173);
            this.tbSimulationSpeed.Maximum = 3;
            this.tbSimulationSpeed.Name = "tbSimulationSpeed";
            this.tbSimulationSpeed.Size = new System.Drawing.Size(315, 45);
            this.tbSimulationSpeed.TabIndex = 0;
            // 
            // lSimulationSpeed
            // 
            this.lSimulationSpeed.AutoSize = true;
            this.lSimulationSpeed.Location = new System.Drawing.Point(7, 154);
            this.lSimulationSpeed.Name = "lSimulationSpeed";
            this.lSimulationSpeed.Size = new System.Drawing.Size(134, 20);
            this.lSimulationSpeed.TabIndex = 1;
            this.lSimulationSpeed.Text = "Simulation Speed";
            // 
            // gbGraphicalDisplay
            // 
            this.gbGraphicalDisplay.Controls.Add(this.panel1);
            this.gbGraphicalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGraphicalDisplay.Location = new System.Drawing.Point(575, 13);
            this.gbGraphicalDisplay.Name = "gbGraphicalDisplay";
            this.gbGraphicalDisplay.Size = new System.Drawing.Size(327, 354);
            this.gbGraphicalDisplay.TabIndex = 10;
            this.gbGraphicalDisplay.TabStop = false;
            this.gbGraphicalDisplay.Text = "Graphical Display";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 327);
            this.panel1.TabIndex = 0;
            // 
            // nUpDownMaxOther
            // 
            this.nUpDownMaxOther.Location = new System.Drawing.Point(11, 56);
            this.nUpDownMaxOther.Name = "nUpDownMaxOther";
            this.nUpDownMaxOther.Size = new System.Drawing.Size(120, 26);
            this.nUpDownMaxOther.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resources Other";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resources Car Stereo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 108);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbGraphicalDisplay);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.gbCarStereo);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbCalender);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Discrete Event Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbCalender.ResumeLayout(false);
            this.gbOther.ResumeLayout(false);
            this.gbCarStereo.ResumeLayout(false);
            this.gbStatistics.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimulationSpeed)).EndInit();
            this.gbGraphicalDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMaxOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbStatisticsResults;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Label lSimulationSpeed;
        private System.Windows.Forms.TrackBar tbSimulationSpeed;
        private System.Windows.Forms.GroupBox gbGraphicalDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUpDownMaxOther;
    }
}

