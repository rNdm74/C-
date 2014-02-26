namespace Best_Movie_Database
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
            this.bAddMovie = new System.Windows.Forms.Button();
            this.tbTitleAdd = new System.Windows.Forms.TextBox();
            this.alYear = new System.Windows.Forms.Label();
            this.tbYearAdd = new System.Windows.Forms.TextBox();
            this.alDirector = new System.Windows.Forms.Label();
            this.tbDirectorAdd = new System.Windows.Forms.TextBox();
            this.alTitle = new System.Windows.Forms.Label();
            this.bDeleteMovie = new System.Windows.Forms.Button();
            this.dlYear = new System.Windows.Forms.Label();
            this.tbYearDelete = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.slYear = new System.Windows.Forms.Label();
            this.tbYearSearch = new System.Windows.Forms.TextBox();
            this.bPrintAll = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAddMovie
            // 
            this.bAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddMovie.Location = new System.Drawing.Point(12, 34);
            this.bAddMovie.Name = "bAddMovie";
            this.bAddMovie.Size = new System.Drawing.Size(100, 40);
            this.bAddMovie.TabIndex = 18;
            this.bAddMovie.Text = "Add";
            this.bAddMovie.UseVisualStyleBackColor = true;
            this.bAddMovie.Click += new System.EventHandler(this.bAddMovie_Click);
            // 
            // tbTitleAdd
            // 
            this.tbTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleAdd.Location = new System.Drawing.Point(242, 86);
            this.tbTitleAdd.Margin = new System.Windows.Forms.Padding(10);
            this.tbTitleAdd.Name = "tbTitleAdd";
            this.tbTitleAdd.Size = new System.Drawing.Size(350, 20);
            this.tbTitleAdd.TabIndex = 21;
            // 
            // alYear
            // 
            this.alYear.AutoSize = true;
            this.alYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alYear.Location = new System.Drawing.Point(173, 44);
            this.alYear.Name = "alYear";
            this.alYear.Size = new System.Drawing.Size(43, 20);
            this.alYear.TabIndex = 19;
            this.alYear.Text = "Year";
            // 
            // tbYearAdd
            // 
            this.tbYearAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYearAdd.Location = new System.Drawing.Point(242, 44);
            this.tbYearAdd.Margin = new System.Windows.Forms.Padding(10);
            this.tbYearAdd.Name = "tbYearAdd";
            this.tbYearAdd.Size = new System.Drawing.Size(350, 20);
            this.tbYearAdd.TabIndex = 20;
            // 
            // alDirector
            // 
            this.alDirector.AutoSize = true;
            this.alDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alDirector.Location = new System.Drawing.Point(151, 126);
            this.alDirector.Name = "alDirector";
            this.alDirector.Size = new System.Drawing.Size(65, 20);
            this.alDirector.TabIndex = 24;
            this.alDirector.Text = "Director";
            // 
            // tbDirectorAdd
            // 
            this.tbDirectorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectorAdd.Location = new System.Drawing.Point(242, 126);
            this.tbDirectorAdd.Margin = new System.Windows.Forms.Padding(10);
            this.tbDirectorAdd.Name = "tbDirectorAdd";
            this.tbDirectorAdd.Size = new System.Drawing.Size(350, 20);
            this.tbDirectorAdd.TabIndex = 22;
            // 
            // alTitle
            // 
            this.alTitle.AutoSize = true;
            this.alTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alTitle.Location = new System.Drawing.Point(178, 84);
            this.alTitle.Name = "alTitle";
            this.alTitle.Size = new System.Drawing.Size(38, 20);
            this.alTitle.TabIndex = 23;
            this.alTitle.Text = "Title";
            // 
            // bDeleteMovie
            // 
            this.bDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteMovie.Location = new System.Drawing.Point(12, 187);
            this.bDeleteMovie.Name = "bDeleteMovie";
            this.bDeleteMovie.Size = new System.Drawing.Size(100, 40);
            this.bDeleteMovie.TabIndex = 25;
            this.bDeleteMovie.Text = "Delete";
            this.bDeleteMovie.UseVisualStyleBackColor = true;
            this.bDeleteMovie.Click += new System.EventHandler(this.bDeleteMovie_Click);
            // 
            // dlYear
            // 
            this.dlYear.AutoSize = true;
            this.dlYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlYear.Location = new System.Drawing.Point(173, 195);
            this.dlYear.Name = "dlYear";
            this.dlYear.Size = new System.Drawing.Size(43, 20);
            this.dlYear.TabIndex = 27;
            this.dlYear.Text = "Year";
            // 
            // tbYearDelete
            // 
            this.tbYearDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYearDelete.Location = new System.Drawing.Point(242, 197);
            this.tbYearDelete.Name = "tbYearDelete";
            this.tbYearDelete.Size = new System.Drawing.Size(350, 20);
            this.tbYearDelete.TabIndex = 26;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(12, 268);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(100, 40);
            this.bSearch.TabIndex = 28;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // slYear
            // 
            this.slYear.AutoSize = true;
            this.slYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slYear.Location = new System.Drawing.Point(173, 276);
            this.slYear.Name = "slYear";
            this.slYear.Size = new System.Drawing.Size(43, 20);
            this.slYear.TabIndex = 30;
            this.slYear.Text = "Year";
            // 
            // tbYearSearch
            // 
            this.tbYearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYearSearch.Location = new System.Drawing.Point(242, 278);
            this.tbYearSearch.Name = "tbYearSearch";
            this.tbYearSearch.Size = new System.Drawing.Size(350, 20);
            this.tbYearSearch.TabIndex = 29;
            // 
            // bPrintAll
            // 
            this.bPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrintAll.Location = new System.Drawing.Point(12, 314);
            this.bPrintAll.Name = "bPrintAll";
            this.bPrintAll.Size = new System.Drawing.Size(100, 40);
            this.bPrintAll.TabIndex = 31;
            this.bPrintAll.Text = "Print";
            this.bPrintAll.UseVisualStyleBackColor = true;
            this.bPrintAll.Click += new System.EventHandler(this.bPrintAll_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 20;
            this.lbDisplay.Location = new System.Drawing.Point(155, 315);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(437, 104);
            this.lbDisplay.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.bPrintAll);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.slYear);
            this.Controls.Add(this.tbYearSearch);
            this.Controls.Add(this.bDeleteMovie);
            this.Controls.Add(this.dlYear);
            this.Controls.Add(this.tbYearDelete);
            this.Controls.Add(this.bAddMovie);
            this.Controls.Add(this.tbTitleAdd);
            this.Controls.Add(this.alYear);
            this.Controls.Add(this.tbYearAdd);
            this.Controls.Add(this.alDirector);
            this.Controls.Add(this.tbDirectorAdd);
            this.Controls.Add(this.alTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMovie;
        private System.Windows.Forms.TextBox tbTitleAdd;
        private System.Windows.Forms.Label alYear;
        private System.Windows.Forms.TextBox tbYearAdd;
        private System.Windows.Forms.Label alDirector;
        private System.Windows.Forms.TextBox tbDirectorAdd;
        private System.Windows.Forms.Label alTitle;
        private System.Windows.Forms.Button bDeleteMovie;
        private System.Windows.Forms.Label dlYear;
        private System.Windows.Forms.TextBox tbYearDelete;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label slYear;
        private System.Windows.Forms.TextBox tbYearSearch;
        private System.Windows.Forms.Button bPrintAll;
        private System.Windows.Forms.ListBox lbDisplay;

    }
}

