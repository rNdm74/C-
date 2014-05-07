namespace charlal1.XML.PubsAndClubs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Band = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMonth = new System.Windows.Forms.Label();
            this.rbThisMonth = new System.Windows.Forms.RadioButton();
            this.rbAllMonths = new System.Windows.Forms.RadioButton();
            this.lGenre = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbEvent = new System.Windows.Forms.GroupBox();
            this.lBandGenre = new System.Windows.Forms.Label();
            this.tbBandGenre = new System.Windows.Forms.TextBox();
            this.lEventName = new System.Windows.Forms.Label();
            this.bAddEvent = new System.Windows.Forms.Button();
            this.lBandName = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.tbBandName = new System.Windows.Forms.TextBox();
            this.lAgeLimit = new System.Windows.Forms.Label();
            this.lEndTime = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lCoverPrice = new System.Windows.Forms.Label();
            this.lStartTime = new System.Windows.Forms.Label();
            this.tbClubName = new System.Windows.Forms.TextBox();
            this.tbClubAddress = new System.Windows.Forms.TextBox();
            this.tbCoverPrice = new System.Windows.Forms.TextBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lClubName = new System.Windows.Forms.Label();
            this.nUpDownAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.rbAddEvent = new System.Windows.Forms.RadioButton();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAgeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToOrderColumns = true;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.Date,
            this.StartTime,
            this.EndTime,
            this.CoverPrice,
            this.AgeLimit,
            this.Club,
            this.ClubAddress,
            this.Band,
            this.BandGenre});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplay.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplay.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDisplay.RowHeadersVisible = false;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(1011, 305);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // Event
            // 
            this.Event.HeaderText = "Event Name";
            this.Event.Name = "Event";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            // 
            // CoverPrice
            // 
            this.CoverPrice.HeaderText = "Cover Price";
            this.CoverPrice.Name = "CoverPrice";
            // 
            // AgeLimit
            // 
            this.AgeLimit.HeaderText = "Age Limit";
            this.AgeLimit.Name = "AgeLimit";
            // 
            // Club
            // 
            this.Club.HeaderText = "Club Name";
            this.Club.Name = "Club";
            // 
            // ClubAddress
            // 
            this.ClubAddress.HeaderText = "Club Address";
            this.ClubAddress.Name = "ClubAddress";
            // 
            // Band
            // 
            this.Band.HeaderText = "Band Name";
            this.Band.Name = "Band";
            // 
            // BandGenre
            // 
            this.BandGenre.HeaderText = "Band Genre";
            this.BandGenre.Name = "BandGenre";
            // 
            // cbGenres
            // 
            this.cbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Items.AddRange(new object[] {
            "All Genres"});
            this.cbGenres.Location = new System.Drawing.Point(180, 37);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(302, 28);
            this.cbGenres.TabIndex = 2;
            this.cbGenres.Text = "All Genres";
            this.cbGenres.SelectedValueChanged += new System.EventHandler(this.cbGenres_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDisplay);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 305);
            this.panel1.TabIndex = 29;
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMonth.Location = new System.Drawing.Point(543, 40);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(54, 20);
            this.lMonth.TabIndex = 7;
            this.lMonth.Text = "Month";
            // 
            // rbThisMonth
            // 
            this.rbThisMonth.AutoSize = true;
            this.rbThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThisMonth.Location = new System.Drawing.Point(714, 38);
            this.rbThisMonth.Name = "rbThisMonth";
            this.rbThisMonth.Size = new System.Drawing.Size(105, 24);
            this.rbThisMonth.TabIndex = 6;
            this.rbThisMonth.Text = "This Month";
            this.rbThisMonth.UseVisualStyleBackColor = true;
            this.rbThisMonth.CheckedChanged += new System.EventHandler(this.rbAllMonths_CheckedChanged);
            // 
            // rbAllMonths
            // 
            this.rbAllMonths.AutoSize = true;
            this.rbAllMonths.Checked = true;
            this.rbAllMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllMonths.Location = new System.Drawing.Point(607, 38);
            this.rbAllMonths.Name = "rbAllMonths";
            this.rbAllMonths.Size = new System.Drawing.Size(101, 24);
            this.rbAllMonths.TabIndex = 5;
            this.rbAllMonths.TabStop = true;
            this.rbAllMonths.Text = "All Months";
            this.rbAllMonths.UseVisualStyleBackColor = true;
            this.rbAllMonths.CheckedChanged += new System.EventHandler(this.rbAllMonths_CheckedChanged);
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenre.Location = new System.Drawing.Point(116, 40);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(54, 20);
            this.lGenre.TabIndex = 4;
            this.lGenre.Text = "Genre";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.gbEvent);
            this.gbFilter.Controls.Add(this.lMonth);
            this.gbFilter.Controls.Add(this.cbGenres);
            this.gbFilter.Controls.Add(this.rbThisMonth);
            this.gbFilter.Controls.Add(this.lGenre);
            this.gbFilter.Controls.Add(this.rbAllMonths);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(-1, 336);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1011, 100);
            this.gbFilter.TabIndex = 31;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter By";
            // 
            // gbEvent
            // 
            this.gbEvent.Location = new System.Drawing.Point(0, 82);
            this.gbEvent.Name = "gbEvent";
            this.gbEvent.Size = new System.Drawing.Size(1011, 313);
            this.gbEvent.TabIndex = 32;
            this.gbEvent.TabStop = false;
            this.gbEvent.Text = "Event";
            // 
            // lBandGenre
            // 
            this.lBandGenre.AutoSize = true;
            this.lBandGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBandGenre.Location = new System.Drawing.Point(504, 607);
            this.lBandGenre.Name = "lBandGenre";
            this.lBandGenre.Size = new System.Drawing.Size(96, 20);
            this.lBandGenre.TabIndex = 52;
            this.lBandGenre.Text = "Band Genre";
            // 
            // tbBandGenre
            // 
            this.tbBandGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBandGenre.Location = new System.Drawing.Point(606, 604);
            this.tbBandGenre.Name = "tbBandGenre";
            this.tbBandGenre.Size = new System.Drawing.Size(302, 26);
            this.tbBandGenre.TabIndex = 51;
            // 
            // lEventName
            // 
            this.lEventName.AutoSize = true;
            this.lEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEventName.Location = new System.Drawing.Point(77, 479);
            this.lEventName.Name = "lEventName";
            this.lEventName.Size = new System.Drawing.Size(96, 20);
            this.lEventName.TabIndex = 39;
            this.lEventName.Text = "Event Name";
            // 
            // bAddEvent
            // 
            this.bAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddEvent.Location = new System.Drawing.Point(769, 664);
            this.bAddEvent.Name = "bAddEvent";
            this.bAddEvent.Size = new System.Drawing.Size(139, 29);
            this.bAddEvent.TabIndex = 37;
            this.bAddEvent.Text = "Add Event";
            this.bAddEvent.UseVisualStyleBackColor = true;
            // 
            // lBandName
            // 
            this.lBandName.AutoSize = true;
            this.lBandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBandName.Location = new System.Drawing.Point(507, 575);
            this.lBandName.Name = "lBandName";
            this.lBandName.Size = new System.Drawing.Size(93, 20);
            this.lBandName.TabIndex = 50;
            this.lBandName.Text = "Band Name";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(129, 512);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(44, 20);
            this.lDate.TabIndex = 40;
            this.lDate.Text = "Date";
            // 
            // tbBandName
            // 
            this.tbBandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBandName.Location = new System.Drawing.Point(606, 572);
            this.tbBandName.Name = "tbBandName";
            this.tbBandName.Size = new System.Drawing.Size(302, 26);
            this.tbBandName.TabIndex = 49;
            // 
            // lAgeLimit
            // 
            this.lAgeLimit.AutoSize = true;
            this.lAgeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAgeLimit.Location = new System.Drawing.Point(525, 478);
            this.lAgeLimit.Name = "lAgeLimit";
            this.lAgeLimit.Size = new System.Drawing.Size(75, 20);
            this.lAgeLimit.TabIndex = 44;
            this.lAgeLimit.Text = "Age Limit";
            // 
            // lEndTime
            // 
            this.lEndTime.AutoSize = true;
            this.lEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndTime.Location = new System.Drawing.Point(97, 576);
            this.lEndTime.Name = "lEndTime";
            this.lEndTime.Size = new System.Drawing.Size(76, 20);
            this.lEndTime.TabIndex = 36;
            this.lEndTime.Text = "End Time";
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(179, 476);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(302, 26);
            this.tbEventName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Club Address";
            // 
            // lCoverPrice
            // 
            this.lCoverPrice.AutoSize = true;
            this.lCoverPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoverPrice.Location = new System.Drawing.Point(84, 608);
            this.lCoverPrice.Name = "lCoverPrice";
            this.lCoverPrice.Size = new System.Drawing.Size(89, 20);
            this.lCoverPrice.TabIndex = 43;
            this.lCoverPrice.Text = "Cover Price";
            // 
            // lStartTime
            // 
            this.lStartTime.AutoSize = true;
            this.lStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartTime.Location = new System.Drawing.Point(91, 544);
            this.lStartTime.Name = "lStartTime";
            this.lStartTime.Size = new System.Drawing.Size(82, 20);
            this.lStartTime.TabIndex = 35;
            this.lStartTime.Text = "Start Time";
            // 
            // tbClubName
            // 
            this.tbClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClubName.Location = new System.Drawing.Point(606, 508);
            this.tbClubName.Name = "tbClubName";
            this.tbClubName.Size = new System.Drawing.Size(302, 26);
            this.tbClubName.TabIndex = 42;
            // 
            // tbClubAddress
            // 
            this.tbClubAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClubAddress.Location = new System.Drawing.Point(606, 540);
            this.tbClubAddress.Name = "tbClubAddress";
            this.tbClubAddress.Size = new System.Drawing.Size(302, 26);
            this.tbClubAddress.TabIndex = 47;
            // 
            // tbCoverPrice
            // 
            this.tbCoverPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoverPrice.Location = new System.Drawing.Point(179, 605);
            this.tbCoverPrice.Name = "tbCoverPrice";
            this.tbCoverPrice.Size = new System.Drawing.Size(302, 26);
            this.tbCoverPrice.TabIndex = 41;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndTime.Location = new System.Drawing.Point(179, 573);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(302, 26);
            this.tbEndTime.TabIndex = 34;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(179, 509);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.Size = new System.Drawing.Size(302, 26);
            this.dtpDate.TabIndex = 32;
            // 
            // lClubName
            // 
            this.lClubName.AutoSize = true;
            this.lClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClubName.Location = new System.Drawing.Point(513, 511);
            this.lClubName.Name = "lClubName";
            this.lClubName.Size = new System.Drawing.Size(87, 20);
            this.lClubName.TabIndex = 46;
            this.lClubName.Text = "Club Name";
            // 
            // nUpDownAgeLimit
            // 
            this.nUpDownAgeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownAgeLimit.Location = new System.Drawing.Point(606, 476);
            this.nUpDownAgeLimit.Name = "nUpDownAgeLimit";
            this.nUpDownAgeLimit.Size = new System.Drawing.Size(302, 26);
            this.nUpDownAgeLimit.TabIndex = 45;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartTime.Location = new System.Drawing.Point(179, 541);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(302, 26);
            this.tbStartTime.TabIndex = 33;
            // 
            // rbAddEvent
            // 
            this.rbAddEvent.AutoSize = true;
            this.rbAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddEvent.Location = new System.Drawing.Point(286, 666);
            this.rbAddEvent.Name = "rbAddEvent";
            this.rbAddEvent.Size = new System.Drawing.Size(101, 24);
            this.rbAddEvent.TabIndex = 54;
            this.rbAddEvent.Text = "Add Event";
            this.rbAddEvent.UseVisualStyleBackColor = true;
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Checked = true;
            this.rbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdit.Location = new System.Drawing.Point(179, 666);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(100, 24);
            this.rbEdit.TabIndex = 53;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Edit Event";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.rbAddEvent);
            this.Controls.Add(this.rbEdit);
            this.Controls.Add(this.lBandGenre);
            this.Controls.Add(this.tbBandGenre);
            this.Controls.Add(this.lEventName);
            this.Controls.Add(this.bAddEvent);
            this.Controls.Add(this.lBandName);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.tbBandName);
            this.Controls.Add(this.lAgeLimit);
            this.Controls.Add(this.lEndTime);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lCoverPrice);
            this.Controls.Add(this.lStartTime);
            this.Controls.Add(this.tbClubName);
            this.Controls.Add(this.tbClubAddress);
            this.Controls.Add(this.tbCoverPrice);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lClubName);
            this.Controls.Add(this.nUpDownAgeLimit);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFilter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Pubs and Clubs - Dunedin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAgeLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoverPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Band;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.RadioButton rbThisMonth;
        private System.Windows.Forms.RadioButton rbAllMonths;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbEvent;
        private System.Windows.Forms.Label lBandGenre;
        private System.Windows.Forms.TextBox tbBandGenre;
        private System.Windows.Forms.Label lEventName;
        private System.Windows.Forms.Button bAddEvent;
        private System.Windows.Forms.Label lBandName;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox tbBandName;
        private System.Windows.Forms.Label lAgeLimit;
        private System.Windows.Forms.Label lEndTime;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCoverPrice;
        private System.Windows.Forms.Label lStartTime;
        private System.Windows.Forms.TextBox tbClubName;
        private System.Windows.Forms.TextBox tbClubAddress;
        private System.Windows.Forms.TextBox tbCoverPrice;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lClubName;
        private System.Windows.Forms.NumericUpDown nUpDownAgeLimit;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.RadioButton rbAddEvent;
        private System.Windows.Forms.RadioButton rbEdit;
    }
}

