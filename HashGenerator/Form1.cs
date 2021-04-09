using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes
                    ($"{loginTextBox.Text}{passTextBox.Text}"));
                var hash = "H1_" + BitConverter.ToString(bytes);
                hashTextBox.Text = hash;
                if (copyToClipboardCheckBox.Checked)
                {
                    Clipboard.SetText(hash);
                }
            }
        }

        private void ValidateTextBoxes()
        {
            if (loginTextBox.Text.Length != 0 && passTextBox.Text.Length != 0)
            {
                generateHashBtn.Enabled = true;
            }
            else
            {
                generateHashBtn.Enabled = false;
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }
    }
}