using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRI615
{
	class OwnFiles
	{
		public void Encrypt(string inputFile, string encryptedFile, string keyFile)
		{
			/*
			String plaintext = "";
			if (File.Exists(inputFile) == true)
			{
				StreamReader objReader;
				objReader = new StreamReader(inputFile);

				do
				{
					plaintext = plaintext + objReader.ReadLine() + "\r\n";
				} while (objReader.Peek() != -1);

				objReader.Close();
			}
			else
			{

			}

			String key = "";
			if (File.Exists(inputFile) == true)
			{
				StreamReader objReader;
				objReader = new StreamReader(inputFile);

				do
				{
					key = key + objReader.ReadLine() + "\r\n";
				} while (objReader.Peek() != -1);

				objReader.Close();
			}
			else
			{

			}
			*/

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


			OwnEncrypt(originalBytes, keyBytes, ref encryptedBytes);

			using (FileStream fs = new FileStream(encryptedFile, FileMode.Create))
			{
				fs.Write(encryptedBytes, 0, encryptedBytes.Length);
			}

			/*
			//This array will be used to read the original file into
			byte[] originalBytes;

			//By using the Filestream class, we can read the input file into a byte array.
			using (FileStream fs = new FileStream(inputFile, FileMode.Open))
			{
				originalBytes = new byte[fs.Length];
				fs.Read(originalBytes, 0, originalBytes.Length);
			}

			byte[] keyBytes;

			using (FileStream fs = new FileStream(keyFile, FileMode.Open))
			{
				keyBytes = new byte[fs.Length];
				fs.Read(keyBytes, 0, keyBytes.Length);
			}

			byte[] encryptedBytes = new byte[originalBytes.Length];


			OwnEncrypt(originalBytes, keyBytes, ref encryptedBytes);

			String output = OwnEncryptt(plaintext, key);
			MessageBox.Show(output);
			StreamWriter objWriter;
			objWriter = new StreamWriter(encryptedFile);
			objWriter.WriteLine(output);
			
			using (FileStream fs = new FileStream(encryptedFile, FileMode.Create))
			{
				fs.Write(encryptedBytes, 0, encryptedBytes.Length);
			}*/
		}

		public void OwnEncrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
		{
			for (int i = 0; i < inputBytes.Length; i++)
			{
				outBytes[i] = (byte)(inputBytes[i] + keyBytes[i]);
			}
			/*
			Dictionary<int, char> ASCII = new Dictionary<int, char>();
			string plain = System.Text.Encoding.Unicode.GetString(inputBytes);
			string key = System.Text.Encoding.Unicode.GetString(keyBytes);

			int min = 0;
			int max = 255;

			for (int p = min; p < max; p++)
			{

				// Get ASCII character.
				char c = (char)p;

				ASCII.Add(p, c);
			}


			string ciphertext = "";

			int i = 0;

			foreach (char element in plain)
			{

				int TOrder = ASCII.FirstOrDefault(x => x.Value == element).Key;

				int KOrder = ASCII.FirstOrDefault(x => x.Value == key[i]).Key;

				int Final = (int)(TOrder + KOrder);
				Final += key.Length;
				if (Final > 254) { Final -= 255; }
				ciphertext += ASCII[Final];
				
				i++;

				if (i == key.Length) { i = 0; }
			}
			MessageBox.Show(ciphertext);
			//MessageBox.Show(ciphertext);
			outBytes = Encoding.Unicode.GetBytes(ciphertext);
			//MessageBox.Show(Encoding.UTF8.GetString(outBytes));*/
			
		}

		/*
		public String OwnEncryptt(String plain, String key)
		{

			Dictionary<int, char> ASCII = new Dictionary<int, char>();
			//string plain = System.Text.Encoding.UTF8.GetString(inputBytes);
			//string key = System.Text.Encoding.UTF8.GetString(keyBytes);

			int min = 0;
			int max = 255;

			for (int p = min; p < max; p++)
			{

				// Get ASCII character.
				char c = (char)p;

				ASCII.Add(p, c);
			}


			string ciphertext = "";

			int i = 0;

			foreach (char element in plain)
			{

				int TOrder = ASCII.FirstOrDefault(x => x.Value == element).Key;

				int KOrder = ASCII.FirstOrDefault(x => x.Value == key[i]).Key;

				int Final = (int)(TOrder + KOrder);
				Final += key.Length;
				if (Final > 254) { Final -= 255; }
				ciphertext += ASCII[Final];
				//MessageBox.Show(ciphertext);
				i++;

				if (i == key.Length) { i = 0; }
			}
		
			//MessageBox.Show(ciphertext);
			return ciphertext;
			//outBytes = Encoding.ASCII.GetBytes(ciphertext);
			//MessageBox.Show(Encoding.UTF8.GetString(outBytes));

		}
		*/

		public void Decrypt(string encryptedFile, string keyFile, string decryptedFile)
		{

			/*String textline = "";
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

			//MessageBox.Show(textline);*/

			byte[] encryptedBytes;

			using (FileStream fs = new FileStream(encryptedFile, FileMode.Open))
			{
				encryptedBytes = new byte[fs.Length];
				fs.Read(encryptedBytes, 0, encryptedBytes.Length);
			}
			//string kaas = System.Text.Encoding.UTF8.GetString(encryptedBytes);
			//MessageBox.Show(kaas);

			byte[] keyBytes;
			using (FileStream fs = new FileStream(keyFile, FileMode.Open))
			{
				keyBytes = new byte[fs.Length];
				fs.Read(keyBytes, 0, keyBytes.Length);
			}
			//error because of this
			byte[] decryptedData = new byte[encryptedBytes.Length];
			OwnDecrypt(encryptedBytes, keyBytes, ref decryptedData);

			using (FileStream fs = new FileStream(decryptedFile, FileMode.Create))
			{
				fs.Write(decryptedData, 0, decryptedData.Length);
			}
		}

		public void OwnDecrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
		{

			for (int i = 0; i < inputBytes.Length; i++)
			{
				outBytes[i] = (byte)(inputBytes[i] - keyBytes[i]);
			}
			/*
			Dictionary<int, char> ASCII = new Dictionary<int, char>();
			string mixed = System.Text.Encoding.Unicode.GetString(inputBytes);
			string key = System.Text.Encoding.Unicode.GetString(keyBytes);
			MessageBox.Show(mixed);
			int min = 0;
			int max = 255;

			for (int p = min; p < max; p++)
			{

				// Get ASCII character.
				char c = (char)p;

				ASCII.Add(p, c);
			}


			string plaintext = "";

			int i = 0;

			foreach (char element in mixed)
			{

				int TOrder = ASCII.FirstOrDefault(x => x.Value == element).Key;

				int KOrder = ASCII.FirstOrDefault(x => x.Value == key[i]).Key;

				int Final = (int)(TOrder - KOrder);
				Final -= key.Length;
				if (Final < 0) { Final += 255; }
				plaintext += ASCII[Final];
				//MessageBox.Show(plaintext);
				i++;

				if (i == key.Length) { i = 0; }
			}
			
			outBytes = Encoding.Unicode.GetBytes(plaintext);*/

		}
	}
}
