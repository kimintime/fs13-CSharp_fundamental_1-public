using System;
using System.Globalization;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
        }
        //This is the real solution
        // static string toTitleCase(string input)
        // {
        //     TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        //     input = textInfo.ToTitleCase(input);

        //     return input;
        // }

        //This is the nonsense
        static string toTitleCase(string input)
        {
            var build = new System.Text.StringBuilder();
            bool word = true;

            foreach (char letter in input)
            {
                if (word)
                {
                    build.Append((char)(letter + 'A' - 'a'));
                    word = false;
                }
                else  if (letter == ' ')
                {
                    word = true;
                    build.Append(' ');
                }
                else
                {
                    if((short)letter >= 'a' && (short)letter <= 'z')
                    {
                        build.Append(letter);
                    }
                    else
                    {
                        build.Append((char)(letter - 'A' + 'a'));
                    }
                }
            }

            return build.ToString();
        }

        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            int array1Rows = array1.GetLength(0);
            int array1Cols = array1.GetLength(1);

            int array2Rows = array2.GetLength(0);
            int array2Cols = array2.GetLength(1);

            int[,] result = new int[array1Cols, array2Rows];

            if (array1Rows != array2Cols)
            {
                throw new InvalidOperationException("Matrices do not have the same dimension.");
            }
            else
            {
                for (int i = 0; i < array1Rows; i++)
                {
                    for (int j = 0; j < array2Cols; j++)
                    {
                        for (int k = 0; k < array1Cols; k++)
                        {
                            result[i, j] += array1[i, k] * array2[k, j];
                        }

                        Console.WriteLine(result[i, j]);
                    }
                }
            }

            return result;
        }
    }
}
