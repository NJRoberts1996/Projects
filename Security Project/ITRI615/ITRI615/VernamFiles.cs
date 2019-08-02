using System;
using System.IO;
using System.Windows.Forms;

namespace ITRI615
{
    internal class VernamFiles
    {
        //This is the method to encrypt a file, it receives the location of the input file, the new name of the encrypted file and the key file's location
        public void Encrypt(string inputFile, string encryptedFile, string keyFile)
        {
            //This array will be used to read the original file into
            byte[] originalBytes;

            //By using the Filestream class, we can read the input file into a byte array.
            using (FileStream fs = new FileStream(inputFile, FileMode.Open))
            {
                originalBytes = new byte[fs.Length];
                fs.Read(originalBytes, 0, originalBytes.Length);
            }

            //This creates an array for the key, it is the exact same length as the original file's byte array. A random byte is generated and the 
            //key array is filled up with random bytes.
            byte[] keyBytes = new byte[originalBytes.Length];
            Random rand = new Random();
            rand.NextBytes(keyBytes);

            //This writes the key bytes to the keyfile.
            using (FileStream fs = new FileStream(keyFile, FileMode.Create))
            {
                fs.Write(keyBytes, 0, keyBytes.Length);
            }

            //This creates an exact replica array of the original byte array. The arrays are passed on to the encryption method.
            byte[] encryptedBytes = new byte[originalBytes.Length];
            VernamEncrypt(originalBytes, keyBytes, ref encryptedBytes);

            //This writes the encrypted bytes to the encrypted file
            using (FileStream fs = new FileStream(encryptedFile + ".ver", FileMode.Create))
            {
                fs.Write(encryptedBytes, 0, encryptedBytes.Length);
            }

        }

        //This is where the actual application of the vernam algorithm occurs, it receives an input array, a key array it passes an array out.
        private void VernamEncrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
        {
            //This is a check to ensure that the input byte array, output array and key array are all exactly the same length.
            if (inputBytes.Length != keyBytes.Length || (keyBytes.Length != outBytes.Length))
            {
                MessageBox.Show("Byte-array lengths differ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //This loop makes use of exclusively or to create the new output array values.
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    outBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i]);
                }
            }
        }

        //This is where the decryption occurs.
        public void Decrypt(string encryptedFile, string keyFile, string decryptedFile)
        {
            //This creates an array for the encrypted bytes.
            byte[] encryptedBytes;

            //By using the Filestream class, we can read the encrypted file into a byte array.
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
            //This creates an array for the decrypted data with the exact lenght of the encrypted file, it then uses the vernam encryption method
            //to decrypt the message, in short it makes the encrypted byte array the input array, the keybyte array remains the key and it sends out a decrypted array.
            byte[] decryptedData = new byte[encryptedBytes.Length];
            VernamEncrypt(encryptedBytes, keyBytes, ref decryptedData);

            //The decrypted array is written to a file.
            if (encryptedFile.Contains(".ver"))
            {
                encryptedFile.Replace(".ver", "");
                using (FileStream fs = new FileStream(decryptedFile, FileMode.Create))
                {
                    fs.Write(decryptedData, 0, decryptedData.Length);
                }
            }
            else
            {
                using (FileStream fs = new FileStream(decryptedFile, FileMode.Create))
                {
                    fs.Write(decryptedData, 0, decryptedData.Length);
                }
            }

        }
    }
}