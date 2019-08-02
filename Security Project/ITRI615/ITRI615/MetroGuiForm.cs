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
    public partial class MetroGuiForm : MetroFramework.Forms.MetroForm
    {
        string inputFile, outputFile, keyFile;
        VernamFiles vern = new VernamFiles();
        VigenereFiles vig = new VigenereFiles();
        TranspositionFiles trans = new TranspositionFiles();
		OwnFiles own = new OwnFiles();

        
        public MetroGuiForm()
        {
            InitializeComponent();
        }

        private void keyFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                keyFile = openFileDialog1.FileName;
                keyFileTxt.Text = keyFile;
            }

        }

        private void outputFileBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = saveFileDialog1.FileName;
                saveFileDialog1.DefaultExt = "xyz";
                outputFileTxt.Text = outputFile;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString() == "Vernam")
            {
               // MessageBox.Show("Vernam");
                if (EncryptRdio.Checked)
                {
                    vern.Encrypt(inputFile, outputFile, keyFile);
                    MessageBox.Show("Sucessfully encrypted the file with the vernam encryption!");
                }
                else if (DecryptRdio.Checked)
                {
                    vern.Decrypt(inputFile, keyFile, outputFile);
                    MessageBox.Show("Sucessfully decrypted the file with the vernam encryption!");
                }
                
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Vigenere")
            {
                if (EncryptRdio.Checked)
                {
                    vig.Encrypt(inputFile, outputFile, keyFile);
                    MessageBox.Show("Sucessfully encrypted the file with the vigenere encryption!");
                }
                else if (DecryptRdio.Checked)
                {
                    vig.Decrypt(inputFile, keyFile, outputFile);
                    MessageBox.Show("Sucessfully decrypted the file with the vigenere encryption!");
                }
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Transposition")
            {
                if (EncryptRdio.Checked)
                {
                    trans.Transpose(inputFile,outputFile, 1);
                    //trans.StartTransposition(inputFile, outputFile, keyFile);
                    MessageBox.Show("Sucessfully encrypted the file with the transposition encryption!");
                }
                else if (DecryptRdio.Checked)
                {
                    trans.Transpose(inputFile, outputFile, 0);
                   // trans.undoTransposition(inputFile, outputFile);
                    MessageBox.Show("Sucessfully decrypted the file with the transposition encryption!");
                }
            }
			else if (metroComboBox1.SelectedItem.ToString() == "Own")
			{
				if (EncryptRdio.Checked)
				{
					own.Encrypt(inputFile, outputFile, keyFile);
				
					MessageBox.Show("Sucessfully encrypted the file with our own encryption!");
				}
				else if (DecryptRdio.Checked)
				{
					own.Decrypt(inputFile, keyFile, outputFile);
					
					MessageBox.Show("Sucessfully decrypted the file with our own encryption!");
				}
			}
			else
            {
                MessageBox.Show("Error 403 Occured!");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroGuiForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog1.FileName;
                inputFileTxt.Text = inputFile;
            }
        }
    }
}
