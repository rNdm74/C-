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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Band = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToOrderColumns = true;
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.StartTime,
            this.EndTime,
            this.CoverPrice,
            this.AgeLimit,
            this.Club,
            this.ClubAddress,
            this.Band,
            this.BandGenre});
            this.dgvDisplay.Location = new System.Drawing.Point(12, 218);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplay.Size = new System.Drawing.Size(946, 331);
            this.dgvDisplay.TabIndex = 0;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event Name";
            this.Event.Name = "Event";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
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

