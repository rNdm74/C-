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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dTPStartSimulationTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dTPEndSimulationTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbCalender = new System.Windows.Forms.GroupBox();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.lbOtherQueue = new System.Windows.Forms.ListBox();
            this.gbCarStereo = new System.Windows.Forms.GroupBox();
            this.lbCarStereoQueue = new System.Windows.Forms.ListBox();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbStatisticsResults = new System.Windows.Forms.ListBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpDownMaxOther = new System.Windows.Forms.NumericUpDown();
            this.lSimulationSpeed = new System.Windows.Forms.Label();
            this.tbSimulationSpeed = new System.Windows.Forms.TrackBar();
            this.gbGraphicalDisplay = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSimulatorSpeed = new System.Windows.Forms.GroupBox();
            this.dgvCalender = new System.Windows.Forms.DataGridView();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginWait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCalender.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gbCarStereo.SuspendLayout();
            this.gbStatistics.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMaxOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimulationSpeed)).BeginInit();
            this.gbGraphicalDisplay.SuspendLayout();
            this.gbSimulatorSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dTPStartSimulationTime
            // 
            this.dTPStartSimulationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStartSimulationTime.Location = new System.Drawing.Point(6, 28);
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
            this.groupBox1.Size = new System.Drawing.Size(220, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Simulation Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dTPEndSimulationTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(239, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Simulation Time";
            // 
            // dTPEndSimulationTime
            // 
            this.dTPEndSimulationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPEndSimulationTime.Location = new System.Drawing.Point(6, 28);
            this.dTPEndSimulationTime.Name = "dTPEndSimulationTime";
            this.dTPEndSimulationTime.Size = new System.Drawing.Size(208, 26);
            this.dTPEndSimulationTime.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(776, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Simulation";
            // 
            // gbCalender
            // 
            this.gbCalender.Controls.Add(this.dgvCalender);
            this.gbCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalender.Location = new System.Drawing.Point(13, 88);
            this.gbCalender.Name = "gbCalender";
            this.gbCalender.Size = new System.Drawing.Size(650, 174);
            this.gbCalender.TabIndex = 5;
            this.gbCalender.TabStop = false;
            this.gbCalender.Text = "Calender";
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lbOtherQueue);
            this.gbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOther.Location = new System.Drawing.Point(836, 88);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(160, 174);
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
            this.lbOtherQueue.Size = new System.Drawing.Size(147, 144);
            this.lbOtherQueue.TabIndex = 0;
            // 
            // gbCarStereo
            // 
            this.gbCarStereo.Controls.Add(this.lbCarStereoQueue);
            this.gbCarStereo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarStereo.Location = new System.Drawing.Point(669, 88);
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
            this.gbStatistics.Controls.Add(this.dgvStatistics);
            this.gbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatistics.Location = new System.Drawing.Point(13, 268);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(650, 174);
            this.gbStatistics.TabIndex = 8;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Statistics";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbStatisticsResults);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(669, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 174);
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
            this.lbStatisticsResults.Size = new System.Drawing.Size(314, 144);
            this.lbStatisticsResults.TabIndex = 0;
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.numericUpDown1);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.nUpDownMaxOther);
            this.gbConfig.Controls.Add(this.lSimulationSpeed);
            this.gbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfig.Location = new System.Drawing.Point(798, 445);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(198, 272);
            this.gbConfig.TabIndex = 9;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Config";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resources Other";
            // 
            // nUpDownMaxOther
            // 
            this.nUpDownMaxOther.Location = new System.Drawing.Point(11, 56);
            this.nUpDownMaxOther.Name = "nUpDownMaxOther";
            this.nUpDownMaxOther.Size = new System.Drawing.Size(120, 26);
            this.nUpDownMaxOther.TabIndex = 2;
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
            // tbSimulationSpeed
            // 
            this.tbSimulationSpeed.Location = new System.Drawing.Point(6, 18);
            this.tbSimulationSpeed.Maximum = 3;
            this.tbSimulationSpeed.Name = "tbSimulationSpeed";
            this.tbSimulationSpeed.Size = new System.Drawing.Size(293, 45);
            this.tbSimulationSpeed.TabIndex = 0;
            this.tbSimulationSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // gbGraphicalDisplay
            // 
            this.gbGraphicalDisplay.Controls.Add(this.panel1);
            this.gbGraphicalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGraphicalDisplay.Location = new System.Drawing.Point(13, 445);
            this.gbGraphicalDisplay.Name = "gbGraphicalDisplay";
            this.gbGraphicalDisplay.Size = new System.Drawing.Size(779, 272);
            this.gbGraphicalDisplay.TabIndex = 10;
            this.gbGraphicalDisplay.TabStop = false;
            this.gbGraphicalDisplay.Text = "Graphical Display";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 247);
            this.panel1.TabIndex = 0;
            // 
            // gbSimulatorSpeed
            // 
            this.gbSimulatorSpeed.Controls.Add(this.tbSimulationSpeed);
            this.gbSimulatorSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSimulatorSpeed.Location = new System.Drawing.Point(465, 13);
            this.gbSimulatorSpeed.Name = "gbSimulatorSpeed";
            this.gbSimulatorSpeed.Size = new System.Drawing.Size(305, 69);
            this.gbSimulatorSpeed.TabIndex = 11;
            this.gbSimulatorSpeed.TabStop = false;
            this.gbSimulatorSpeed.Text = "Simulator Speed";
            // 
            // dgvCalender
            // 
            this.dgvCalender.AllowUserToAddRows = false;
            this.dgvCalender.AllowUserToDeleteRows = false;
            this.dgvCalender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalender.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCalender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalender.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entity,
            this.Event,
            this.EventTime,
            this.ProductType,
            this.StartTime,
            this.BeginWait});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalender.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCalender.EnableHeadersVisualStyles = false;
            this.dgvCalender.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCalender.Location = new System.Drawing.Point(6, 19);
            this.dgvCalender.Name = "dgvCalender";
            this.dgvCalender.ReadOnly = true;
            this.dgvCalender.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalender.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCalender.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCalender.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCalender.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCalender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalender.Size = new System.Drawing.Size(637, 149);
            this.dgvCalender.TabIndex = 0;
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStatistics.EnableHeadersVisualStyles = false;
            this.dgvStatistics.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStatistics.Location = new System.Drawing.Point(7, 22);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStatistics.RowHeadersVisible = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStatistics.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistics.Size = new System.Drawing.Size(637, 149);
            this.dgvStatistics.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Entity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Event";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Event Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Call Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Begin Wait";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Entity
            // 
            this.Entity.HeaderText = "Entity";
            this.Entity.Name = "Entity";
            this.Entity.ReadOnly = true;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "Event Time";
            this.EventTime.Name = "EventTime";
            this.EventTime.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Call Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // BeginWait
            // 
            this.BeginWait.HeaderText = "Begin Wait";
            this.BeginWait.Name = "BeginWait";
            this.BeginWait.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbSimulatorSpeed);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.gbGraphicalDisplay);
            this.Controls.Add(this.gbCalender);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.gbCarStereo);
            this.Controls.Add(this.gbOther);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMaxOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSimulationSpeed)).EndInit();
            this.gbGraphicalDisplay.ResumeLayout(false);
            this.gbSimulatorSpeed.ResumeLayout(false);
            this.gbSimulatorSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
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
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.ListBox lbOtherQueue;
        private System.Windows.Forms.GroupBox gbCarStereo;
        private System.Windows.Forms.ListBox lbCarStereoQueue;
        private System.Windows.Forms.GroupBox gbStatistics;
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
        private System.Windows.Forms.GroupBox gbSimulatorSpeed;
        private System.Windows.Forms.DataGridView dgvCalender;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginWait;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

