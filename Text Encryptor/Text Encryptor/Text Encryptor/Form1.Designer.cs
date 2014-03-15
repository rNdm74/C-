namespace Text_Encryptor
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
            this.gbEncryptionMethod = new System.Windows.Forms.GroupBox();
            this.rbPlainText = new System.Windows.Forms.RadioButton();
            this.rbRot13 = new System.Windows.Forms.RadioButton();
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.lbEncryptedOutput = new System.Windows.Forms.ListBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.gbEncryptionMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncryptionMethod
            // 
            this.gbEncryptionMethod.Controls.Add(this.rbRot13);
            this.gbEncryptionMethod.Controls.Add(this.rbPlainText);
            this.gbEncryptionMethod.Location = new System.Drawing.Point(13, 13);
            this.gbEncryptionMethod.Name = "gbEncryptionMethod";
            this.gbEncryptionMethod.Size = new System.Drawing.Size(259, 101);
            this.gbEncryptionMethod.TabIndex = 0;
            this.gbEncryptionMethod.TabStop = false;
            this.gbEncryptionMethod.Text = "Encryption Method";
            // 
            // rbPlainText
            // 
            this.rbPlainText.AutoSize = true;
            this.rbPlainText.Checked = true;
            this.rbPlainText.Location = new System.Drawing.Point(22, 34);
            this.rbPlainText.Name = "rbPlainText";
            this.rbPlainText.Size = new System.Drawing.Size(72, 17);
            this.rbPlainText.TabIndex = 0;
            this.rbPlainText.TabStop = true;
            this.rbPlainText.Text = "Plain Text";
            this.rbPlainText.UseVisualStyleBackColor = true;
            // 
            // rbRot13
            // 
            this.rbRot13.AutoSize = true;
            this.rbRot13.Location = new System.Drawing.Point(22, 58);
            this.rbRot13.Name = "rbRot13";
            this.rbRot13.Size = new System.Drawing.Size(63, 17);
            this.rbRot13.TabIndex = 1;
            this.rbRot13.TabStop = true;
            this.rbRot13.Text = "ROT 13";
            this.rbRot13.UseVisualStyleBackColor = true;
            // 
            // tbUserInput
            // 
            this.tbUserInput.Location = new System.Drawing.Point(13, 121);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(259, 20);
            this.tbUserInput.TabIndex = 1;
            this.tbUserInput.Text = "Some Text !!";
            // 
            // lbEncryptedOutput
            // 
            this.lbEncryptedOutput.FormattingEnabled = true;
            this.lbEncryptedOutput.Location = new System.Drawing.Point(13, 148);
            this.lbEncryptedOutput.Name = "lbEncryptedOutput";
            this.lbEncryptedOutput.Size = new System.Drawing.Size(259, 82);
            this.lbEncryptedOutput.TabIndex = 2;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(13, 237);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(259, 35);
            this.bEncrypt.TabIndex = 3;
            this.bEncrypt.Text = "Encrypt";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.lbEncryptedOutput);
            this.Controls.Add(this.tbUserInput);
            this.Controls.Add(this.gbEncryptionMethod);
            this.Name = "Form1";
            this.Text = "Text Encryptor";
            this.gbEncryptionMethod.ResumeLayout(false);
            this.gbEncryptionMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncryptionMethod;
        private System.Windows.Forms.RadioButton rbRot13;
        private System.Windows.Forms.RadioButton rbPlainText;
        private System.Windows.Forms.TextBox tbUserInput;
        private System.Windows.Forms.ListBox lbEncryptedOutput;
        private System.Windows.Forms.Button bEncrypt;
    }
}

