using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRI615
{
    class TranspositionFiles
    {
        public void Transpose(string inputFile, string outputFile, int state)
        {
            //This creates an array for the bytes of the file
            byte[] originalBytes; 
            //This reads the file into the byte array
            using (FileStream fs = new FileStream(inputFile, FileMode.Open))
            {
                originalBytes = new byte[fs.Length];
                
                fs.Read(originalBytes, 0, originalBytes.Length);
               // encodedData = Convert.ToBase64String(originalBytes, Base64FormattingOptions.InsertLineBreaks);
            }

            //This creates a duplicate array which is then reversed.
            byte[] inputArray = originalBytes;
            Array.Reverse(inputArray, 0, inputArray.Length);

            //This writes to a new file with the .trans extension if it is used for encryption, if it is decryption it removes the .trans extension and decrypts it, if it doesnt have the 
            //.trans extension it skips the removal part.
            if (state == 1)
            {
                using (FileStream fs = new FileStream(outputFile + ".trans", FileMode.Create))
                {
                    fs.Write(inputArray, 0, inputArray.Length);
                }
            }
            else
            {
                if (inputFile.Contains(".trans"))
                {
                    inputFile.Replace(".trans", "");
                    using (FileStream fs = new FileStream(outputFile, FileMode.Create))
                    {
                        fs.Write(inputArray, 0, inputArray.Length);
                    }
                }
                else
                {
                    using (FileStream fs = new FileStream(outputFile, FileMode.Create))
                    {
                        fs.Write(inputArray, 0, inputArray.Length);
                    }
                }

            }


        }
    }
}
