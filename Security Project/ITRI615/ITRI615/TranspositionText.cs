using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRI615
{
    
    class TranspositionText : CreateDictionary
    {
        //int[] key;

        //public void RowTransposition(int key)
        //{
        //    this.key = key.ToString().Select(o => Convert.ToInt32(o)).ToArray();
        //}

        //#region Public Methods

        //public string Encrypt(string plainText)
        //{
        //    int columns = 0, rows = 0;
        //    Dictionary<int, int> rowsPositions = FillPositionsDictionary(plainText, ref columns, ref rows);
        //    char[,] matrix2 = new char[rows, columns];

        //    //Fill Matrix
        //    int charPosition = 0;
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < columns; j++)
        //        {
        //            if (charPosition < plainText.Length)
        //            {
        //                matrix2[i, j] = plainText[charPosition];
        //            }
        //            else
        //            {
        //                matrix2[i, j] = '*';
        //            }

        //            charPosition++;
        //        }
        //    }

        //    string result = "";

        //    for (int i = 0; i < columns; i++)
        //    {
        //        for (int j = 0; j < rows; j++)
        //        {
        //            result += matrix2[j, rowsPositions[i + 1]];
        //        }

        //        result += " ";
        //    }

        //    return result;
        //}

        //public string Decrypt(string cipherText)
        //{
        //    int columns = 0, rows = 0;
        //    Dictionary<int, int> rowsPositions = FillPositionsDictionary(cipherText, ref columns, ref rows);
        //    char[,] matrix = new char[rows, columns];

        //    //Fill Matrix
        //    int charPosition = 0;
        //    for (int i = 0; i < columns; i++)
        //    {
        //        for (int j = 0; j < rows; j++)
        //        {
        //            matrix[j, rowsPositions[i + 1]] = cipherText[charPosition];
        //            charPosition++;
        //        }
        //    }

        //    string result = "";

        //    foreach (char c in matrix)
        //    {
        //        if (c != '*' && c != ' ')
        //        {
        //            result += c;
        //        }
        //    }

        //    return result;
        //}

        //#endregion

        //#region Private Methods

        //private Dictionary<int, int> FillPositionsDictionary(string token, ref int columns, ref int rows)
        //{
        //    var result = new Dictionary<int, int>();
        //    columns = key.Length;
        //    rows = (int)Math.Ceiling((double)token.Length / (double)columns);
        //    /*  we need something to tell where to start
        //     *        4  3  1  2  5  6  7               Key
        //     *        
        //     *        0  1  2  3  4  5  6               Value
        //     */
        //    //attack postponed until two am xyz
        //    for (int i = 0; i < columns; i++)
        //    {
        //        result.Add(key[i], i);
        //    }

        //    return result;
        //}

        //#endregion

            readonly int key;

            public TranspositionText(int key)
            {
                this.key = key;
            }

            #region Public Methods

            public string Encrypt(string plainText)
            {
                return Process(plainText, Mode.Encrypt);
            }

            public string Decrypt(string cipherText)
            {
                return Process(cipherText, Mode.Decrypt);
            }

            #endregion

            #region Private Methods
            
            //
            private string Process(string message, Mode mode)
            {
                int rows = key;
                int columns = (int)Math.Ceiling((double)message.Length / (double)rows);
                char[,] matrix = FillArray(message, rows, columns, mode);
                string result = "";

                foreach (char c in matrix)
                {
                    result += c;
                }

                return result;
            }
            
            //This creates a table with rows and columns, the coulmns are determined by the length of the string.
            //The mode determines where the string ends up going
            private char[,] FillArray(string message, int rowsCount, int columnsCount, Mode mode)
            {
                int charPosition = 0;
                int length = 0, width = 0;
                char[,] matrix = new char[rowsCount, columnsCount];

                switch (mode)
                {
                    case Mode.Encrypt:
                        length = rowsCount;
                        width = columnsCount;
                        break;
                    case Mode.Decrypt:
                        matrix = new char[columnsCount, rowsCount];
                        width = rowsCount;
                        length = columnsCount;
                        break;
                }

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (charPosition < message.Length)
                        {
                            matrix[j, i] = message[charPosition];
                        }
                        else
                        {
                            matrix[j, i] = '*';
                        }

                        charPosition++;
                    }
                }

                return matrix;
            }

            #endregion
        
    }

    //This is an internal class to set the mode of the algorithm, it wasn't neccessary to do it this way but it was one of the ways to accomplish this.
    internal enum Mode
    {
        Encrypt, Decrypt
    }

    //This is an internal class for the common logic contained in the rail fence transposition algorithm
    internal class Common
    {
        //This retrieves the new value for a given letter based on the numerical value of the alphabet character and the key
        internal static int GetAlphabetPosition(int textPosition, int keyPosition, Mode mode)
        {
            int result = 0;

            switch (mode)
            {
                case Mode.Encrypt:
                    result = (textPosition + keyPosition) % 26;
                    break;
                case Mode.Decrypt:
                    result = textPosition - keyPosition;

                    if (result < 0)
                    {
                        result += 26;
                    }

                    break;
            }

            return result;
        }


        //This 'shifts' the keys into the correct position, it receives the alphabet in numerical order, the key value and the input string, it then returns the new string result
        internal static string Shift(string token, string Key, Mode mode, Dictionary<char, int> alphabetSorted)
        {
            string result = "";
            int textPosition, keyPosition, resPosition = 0;
            for (int i = 0; i < token.Length; i++)
            {
                textPosition = alphabetSorted[token[i]];
                keyPosition = alphabetSorted[Key[i]];
                resPosition = GetAlphabetPosition(textPosition, keyPosition, mode);
                result += alphabetSorted.Keys.ElementAt(resPosition);
            }
            return result;
        }        
    }
}
