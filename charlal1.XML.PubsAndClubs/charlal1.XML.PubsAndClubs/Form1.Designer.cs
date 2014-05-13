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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.pGridViewDisplay = new System.Windows.Forms.Panel();
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
            this.lClubAddress = new System.Windows.Forms.Label();
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
            this.rbEditEvent = new System.Windows.Forms.RadioButton();
            this.rbDeleteEvent = new System.Windows.Forms.RadioButton();
            this.lID = new System.Windows.Forms.Label();
            this.lIDValue = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.pGridViewDisplay.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAgeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplay.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDisplay.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDisplay.RowHeadersVisible = false;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(1011, 305);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
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
            // pGridViewDisplay
            // 
            this.pGridViewDisplay.Controls.Add(this.dgvDisplay);
            this.pGridViewDisplay.Location = new System.Drawing.Point(-1, -1);
            this.pGridViewDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pGridViewDisplay.Name = "pGridViewDisplay";
            this.pGridViewDisplay.Size = new System.Drawing.Size(1011, 305);
            this.pGridViewDisplay.TabIndex = 29;
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
            this.bAddEvent.Text = "Edit Event";
            this.bAddEvent.UseVisualStyleBackColor = true;
            this.bAddEvent.Click += new System.EventHandler(this.bAddEvent_Click);
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
            // lClubAddress
            // 
            this.lClubAddress.AutoSize = true;
            this.lClubAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClubAddress.Location = new System.Drawing.Point(496, 543);
            this.lClubAddress.Name = "lClubAddress";
            this.lClubAddress.Size = new System.Drawing.Size(104, 20);
            this.lClubAddress.TabIndex = 48;
            this.lClubAddress.Text = "Club Address";
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
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.rbAddEvent.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // rbEditEvent
            // 
            this.rbEditEvent.AutoSize = true;
            this.rbEditEvent.Checked = true;
            this.rbEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEditEvent.Location = new System.Drawing.Point(179, 666);
            this.rbEditEvent.Name = "rbEditEvent";
            this.rbEditEvent.Size = new System.Drawing.Size(100, 24);
            this.rbEditEvent.TabIndex = 53;
            this.rbEditEvent.TabStop = true;
            this.rbEditEvent.Text = "Edit Event";
            this.rbEditEvent.UseVisualStyleBackColor = true;
            this.rbEditEvent.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // rbDeleteEvent
            // 
            this.rbDeleteEvent.AutoSize = true;
            this.rbDeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeleteEvent.Location = new System.Drawing.Point(393, 666);
            this.rbDeleteEvent.Name = "rbDeleteEvent";
            this.rbDeleteEvent.Size = new System.Drawing.Size(119, 24);
            this.rbDeleteEvent.TabIndex = 55;
            this.rbDeleteEvent.TabStop = true;
            this.rbDeleteEvent.Text = "Delete Event";
            this.rbDeleteEvent.UseVisualStyleBackColor = true;
            this.rbDeleteEvent.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lID.Location = new System.Drawing.Point(147, 447);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(26, 20);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID";
            // 
            // lIDValue
            // 
            this.lIDValue.AutoSize = true;
            this.lIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDValue.Location = new System.Drawing.Point(179, 447);
            this.lIDValue.Name = "lIDValue";
            this.lIDValue.Size = new System.Drawing.Size(18, 20);
            this.lIDValue.TabIndex = 56;
            this.lIDValue.Text = "0";
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(606, 664);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(139, 29);
            this.bSave.TabIndex = 57;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ID
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.FillWeight = 14.40773F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Event
            // 
            this.Event.FillWeight = 31.57633F;
            this.Event.HeaderText = "Event Name";
            this.Event.Name = "Event";
            // 
            // Date
            // 
            dataGridViewCellStyle4.Format = "dd-MM-yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date.FillWeight = 31.57633F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StartTime
            // 
            this.StartTime.FillWeight = 17.24632F;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.FillWeight = 20.40247F;
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            // 
            // CoverPrice
            // 
            this.CoverPrice.FillWeight = 22.94726F;
            this.CoverPrice.HeaderText = "Cover Price";
            this.CoverPrice.Name = "CoverPrice";
            // 
            // AgeLimit
            // 
            this.AgeLimit.FillWeight = 22.94726F;
            this.AgeLimit.HeaderText = "Age Limit";
            this.AgeLimit.Name = "AgeLimit";
            // 
            // Club
            // 
            this.Club.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Club.FillWeight = 99.09013F;
            this.Club.HeaderText = "Club Name";
            this.Club.Name = "Club";
            this.Club.Width = 60;
            // 
            // ClubAddress
            // 
            this.ClubAddress.FillWeight = 31.57633F;
            this.ClubAddress.HeaderText = "Club Address";
            this.ClubAddress.Name = "ClubAddress";
            // 
            // Band
            // 
            this.Band.FillWeight = 31.57633F;
            this.Band.HeaderText = "Band Name";
            this.Band.Name = "Band";
            // 
            // BandGenre
            // 
            this.BandGenre.FillWeight = 31.57633F;
            this.BandGenre.HeaderText = "Band Genre";
            this.BandGenre.Name = "BandGenre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lIDValue);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.rbDeleteEvent);
            this.Controls.Add(this.rbAddEvent);
            this.Controls.Add(this.rbEditEvent);
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
            this.Controls.Add(this.lClubAddress);
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
            this.Controls.Add(this.pGridViewDisplay);
            this.Controls.Add(this.gbFilter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Pubs and Clubs - Dunedin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.pGridViewDisplay.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAgeLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Panel pGridViewDisplay;
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
        private System.Windows.Forms.Label lClubAddress;
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
        private System.Windows.Forms.RadioButton rbEditEvent;
        private System.Windows.Forms.RadioButton rbDeleteEvent;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lIDValue;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
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
    }
}

