using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRI615
{
    class VigenereFiles
    {

        public void Encrypt(string inputFile, string encryptedFile, string keyFile)
        {

			String textline = "";
			if (File.Exists(inputFile) == true)
			{
				StreamReader objReader;
				objReader = new StreamReader(inputFile);

				do
				{
					textline = textline + objReader.ReadLine() + "\r\n";
				} while (objReader.Peek() != -1);

				objReader.Close();
			}
			else
			{

			}

			//MessageBox.Show(textline);

			byte[] originalBytes;

            using (FileStream fs = new FileStream(inputFile, FileMode.Open))
            {
                originalBytes = new byte[fs.Length];
                fs.Read(originalBytes, 0, originalBytes.Length);
            }

            byte[] keyBytes = new byte[originalBytes.Length];
            byte[] temp;
            using (FileStream fs = new FileStream(keyFile, FileMode.Open))
            {
                temp = new byte[fs.Length];
                fs.Read(temp, 0, temp.Length);
            }
            if (temp.Length < originalBytes.Length)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    keyBytes[i] = temp[i];
                }
                int p = temp.Length;
                for (int i = temp.Length; i < keyBytes.Length; i++)
                {

                    if (i % temp.Length == 0)
                    {
                        p -= temp.Length;
                    }

                    keyBytes[i] = temp[p];
                    p++;
                }
            }
            else
            {
                for (int i = 0; i < originalBytes.Length; i++)
                {
                    keyBytes[i] = temp[i];
                }
            }
            
            using (FileStream fs = new FileStream(keyFile, FileMode.Create))
            {
                fs.Write(keyBytes, 0, keyBytes.Length);
            }

            byte[] encryptedBytes = new byte[originalBytes.Length];


            VigenereEncrypt(originalBytes, keyBytes, ref encryptedBytes);

            using (FileStream fs = new FileStream(encryptedFile, FileMode.Create))
            {
                fs.Write(encryptedBytes, 0, encryptedBytes.Length);
            }
        }

        private void VigenereEncrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
        {
            Dictionary<sbyte, char> AlphabetOrder = new Dictionary<sbyte, char>();
            AlphabetOrder.Add(0, 'A');
            AlphabetOrder.Add(1, 'B');
            AlphabetOrder.Add(2, 'C');
            AlphabetOrder.Add(3, 'D');
            AlphabetOrder.Add(4, 'E');
            AlphabetOrder.Add(5, 'F');
            AlphabetOrder.Add(6, 'G');
            AlphabetOrder.Add(7, 'H');
            AlphabetOrder.Add(8, 'I');
            AlphabetOrder.Add(9, 'J');
            AlphabetOrder.Add(10, 'K');
            AlphabetOrder.Add(11, 'L');
            AlphabetOrder.Add(12, 'M');
            AlphabetOrder.Add(13, 'N');
            AlphabetOrder.Add(14, 'O');
            AlphabetOrder.Add(15, 'P');
            AlphabetOrder.Add(16, 'Q');
            AlphabetOrder.Add(17, 'R');
            AlphabetOrder.Add(18, 'S');
            AlphabetOrder.Add(19, 'T');
            AlphabetOrder.Add(20, 'U');
            AlphabetOrder.Add(21, 'V');
            AlphabetOrder.Add(22, 'W');
            AlphabetOrder.Add(23, 'X');
            AlphabetOrder.Add(24, 'Y');
            AlphabetOrder.Add(25, 'Z');

            if (inputBytes.Length != keyBytes.Length || (keyBytes.Length != outBytes.Length))
            {
                MessageBox.Show("Byte-array lengths differ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string plain = System.Text.Encoding.UTF8.GetString(inputBytes);
                string key = System.Text.Encoding.UTF8.GetString(keyBytes);
				key = key.ToUpper();
                plain = plain.ToUpper();
				string ciphertext = "";

                int i = 0;

                foreach (char element in plain)
                {
                    if (!Char.IsLetter(element)) { ciphertext += element; } //If character is not an alphabetical value
                    else
                    {
                        sbyte TOrder = AlphabetOrder.FirstOrDefault(x => x.Value == element).Key; //Get the dictionary TKey by the TValue
                        sbyte KOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key;
                        sbyte Final = (sbyte)(TOrder + KOrder);
                        if (Final > 25) { Final -= 26; }
                        ciphertext += AlphabetOrder[Final];
                        i++;
                    }
                    if (i == key.Length) { i = 0; }
                }
                outBytes = Encoding.ASCII.GetBytes(ciphertext);
                

             
            }
        }

        private void VigenereDecrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
        {
            Dictionary<sbyte, char> AlphabetOrder = new Dictionary<sbyte, char>();
            AlphabetOrder.Add(0, 'A');
            AlphabetOrder.Add(1, 'B');
            AlphabetOrder.Add(2, 'C');
            AlphabetOrder.Add(3, 'D');
            AlphabetOrder.Add(4, 'E');
            AlphabetOrder.Add(5, 'F');
            AlphabetOrder.Add(6, 'G');
            AlphabetOrder.Add(7, 'H');
            AlphabetOrder.Add(8, 'I');
            AlphabetOrder.Add(9, 'J');
            AlphabetOrder.Add(10, 'K');
            AlphabetOrder.Add(11, 'L');
            AlphabetOrder.Add(12, 'M');
            AlphabetOrder.Add(13, 'N');
            AlphabetOrder.Add(14, 'O');
            AlphabetOrder.Add(15, 'P');
            AlphabetOrder.Add(16, 'Q');
            AlphabetOrder.Add(17, 'R');
            AlphabetOrder.Add(18, 'S');
            AlphabetOrder.Add(19, 'T');
            AlphabetOrder.Add(20, 'U');
            AlphabetOrder.Add(21, 'V');
            AlphabetOrder.Add(22, 'W');
            AlphabetOrder.Add(23, 'X');
            AlphabetOrder.Add(24, 'Y');
            AlphabetOrder.Add(25, 'Z');

            if (inputBytes.Length != keyBytes.Length || (keyBytes.Length != outBytes.Length))
            {
                MessageBox.Show("Byte-array lengths differ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mixed = System.Text.Encoding.UTF8.GetString(inputBytes);
                string key = System.Text.Encoding.UTF8.GetString(keyBytes);
				key = key.ToUpper();
                mixed = mixed.ToUpper();
				string plaintext = "";
                int i = 0;
                
                foreach (char element in mixed)
                {
                    if (!Char.IsLetter(element))
					{
						plaintext += element;
					} //If character is not an alphabetical value
                    else
                    {
                        sbyte TOrder = AlphabetOrder.FirstOrDefault(x => x.Value == element).Key; //Get the dictionary TKey by the TValue
                        sbyte KOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key;
                        sbyte Final = (sbyte)(TOrder - KOrder);
                        if (Final < 0) { Final += 26; }
                        plaintext += AlphabetOrder[Final];
                        i++;
                    }
                    if (i == key.Length) { i = 0; }
                }
                outBytes = Encoding.ASCII.GetBytes(plaintext);
            }
        }

        public void Decrypt(string encryptedFile, string keyFile, string decryptedFile)
        {

			String textline = "";
			if (File.Exists(encryptedFile) == true)
			{
				StreamReader objReader;
				objReader = new StreamReader(encryptedFile);

				do
				{
					textline = textline + objReader.ReadLine() + "\r\n";
				} while (objReader.Peek() != -1);

				objReader.Close();
			}
			else
			{

			}

			//MessageBox.Show(textline);

			byte[] encryptedBytes;

            using (FileStream fs = new FileStream(encryptedFile, FileMode.Open))
            {
                encryptedBytes = new byte[fs.Length];
                fs.Read(encryptedBytes, 0, encryptedBytes.Length);
            }

            byte[] keyBytes;
            using (FileStream fs = new FileStream(keyFile, FileMode.Open))
            {
                keyBytes = new byte[fs.Length];
                fs.Read(keyBytes, 0, keyBytes.Length);
            }
            //error because of this
            byte[] decryptedData = new byte[encryptedBytes.Length];
            VigenereDecrypt(encryptedBytes, keyBytes, ref decryptedData);

            using (FileStream fs = new FileStream(decryptedFile, FileMode.Create))
            {
                fs.Write(decryptedData, 0, decryptedData.Length);
            }
        }
    }
}
