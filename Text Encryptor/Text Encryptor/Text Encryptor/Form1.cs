using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Text_Encryptor
{
    public partial class Form1 : Form
    {
        private CypherMachine cypherMachine;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            if (rbPlainText.Checked)
            {
                cypherMachine = new PlainText();
            }
            else
            {
                cypherMachine = new Rot13();
            }

            lbEncryptedOutput.Items.Add(cypherMachine.Encrypt(tbUserInput.Text));
        }
    }
}
