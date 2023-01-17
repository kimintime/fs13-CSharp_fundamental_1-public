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
        static string toTitleCase(string input)
        {
            /* Write your code here */

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            input = textInfo.ToTitleCase(input);

            return input;

        }

        //This is clearly wrong. 
        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            /* Write your code here */

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++ ) 
                {
                    //something

                    for (int k = 0; k < 4; k++) 
                    {
                        //something
                    }
                }
            }

            return result;
        }
    }
}
