namespace Mix_and_Match
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
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.gbHead = new System.Windows.Forms.GroupBox();
            this.gbBody = new System.Windows.Forms.GroupBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.gbLegs = new System.Windows.Forms.GroupBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbHead.SuspendLayout();
            this.gbBody.SuspendLayout();
            this.gbLegs.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHead
            // 
            this.cbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(6, 19);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(188, 28);
            this.cbHead.TabIndex = 0;
            // 
            // gbHead
            // 
            this.gbHead.Controls.Add(this.cbHead);
            this.gbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHead.Location = new System.Drawing.Point(425, 31);
            this.gbHead.Name = "gbHead";
            this.gbHead.Size = new System.Drawing.Size(200, 57);
            this.gbHead.TabIndex = 3;
            this.gbHead.TabStop = false;
            this.gbHead.Text = "Head";
            // 
            // gbBody
            // 
            this.gbBody.Controls.Add(this.cbBody);
            this.gbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBody.Location = new System.Drawing.Point(425, 94);
            this.gbBody.Name = "gbBody";
            this.gbBody.Size = new System.Drawing.Size(200, 57);
            this.gbBody.TabIndex = 4;
            this.gbBody.TabStop = false;
            this.gbBody.Text = "Body";
            // 
            // cbBody
            // 
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(6, 19);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(188, 28);
            this.cbBody.TabIndex = 0;
            // 
            // gbLegs
            // 
            this.gbLegs.Controls.Add(this.cbLegs);
            this.gbLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLegs.Location = new System.Drawing.Point(425, 157);
            this.gbLegs.Name = "gbLegs";
            this.gbLegs.Size = new System.Drawing.Size(200, 57);
            this.gbLegs.TabIndex = 4;
            this.gbLegs.TabStop = false;
            this.gbLegs.Text = "Legs";
            // 
            // cbLegs
            // 
            this.cbLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Location = new System.Drawing.Point(6, 19);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(188, 28);
            this.cbLegs.TabIndex = 0;
            // 
            // gbDisplay
            // 
            this.gbDisplay.Controls.Add(this.pbLegs);
            this.gbDisplay.Controls.Add(this.pbBody);
            this.gbDisplay.Controls.Add(this.pbHead);
            this.gbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisplay.Location = new System.Drawing.Point(12, 12);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(325, 596);
            this.gbDisplay.TabIndex = 5;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "Display";
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(6, 395);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(313, 183);
            this.pbLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Location = new System.Drawing.Point(6, 213);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(313, 183);
            this.pbBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBody.TabIndex = 1;
            this.pbBody.TabStop = false;
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(6, 31);
            this.pbHead.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(313, 183);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make Monster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDisplay);
            this.Controls.Add(this.gbBody);
            this.Controls.Add(this.gbLegs);
            this.Controls.Add(this.gbHead);
            this.Name = "Form1";
            this.Text = "Mix n Match";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbHead.ResumeLayout(false);
            this.gbBody.ResumeLayout(false);
            this.gbLegs.ResumeLayout(false);
            this.gbDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.GroupBox gbHead;
        private System.Windows.Forms.GroupBox gbBody;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.GroupBox gbLegs;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.Button button1;
    }
}

