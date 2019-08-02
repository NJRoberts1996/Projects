using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRI615
{
	class OwnText
	{

		public String Encrypt(String plain, String key)
		{

			Dictionary<int, char> unicode = new Dictionary<int, char>();
			/*byte[] originalBytes;
			originalBytes = Encoding.Unicode.GetBytes(plain);

			byte[] keyBytes;
			keyBytes = Encoding.Unicode.GetBytes(key);

			byte[] outBytes = new byte[originalBytes.Length];

			for (int i = 0; i < originalBytes.Length; i++)
			{
				outBytes[i] = (byte)(originalBytes[i] + keyBytes[i]);
			}

		return System.Text.Encoding.Unicode.GetString(outBytes);*/
			
			int min = 0 ;
			int max = 1000;

			for (int p = min; p < max; p++)
			{
				
				// Get Unicode character.
				char c = (char)p;

				unicode.Add(p,c);
			}


			string ciphertext = "";

			int i = 0;

			foreach (char element in plain)
			{
				
					int TOrder = unicode.FirstOrDefault(x => x.Value == element).Key;
				
					int KOrder = unicode.FirstOrDefault(x => x.Value == key[i]).Key;

					int Final = (int)(TOrder + KOrder);
				
					if (Final > 255) { Final -= 256; }
					ciphertext += unicode[Final];
					//MessageBox.Show(ciphertext);
					i++;
				
				if (i == key.Length) { i = 0; }
			}
			return ciphertext;
		}

		public String Decrypt(String mixed, String key)
		{
			
			Dictionary<int, char> unicode = new Dictionary<int, char>();


			int min = 0;
			int max = 1000;

			for (int p = min; p < max; p++)
			{

				// Get ASCII character.
				char c = (char)p;

				unicode.Add(p, c);
			}


			string plaintext = "";

			int i = 0;

			foreach (char element in mixed)
			{

				int TOrder = unicode.FirstOrDefault(x => x.Value == element).Key;

				int KOrder = unicode.FirstOrDefault(x => x.Value == key[i]).Key;

				int Final = (int)(TOrder - KOrder);
				
				if (Final < 0) { Final += 256; }
				plaintext += unicode[Final];
				//MessageBox.Show(plaintext);
				i++;

				if (i == key.Length) { i = 0; }
			}
			return plaintext;
		}
	}
}
