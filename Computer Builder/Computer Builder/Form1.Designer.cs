namespace Computer_Builder
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
            this.bQuery = new System.Windows.Forms.Button();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbGaming = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bQuery
            // 
            this.bQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuery.Location = new System.Drawing.Point(12, 101);
            this.bQuery.Name = "bQuery";
            this.bQuery.Size = new System.Drawing.Size(116, 37);
            this.bQuery.TabIndex = 0;
            this.bQuery.Text = "Query";
            this.bQuery.UseVisualStyleBackColor = true;
            this.bQuery.Click += new System.EventHandler(this.bQuery_Click);
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Checked = true;
            this.rbBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusiness.Location = new System.Drawing.Point(27, 13);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(92, 24);
            this.rbBusiness.TabIndex = 1;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbGaming
            // 
            this.rbGaming.AutoSize = true;
            this.rbGaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGaming.Location = new System.Drawing.Point(27, 36);
            this.rbGaming.Name = "rbGaming";
            this.rbGaming.Size = new System.Drawing.Size(83, 24);
            this.rbGaming.TabIndex = 2;
            this.rbGaming.Text = "Gaming";
            this.rbGaming.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedia.Location = new System.Drawing.Point(27, 59);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(70, 24);
            this.rbMedia.TabIndex = 3;
            this.rbMedia.Text = "Media";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // lbDisplay
            // 
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 20;
            this.lbDisplay.Location = new System.Drawing.Point(141, 13);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(371, 144);
            this.lbDisplay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 172);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.rbMedia);
            this.Controls.Add(this.rbGaming);
            this.Controls.Add(this.rbBusiness);
            this.Controls.Add(this.bQuery);
            this.Name = "Form1";
            this.Text = "Computer Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bQuery;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbGaming;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.ListBox lbDisplay;
    }
}

