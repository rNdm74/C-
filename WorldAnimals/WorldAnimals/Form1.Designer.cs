namespace WorldAnimals
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
            this.gbContinents = new System.Windows.Forms.GroupBox();
            this.bAustralia = new System.Windows.Forms.Button();
            this.bNAmerica = new System.Windows.Forms.Button();
            this.gbContinentAnimals = new System.Windows.Forms.GroupBox();
            this.lbDisplayAnimals = new System.Windows.Forms.ListBox();
            this.gbAnimalImages = new System.Windows.Forms.GroupBox();
            this.bAfrica = new System.Windows.Forms.Button();
            this.gbContinents.SuspendLayout();
            this.gbContinentAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContinents
            // 
            this.gbContinents.Controls.Add(this.bAfrica);
            this.gbContinents.Controls.Add(this.bAustralia);
            this.gbContinents.Controls.Add(this.bNAmerica);
            this.gbContinents.Location = new System.Drawing.Point(473, 12);
            this.gbContinents.Name = "gbContinents";
            this.gbContinents.Size = new System.Drawing.Size(140, 426);
            this.gbContinents.TabIndex = 3;
            this.gbContinents.TabStop = false;
            this.gbContinents.Text = "Continents";
            // 
            // bAustralia
            // 
            this.bAustralia.Location = new System.Drawing.Point(7, 49);
            this.bAustralia.Name = "bAustralia";
            this.bAustralia.Size = new System.Drawing.Size(127, 23);
            this.bAustralia.TabIndex = 1;
            this.bAustralia.Text = "Australia";
            this.bAustralia.UseVisualStyleBackColor = true;
            this.bAustralia.Click += new System.EventHandler(this.bContinent_Click);
            // 
            // bNAmerica
            // 
            this.bNAmerica.Location = new System.Drawing.Point(7, 20);
            this.bNAmerica.Name = "bNAmerica";
            this.bNAmerica.Size = new System.Drawing.Size(127, 23);
            this.bNAmerica.TabIndex = 0;
            this.bNAmerica.Text = "North America";
            this.bNAmerica.UseVisualStyleBackColor = true;
            this.bNAmerica.Click += new System.EventHandler(this.bContinent_Click);
            // 
            // gbContinentAnimals
            // 
            this.gbContinentAnimals.Controls.Add(this.lbDisplayAnimals);
            this.gbContinentAnimals.Location = new System.Drawing.Point(207, 12);
            this.gbContinentAnimals.Name = "gbContinentAnimals";
            this.gbContinentAnimals.Size = new System.Drawing.Size(260, 426);
            this.gbContinentAnimals.TabIndex = 4;
            this.gbContinentAnimals.TabStop = false;
            this.gbContinentAnimals.Text = "Continent Animals";
            // 
            // lbDisplayAnimals
            // 
            this.lbDisplayAnimals.BackColor = System.Drawing.SystemColors.Control;
            this.lbDisplayAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDisplayAnimals.FormattingEnabled = true;
            this.lbDisplayAnimals.Location = new System.Drawing.Point(7, 20);
            this.lbDisplayAnimals.Name = "lbDisplayAnimals";
            this.lbDisplayAnimals.Size = new System.Drawing.Size(247, 403);
            this.lbDisplayAnimals.TabIndex = 0;
            // 
            // gbAnimalImages
            // 
            this.gbAnimalImages.Location = new System.Drawing.Point(12, 12);
            this.gbAnimalImages.Name = "gbAnimalImages";
            this.gbAnimalImages.Size = new System.Drawing.Size(189, 426);
            this.gbAnimalImages.TabIndex = 5;
            this.gbAnimalImages.TabStop = false;
            this.gbAnimalImages.Text = "Animal Images";
            // 
            // bAfrica
            // 
            this.bAfrica.Location = new System.Drawing.Point(7, 78);
            this.bAfrica.Name = "bAfrica";
            this.bAfrica.Size = new System.Drawing.Size(127, 23);
            this.bAfrica.TabIndex = 2;
            this.bAfrica.Text = "Africa";
            this.bAfrica.UseVisualStyleBackColor = true;
            this.bAfrica.Click += new System.EventHandler(this.bContinent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.gbAnimalImages);
            this.Controls.Add(this.gbContinentAnimals);
            this.Controls.Add(this.gbContinents);
            this.Name = "Form1";
            this.Text = "World Animals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbContinents.ResumeLayout(false);
            this.gbContinentAnimals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContinents;
        private System.Windows.Forms.Button bAustralia;
        private System.Windows.Forms.Button bNAmerica;
        private System.Windows.Forms.GroupBox gbContinentAnimals;
        private System.Windows.Forms.ListBox lbDisplayAnimals;
        private System.Windows.Forms.GroupBox gbAnimalImages;
        private System.Windows.Forms.Button bAfrica;
    }
}

