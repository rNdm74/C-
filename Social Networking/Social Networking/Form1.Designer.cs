namespace Social_Networking
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
            this.tcDisplay = new System.Windows.Forms.TabControl();
            this.tpMainPage = new System.Windows.Forms.TabPage();
            this.tpFriend1 = new System.Windows.Forms.TabPage();
            this.bUpdate = new System.Windows.Forms.Button();
            this.tbUpdateString = new System.Windows.Forms.TextBox();
            this.tpFriend2 = new System.Windows.Forms.TabPage();
            this.tpFriend3 = new System.Windows.Forms.TabPage();
            this.tpFriend4 = new System.Windows.Forms.TabPage();
            this.lbMainPage = new System.Windows.Forms.ListBox();
            this.lbFriend1 = new System.Windows.Forms.ListBox();
            this.lbFriend2 = new System.Windows.Forms.ListBox();
            this.lbFriend3 = new System.Windows.Forms.ListBox();
            this.lbFriend4 = new System.Windows.Forms.ListBox();
            this.tcDisplay.SuspendLayout();
            this.tpMainPage.SuspendLayout();
            this.tpFriend1.SuspendLayout();
            this.tpFriend2.SuspendLayout();
            this.tpFriend3.SuspendLayout();
            this.tpFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDisplay
            // 
            this.tcDisplay.Controls.Add(this.tpMainPage);
            this.tcDisplay.Controls.Add(this.tpFriend1);
            this.tcDisplay.Controls.Add(this.tpFriend2);
            this.tcDisplay.Controls.Add(this.tpFriend3);
            this.tcDisplay.Controls.Add(this.tpFriend4);
            this.tcDisplay.Location = new System.Drawing.Point(12, 12);
            this.tcDisplay.Name = "tcDisplay";
            this.tcDisplay.SelectedIndex = 0;
            this.tcDisplay.Size = new System.Drawing.Size(616, 324);
            this.tcDisplay.TabIndex = 0;
            // 
            // tpMainPage
            // 
            this.tpMainPage.Controls.Add(this.lbMainPage);
            this.tpMainPage.Location = new System.Drawing.Point(4, 22);
            this.tpMainPage.Name = "tpMainPage";
            this.tpMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainPage.Size = new System.Drawing.Size(608, 298);
            this.tpMainPage.TabIndex = 0;
            this.tpMainPage.Text = "Main Page";
            this.tpMainPage.UseVisualStyleBackColor = true;
            // 
            // tpFriend1
            // 
            this.tpFriend1.Controls.Add(this.lbFriend1);
            this.tpFriend1.Location = new System.Drawing.Point(4, 22);
            this.tpFriend1.Name = "tpFriend1";
            this.tpFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend1.Size = new System.Drawing.Size(608, 298);
            this.tpFriend1.TabIndex = 1;
            this.tpFriend1.Text = "Friend 1";
            this.tpFriend1.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(16, 348);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(143, 34);
            this.bUpdate.TabIndex = 1;
            this.bUpdate.Text = "Update Status";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // tbUpdateString
            // 
            this.tbUpdateString.Location = new System.Drawing.Point(165, 356);
            this.tbUpdateString.Name = "tbUpdateString";
            this.tbUpdateString.Size = new System.Drawing.Size(459, 20);
            this.tbUpdateString.TabIndex = 2;
            // 
            // tpFriend2
            // 
            this.tpFriend2.Controls.Add(this.lbFriend2);
            this.tpFriend2.Location = new System.Drawing.Point(4, 22);
            this.tpFriend2.Name = "tpFriend2";
            this.tpFriend2.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend2.Size = new System.Drawing.Size(608, 298);
            this.tpFriend2.TabIndex = 2;
            this.tpFriend2.Text = "Friend 2";
            this.tpFriend2.UseVisualStyleBackColor = true;
            // 
            // tpFriend3
            // 
            this.tpFriend3.Controls.Add(this.lbFriend3);
            this.tpFriend3.Location = new System.Drawing.Point(4, 22);
            this.tpFriend3.Name = "tpFriend3";
            this.tpFriend3.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend3.Size = new System.Drawing.Size(608, 298);
            this.tpFriend3.TabIndex = 3;
            this.tpFriend3.Text = "Friend 3";
            this.tpFriend3.UseVisualStyleBackColor = true;
            // 
            // tpFriend4
            // 
            this.tpFriend4.Controls.Add(this.lbFriend4);
            this.tpFriend4.Location = new System.Drawing.Point(4, 22);
            this.tpFriend4.Name = "tpFriend4";
            this.tpFriend4.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend4.Size = new System.Drawing.Size(608, 298);
            this.tpFriend4.TabIndex = 4;
            this.tpFriend4.Text = "Friend 4";
            this.tpFriend4.UseVisualStyleBackColor = true;
            // 
            // lbMainPage
            // 
            this.lbMainPage.FormattingEnabled = true;
            this.lbMainPage.Location = new System.Drawing.Point(7, 11);
            this.lbMainPage.Name = "lbMainPage";
            this.lbMainPage.Size = new System.Drawing.Size(595, 277);
            this.lbMainPage.TabIndex = 0;
            // 
            // lbFriend1
            // 
            this.lbFriend1.FormattingEnabled = true;
            this.lbFriend1.Location = new System.Drawing.Point(7, 11);
            this.lbFriend1.Name = "lbFriend1";
            this.lbFriend1.Size = new System.Drawing.Size(595, 277);
            this.lbFriend1.TabIndex = 1;
            // 
            // lbFriend2
            // 
            this.lbFriend2.FormattingEnabled = true;
            this.lbFriend2.Location = new System.Drawing.Point(7, 11);
            this.lbFriend2.Name = "lbFriend2";
            this.lbFriend2.Size = new System.Drawing.Size(595, 277);
            this.lbFriend2.TabIndex = 1;
            // 
            // lbFriend3
            // 
            this.lbFriend3.FormattingEnabled = true;
            this.lbFriend3.Location = new System.Drawing.Point(7, 11);
            this.lbFriend3.Name = "lbFriend3";
            this.lbFriend3.Size = new System.Drawing.Size(595, 277);
            this.lbFriend3.TabIndex = 1;
            // 
            // lbFriend4
            // 
            this.lbFriend4.FormattingEnabled = true;
            this.lbFriend4.Location = new System.Drawing.Point(7, 11);
            this.lbFriend4.Name = "lbFriend4";
            this.lbFriend4.Size = new System.Drawing.Size(595, 277);
            this.lbFriend4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 391);
            this.Controls.Add(this.tbUpdateString);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.tcDisplay);
            this.Name = "Form1";
            this.Text = "Social Networking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcDisplay.ResumeLayout(false);
            this.tpMainPage.ResumeLayout(false);
            this.tpFriend1.ResumeLayout(false);
            this.tpFriend2.ResumeLayout(false);
            this.tpFriend3.ResumeLayout(false);
            this.tpFriend4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcDisplay;
        private System.Windows.Forms.TabPage tpMainPage;
        private System.Windows.Forms.ListBox lbMainPage;
        private System.Windows.Forms.TabPage tpFriend1;
        private System.Windows.Forms.TabPage tpFriend2;
        private System.Windows.Forms.TabPage tpFriend3;
        private System.Windows.Forms.TabPage tpFriend4;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.TextBox tbUpdateString;
        private System.Windows.Forms.ListBox lbFriend1;
        private System.Windows.Forms.ListBox lbFriend2;
        private System.Windows.Forms.ListBox lbFriend3;
        private System.Windows.Forms.ListBox lbFriend4;
    }
}

