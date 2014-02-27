namespace Bridge
{
    partial class Bridge
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
            this.bDeal = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.bSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDeal
            // 
            this.bDeal.Location = new System.Drawing.Point(12, 516);
            this.bDeal.Name = "bDeal";
            this.bDeal.Size = new System.Drawing.Size(113, 73);
            this.bDeal.TabIndex = 0;
            this.bDeal.Text = "Deal";
            this.bDeal.UseVisualStyleBackColor = true;
            this.bDeal.Click += new System.EventHandler(this.bDeal_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(12, 12);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(600, 485);
            this.lbDisplay.TabIndex = 1;
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(131, 516);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(113, 73);
            this.bSort.TabIndex = 2;
            this.bSort.Text = "Sort";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // Bridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.bSort);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.bDeal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 640);
            this.Name = "Bridge";
            this.ShowIcon = false;
            this.Text = "Bridge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDeal;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button bSort;
    }
}

