namespace FireAlarm
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
            this.bFireAlarm = new System.Windows.Forms.Button();
            this.gbFireCatagory = new System.Windows.Forms.GroupBox();
            this.rbMinor = new System.Windows.Forms.RadioButton();
            this.rbSerious = new System.Windows.Forms.RadioButton();
            this.rbInferno = new System.Windows.Forms.RadioButton();
            this.gbFireCatagory.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFireAlarm
            // 
            this.bFireAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFireAlarm.Location = new System.Drawing.Point(13, 13);
            this.bFireAlarm.Name = "bFireAlarm";
            this.bFireAlarm.Size = new System.Drawing.Size(236, 50);
            this.bFireAlarm.TabIndex = 0;
            this.bFireAlarm.Text = "Fire Alarm";
            this.bFireAlarm.UseVisualStyleBackColor = true;
            this.bFireAlarm.Click += new System.EventHandler(this.bFireAlarm_Click);
            // 
            // gbFireCatagory
            // 
            this.gbFireCatagory.Controls.Add(this.rbInferno);
            this.gbFireCatagory.Controls.Add(this.rbSerious);
            this.gbFireCatagory.Controls.Add(this.rbMinor);
            this.gbFireCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFireCatagory.Location = new System.Drawing.Point(13, 70);
            this.gbFireCatagory.Name = "gbFireCatagory";
            this.gbFireCatagory.Size = new System.Drawing.Size(236, 212);
            this.gbFireCatagory.TabIndex = 1;
            this.gbFireCatagory.TabStop = false;
            this.gbFireCatagory.Text = "Fire Catagory";
            // 
            // rbMinor
            // 
            this.rbMinor.AutoSize = true;
            this.rbMinor.Checked = true;
            this.rbMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinor.Location = new System.Drawing.Point(34, 62);
            this.rbMinor.Name = "rbMinor";
            this.rbMinor.Size = new System.Drawing.Size(84, 29);
            this.rbMinor.TabIndex = 0;
            this.rbMinor.TabStop = true;
            this.rbMinor.Text = "Minor";
            this.rbMinor.UseVisualStyleBackColor = true;
            // 
            // rbSerious
            // 
            this.rbSerious.AutoSize = true;
            this.rbSerious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSerious.Location = new System.Drawing.Point(34, 97);
            this.rbSerious.Name = "rbSerious";
            this.rbSerious.Size = new System.Drawing.Size(103, 29);
            this.rbSerious.TabIndex = 1;
            this.rbSerious.TabStop = true;
            this.rbSerious.Text = "Serious";
            this.rbSerious.UseVisualStyleBackColor = true;
            // 
            // rbInferno
            // 
            this.rbInferno.AutoSize = true;
            this.rbInferno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInferno.Location = new System.Drawing.Point(34, 132);
            this.rbInferno.Name = "rbInferno";
            this.rbInferno.Size = new System.Drawing.Size(96, 29);
            this.rbInferno.TabIndex = 2;
            this.rbInferno.TabStop = true;
            this.rbInferno.Text = "Inferno";
            this.rbInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 303);
            this.Controls.Add(this.gbFireCatagory);
            this.Controls.Add(this.bFireAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFireCatagory.ResumeLayout(false);
            this.gbFireCatagory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFireAlarm;
        private System.Windows.Forms.GroupBox gbFireCatagory;
        private System.Windows.Forms.RadioButton rbInferno;
        private System.Windows.Forms.RadioButton rbSerious;
        private System.Windows.Forms.RadioButton rbMinor;
    }
}

