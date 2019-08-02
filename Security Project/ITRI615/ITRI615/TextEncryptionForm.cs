using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRI615
{
    public partial class TextEncryptionForm : MetroFramework.Forms.MetroForm
    {
        string inputText, keyText, OutputText;
        

        public TextEncryptionForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            inputText = inputFileTxt.Text;
            keyText = keyFileTxt.Text;
            OutputText = outputFileTxt.Text;

            if (inputText != ""&& keyText != "" && (int.TryParse(keyText, out int x)|| EncryptionMethodcmbx.SelectedItem.ToString() == "Vigenere" || EncryptionMethodcmbx.SelectedItem.ToString() == "Own"))
            {



				if (EncryptionMethodcmbx.SelectedItem.ToString() == "Vernam")
				{
					if (EncryptRdio.Checked)
					{
						VernamText vern = new VernamText();
						outputFileTxt.Text = vern.EncryptOrDecrypt(inputText, keyText);
						//MessageBox.Show("Sucessfully encrypted the file with the vernam encryption!");
					}
					else if (DecryptRdio.Checked)
					{
						VernamText vern = new VernamText();
						outputFileTxt.Text = vern.EncryptOrDecrypt(inputText, keyText);
						// MessageBox.Show("Sucessfully decrypted the file with the vernam encryption!");
					}

				}
				else if (EncryptionMethodcmbx.SelectedItem.ToString() == "Transposition")
				{
					if (EncryptRdio.Checked)
					{
						int test, keyValue;

						if (int.TryParse(keyFileTxt.Text, out test))
						{
							TranspositionText trans = new TranspositionText(keyValue = Convert.ToInt32(keyFileTxt.Text));

							// trans.RowTransposition(keyValue);
							outputFileTxt.Text = trans.Encrypt(inputText);
						}

						//MessageBox.Show("Sucessfully encrypted the file with the vernam encryption!");
					}
					else if (DecryptRdio.Checked)
					{
						int test, keyValue;

						if (int.TryParse(keyFileTxt.Text, out test))
						{
							TranspositionText trans = new TranspositionText(keyValue = Convert.ToInt32(keyFileTxt.Text));

							// trans.RowTransposition(keyValue);
							outputFileTxt.Text = trans.Decrypt(inputText);
						}
						//outputFileTxt.Text = trans.Decrypt(inputText);
						// MessageBox.Show("Sucessfully decrypted the file with the vernam encryption!");
					}
				}
				else if (EncryptionMethodcmbx.SelectedItem.ToString() == "Vigenere")
				{
					if (EncryptRdio.Checked)
					{
						VigenereText vig = new VigenereText();
						outputFileTxt.Text = vig.VigenereEncrypt(inputText, keyText);
					
					}
					else if (DecryptRdio.Checked)
					{
						VigenereText vig = new VigenereText();
						outputFileTxt.Text = vig.VigenereDecrypt(inputText, keyText);
						
					}
				}
				else if (EncryptionMethodcmbx.SelectedItem.ToString() == "Own")
				{
					if (EncryptRdio.Checked)
					{
						OwnText own = new OwnText();
						outputFileTxt.Text = own.Encrypt(inputText, keyText);
					}
					else if (DecryptRdio.Checked)
					{
						OwnText own = new OwnText();
						outputFileTxt.Text = own.Decrypt(inputText, keyText);
					}
				}

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to input text and a numerical key", "Hold up!");
            }


        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void outputFileTxt_Click(object sender, EventArgs e)
        {

        }

        private void keyFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void keyFileTxt_Click(object sender, EventArgs e)
        {

        }

        private void inputFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputFileTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
