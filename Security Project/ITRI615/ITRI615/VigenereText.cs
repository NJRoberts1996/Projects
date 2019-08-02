using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRI615
{
    class VigenereText
    {

        public String VigenereEncrypt(String plain, String key)
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
            return ciphertext;
        
        }




        public String VigenereDecrypt(String mixed, String key)
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

            key = key.ToUpper();
            mixed = mixed.ToUpper();

            string plaintext = "";

            int i = 0;

            foreach (char element in mixed)
            {
                if (!Char.IsLetter(element)) { plaintext += element; } //If character is not an alphabetical value
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
            return plaintext;
        }
        }
}
