namespace charlal1_Ticket_Purchase_System
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
            this.components = new System.ComponentModel.Container();
            this.pSeatingDisplayGallery = new System.Windows.Forms.Panel();
            this.lSeating = new System.Windows.Forms.Label();
            this.pSeatingDisplayGods = new System.Windows.Forms.Panel();
            this.lGallery = new System.Windows.Forms.Label();
            this.lGods = new System.Windows.Forms.Label();
            this.pGalleryRows = new System.Windows.Forms.Panel();
            this.pGallerySeats = new System.Windows.Forms.Panel();
            this.pGodsRows = new System.Windows.Forms.Panel();
            this.pGodsSeats = new System.Windows.Forms.Panel();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.gbRate = new System.Windows.Forms.GroupBox();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.rbDoor = new System.Windows.Forms.RadioButton();
            this.rbSeason = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTicketPrice = new System.Windows.Forms.Label();
            this.bBuySeat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lAllocatedSeating = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.gbRate.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSeatingDisplayGallery
            // 
            this.pSeatingDisplayGallery.Location = new System.Drawing.Point(70, 317);
            this.pSeatingDisplayGallery.Name = "pSeatingDisplayGallery";
            this.pSeatingDisplayGallery.Size = new System.Drawing.Size(321, 177);
            this.pSeatingDisplayGallery.TabIndex = 0;
            this.pSeatingDisplayGallery.Paint += new System.Windows.Forms.PaintEventHandler(this.pSeatingDisplayGallery_Paint);
            // 
            // lSeating
            // 
            this.lSeating.AutoSize = true;
            this.lSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeating.Location = new System.Drawing.Point(466, 500);
            this.lSeating.Name = "lSeating";
            this.lSeating.Size = new System.Drawing.Size(216, 33);
            this.lSeating.TabIndex = 1;
            this.lSeating.Text = "Regent Theatre";
            // 
            // pSeatingDisplayGods
            // 
            this.pSeatingDisplayGods.Location = new System.Drawing.Point(397, 317);
            this.pSeatingDisplayGods.Name = "pSeatingDisplayGods";
            this.pSeatingDisplayGods.Size = new System.Drawing.Size(321, 129);
            this.pSeatingDisplayGods.TabIndex = 1;
            // 
            // lGallery
            // 
            this.lGallery.AutoSize = true;
            this.lGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGallery.Location = new System.Drawing.Point(142, 289);
            this.lGallery.Name = "lGallery";
            this.lGallery.Size = new System.Drawing.Size(159, 25);
            this.lGallery.TabIndex = 2;
            this.lGallery.Text = "Gallery Seating";
            // 
            // lGods
            // 
            this.lGods.AutoSize = true;
            this.lGods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGods.Location = new System.Drawing.Point(496, 289);
            this.lGods.Name = "lGods";
            this.lGods.Size = new System.Drawing.Size(142, 25);
            this.lGods.TabIndex = 3;
            this.lGods.Text = "Gods Seating";
            // 
            // pGalleryRows
            // 
            this.pGalleryRows.Location = new System.Drawing.Point(48, 317);
            this.pGalleryRows.Name = "pGalleryRows";
            this.pGalleryRows.Size = new System.Drawing.Size(16, 177);
            this.pGalleryRows.TabIndex = 1;
            // 
            // pGallerySeats
            // 
            this.pGallerySeats.Location = new System.Drawing.Point(70, 500);
            this.pGallerySeats.Name = "pGallerySeats";
            this.pGallerySeats.Size = new System.Drawing.Size(321, 16);
            this.pGallerySeats.TabIndex = 2;
            // 
            // pGodsRows
            // 
            this.pGodsRows.Location = new System.Drawing.Point(724, 317);
            this.pGodsRows.Name = "pGodsRows";
            this.pGodsRows.Size = new System.Drawing.Size(16, 129);
            this.pGodsRows.TabIndex = 2;
            // 
            // pGodsSeats
            // 
            this.pGodsSeats.Location = new System.Drawing.Point(397, 452);
            this.pGodsSeats.Name = "pGodsSeats";
            this.pGodsSeats.Size = new System.Drawing.Size(321, 16);
            this.pGodsSeats.TabIndex = 3;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Checked = true;
            this.rbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStudent.Location = new System.Drawing.Point(36, 30);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(104, 29);
            this.rbStudent.TabIndex = 6;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdult.Location = new System.Drawing.Point(36, 65);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(79, 29);
            this.rbAdult.TabIndex = 7;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            this.rbAdult.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSenior.Location = new System.Drawing.Point(36, 100);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(92, 29);
            this.rbSenior.TabIndex = 8;
            this.rbSenior.TabStop = true;
            this.rbSenior.Text = "Senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            this.rbSenior.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbRate
            // 
            this.gbRate.Controls.Add(this.rbStudent);
            this.gbRate.Controls.Add(this.rbSenior);
            this.gbRate.Controls.Add(this.rbAdult);
            this.gbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRate.Location = new System.Drawing.Point(70, 29);
            this.gbRate.Name = "gbRate";
            this.gbRate.Size = new System.Drawing.Size(188, 142);
            this.gbRate.TabIndex = 9;
            this.gbRate.TabStop = false;
            this.gbRate.Text = "Rate";
            // 
            // gbSales
            // 
            this.gbSales.Controls.Add(this.rbDoor);
            this.gbSales.Controls.Add(this.rbSeason);
            this.gbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSales.Location = new System.Drawing.Point(303, 29);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(188, 142);
            this.gbSales.TabIndex = 10;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Sales";
            // 
            // rbDoor
            // 
            this.rbDoor.AutoSize = true;
            this.rbDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDoor.Location = new System.Drawing.Point(36, 65);
            this.rbDoor.Name = "rbDoor";
            this.rbDoor.Size = new System.Drawing.Size(76, 29);
            this.rbDoor.TabIndex = 1;
            this.rbDoor.Text = "Door";
            this.rbDoor.UseVisualStyleBackColor = true;
            // 
            // rbSeason
            // 
            this.rbSeason.AutoSize = true;
            this.rbSeason.Checked = true;
            this.rbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeason.Location = new System.Drawing.Point(36, 30);
            this.rbSeason.Name = "rbSeason";
            this.rbSeason.Size = new System.Drawing.Size(103, 29);
            this.rbSeason.TabIndex = 0;
            this.rbSeason.TabStop = true;
            this.rbSeason.Text = "Season";
            this.rbSeason.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lTicketPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(530, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Price";
            // 
            // lTicketPrice
            // 
            this.lTicketPrice.AutoSize = true;
            this.lTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTicketPrice.Location = new System.Drawing.Point(44, 65);
            this.lTicketPrice.Name = "lTicketPrice";
            this.lTicketPrice.Size = new System.Drawing.Size(95, 33);
            this.lTicketPrice.TabIndex = 0;
            this.lTicketPrice.Text = "$ 0.00";
            // 
            // bBuySeat
            // 
            this.bBuySeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuySeat.Location = new System.Drawing.Point(70, 203);
            this.bBuySeat.Name = "bBuySeat";
            this.bBuySeat.Size = new System.Drawing.Size(188, 58);
            this.bBuySeat.TabIndex = 12;
            this.bBuySeat.Text = "Buy Seat";
            this.bBuySeat.UseVisualStyleBackColor = true;
            this.bBuySeat.Click += new System.EventHandler(this.bBuySeat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lAllocatedSeating);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allocated Seat";
            // 
            // lAllocatedSeating
            // 
            this.lAllocatedSeating.AutoSize = true;
            this.lAllocatedSeating.Location = new System.Drawing.Point(6, 29);
            this.lAllocatedSeating.Name = "lAllocatedSeating";
            this.lAllocatedSeating.Size = new System.Drawing.Size(0, 25);
            this.lAllocatedSeating.TabIndex = 0;
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(303, 203);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(188, 58);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // clock
            // 
            this.clock.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bBuySeat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSales);
            this.Controls.Add(this.gbRate);
            this.Controls.Add(this.pGodsSeats);
            this.Controls.Add(this.pGodsRows);
            this.Controls.Add(this.pGallerySeats);
            this.Controls.Add(this.pGalleryRows);
            this.Controls.Add(this.lGods);
            this.Controls.Add(this.lGallery);
            this.Controls.Add(this.pSeatingDisplayGods);
            this.Controls.Add(this.lSeating);
            this.Controls.Add(this.pSeatingDisplayGallery);
            this.Name = "Form1";
            this.Text = "Ticket Purchase System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRate.ResumeLayout(false);
            this.gbRate.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.gbSales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSeatingDisplayGallery;
        private System.Windows.Forms.Label lSeating;
        private System.Windows.Forms.Panel pSeatingDisplayGods;
        private System.Windows.Forms.Label lGallery;
        private System.Windows.Forms.Label lGods;
        private System.Windows.Forms.Panel pGalleryRows;
        private System.Windows.Forms.Panel pGallerySeats;
        private System.Windows.Forms.Panel pGodsRows;
        private System.Windows.Forms.Panel pGodsSeats;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.GroupBox gbRate;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.RadioButton rbDoor;
        private System.Windows.Forms.RadioButton rbSeason;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lTicketPrice;
        private System.Windows.Forms.Button bBuySeat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lAllocatedSeating;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Timer clock;
    }
}

