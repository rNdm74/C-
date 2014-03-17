namespace Animal_Shelter
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
            this.pAnimals = new System.Windows.Forms.Panel();
            this.rbRabbits = new System.Windows.Forms.RadioButton();
            this.rbDucks = new System.Windows.Forms.RadioButton();
            this.rbDogs = new System.Windows.Forms.RadioButton();
            this.rbCats = new System.Windows.Forms.RadioButton();
            this.lbPets = new System.Windows.Forms.ListBox();
            this.bShowPets = new System.Windows.Forms.Button();
            this.pbPet1 = new System.Windows.Forms.PictureBox();
            this.pbPet2 = new System.Windows.Forms.PictureBox();
            this.pbPet3 = new System.Windows.Forms.PictureBox();
            this.pbPet4 = new System.Windows.Forms.PictureBox();
            this.pAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet4)).BeginInit();
            this.SuspendLayout();
            // 
            // pAnimals
            // 
            this.pAnimals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAnimals.Controls.Add(this.rbRabbits);
            this.pAnimals.Controls.Add(this.rbDucks);
            this.pAnimals.Controls.Add(this.rbDogs);
            this.pAnimals.Controls.Add(this.rbCats);
            this.pAnimals.Location = new System.Drawing.Point(13, 13);
            this.pAnimals.Name = "pAnimals";
            this.pAnimals.Size = new System.Drawing.Size(152, 141);
            this.pAnimals.TabIndex = 0;
            // 
            // rbRabbits
            // 
            this.rbRabbits.AutoSize = true;
            this.rbRabbits.Location = new System.Drawing.Point(19, 91);
            this.rbRabbits.Name = "rbRabbits";
            this.rbRabbits.Size = new System.Drawing.Size(61, 17);
            this.rbRabbits.TabIndex = 3;
            this.rbRabbits.Text = "Rabbits";
            this.rbRabbits.UseVisualStyleBackColor = true;
            // 
            // rbDucks
            // 
            this.rbDucks.AutoSize = true;
            this.rbDucks.Location = new System.Drawing.Point(19, 67);
            this.rbDucks.Name = "rbDucks";
            this.rbDucks.Size = new System.Drawing.Size(56, 17);
            this.rbDucks.TabIndex = 2;
            this.rbDucks.Text = "Ducks";
            this.rbDucks.UseVisualStyleBackColor = true;
            // 
            // rbDogs
            // 
            this.rbDogs.AutoSize = true;
            this.rbDogs.Location = new System.Drawing.Point(19, 43);
            this.rbDogs.Name = "rbDogs";
            this.rbDogs.Size = new System.Drawing.Size(50, 17);
            this.rbDogs.TabIndex = 1;
            this.rbDogs.Text = "Dogs";
            this.rbDogs.UseVisualStyleBackColor = true;
            // 
            // rbCats
            // 
            this.rbCats.AutoSize = true;
            this.rbCats.Checked = true;
            this.rbCats.Location = new System.Drawing.Point(19, 19);
            this.rbCats.Name = "rbCats";
            this.rbCats.Size = new System.Drawing.Size(46, 17);
            this.rbCats.TabIndex = 0;
            this.rbCats.TabStop = true;
            this.rbCats.Text = "Cats";
            this.rbCats.UseVisualStyleBackColor = true;
            // 
            // lbPets
            // 
            this.lbPets.FormattingEnabled = true;
            this.lbPets.Location = new System.Drawing.Point(13, 161);
            this.lbPets.Name = "lbPets";
            this.lbPets.Size = new System.Drawing.Size(152, 186);
            this.lbPets.TabIndex = 1;
            // 
            // bShowPets
            // 
            this.bShowPets.Location = new System.Drawing.Point(12, 353);
            this.bShowPets.Name = "bShowPets";
            this.bShowPets.Size = new System.Drawing.Size(152, 33);
            this.bShowPets.TabIndex = 2;
            this.bShowPets.Text = "Show Pets !";
            this.bShowPets.UseVisualStyleBackColor = true;
            this.bShowPets.Click += new System.EventHandler(this.bShowPets_Click);
            // 
            // pbPet1
            // 
            this.pbPet1.Location = new System.Drawing.Point(183, 13);
            this.pbPet1.Name = "pbPet1";
            this.pbPet1.Size = new System.Drawing.Size(199, 184);
            this.pbPet1.TabIndex = 3;
            this.pbPet1.TabStop = false;
            // 
            // pbPet2
            // 
            this.pbPet2.Location = new System.Drawing.Point(388, 12);
            this.pbPet2.Name = "pbPet2";
            this.pbPet2.Size = new System.Drawing.Size(199, 184);
            this.pbPet2.TabIndex = 4;
            this.pbPet2.TabStop = false;
            // 
            // pbPet3
            // 
            this.pbPet3.Location = new System.Drawing.Point(183, 202);
            this.pbPet3.Name = "pbPet3";
            this.pbPet3.Size = new System.Drawing.Size(199, 184);
            this.pbPet3.TabIndex = 5;
            this.pbPet3.TabStop = false;
            // 
            // pbPet4
            // 
            this.pbPet4.Location = new System.Drawing.Point(388, 202);
            this.pbPet4.Name = "pbPet4";
            this.pbPet4.Size = new System.Drawing.Size(199, 184);
            this.pbPet4.TabIndex = 6;
            this.pbPet4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 398);
            this.Controls.Add(this.pbPet4);
            this.Controls.Add(this.pbPet3);
            this.Controls.Add(this.pbPet2);
            this.Controls.Add(this.pbPet1);
            this.Controls.Add(this.bShowPets);
            this.Controls.Add(this.lbPets);
            this.Controls.Add(this.pAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pAnimals.ResumeLayout(false);
            this.pAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAnimals;
        private System.Windows.Forms.RadioButton rbRabbits;
        private System.Windows.Forms.RadioButton rbDucks;
        private System.Windows.Forms.RadioButton rbDogs;
        private System.Windows.Forms.RadioButton rbCats;
        private System.Windows.Forms.ListBox lbPets;
        private System.Windows.Forms.Button bShowPets;
        private System.Windows.Forms.PictureBox pbPet1;
        private System.Windows.Forms.PictureBox pbPet2;
        private System.Windows.Forms.PictureBox pbPet3;
        private System.Windows.Forms.PictureBox pbPet4;
    }
}

