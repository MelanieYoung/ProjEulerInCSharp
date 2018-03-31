using System;
using System.Configuration;
using System.IO;
using System.Numerics;

namespace ProjEulerInCSharp
{
    public class Problems11To20
    {
        public static void PrintAllProblemsResults()
        {
            Problems11To20 results11to20 = new Problems11To20();
            //results11to20.Problem11();
            //results11to20.Problem16();
            results11to20.Problem17();
        }

        public void Problem11() // Largest product in a grid
        {
            string path = ConfigurationManager.AppSettings["PathToProblem11"];
            StreamReader reader = new StreamReader(path);
            string fileContent = reader.ReadToEnd().Replace("\r\n", " # ");
            reader.Close();

            int largestProduct = 0, currentProduct = 1, currentNumber = 0;
            int i = 0, j = 0;

            //for (int index = 0; index < fileContent.Length; index += 62)
            //{
            //    i = 0; j = 0;
            //    // Vertical
            //    for (int v = index; v < index + 12; v += 3)
            //    {
            //        j++;
            //        matrix[i] = new int[20];
                    
            //        if (!fileContent[v].ToString().Contains("#"))
            //        {
            //            matrix[i][j] = Convert.ToInt32(fileContent[v].ToString() + fileContent[v + 1].ToString());

            //            if (currentNumber == 0)
            //                break;

            //            currentProduct *= currentNumber;
            //        }
            //        else
            //            break;
            //    }
            //    i++;

            //    if (currentProduct > largestProduct)
            //        largestProduct = currentProduct;

            //    currentProduct = 1;

            //    for (int h = index; h < index; h += 3)
            //    {

            //    }
            //}

            Console.WriteLine("Problem 11: " + largestProduct);
        }

        public void Problem16() // Power digit sum
        {
            BigInteger ultraPower = 2;
            int sumOfChars = 0;

            for (int i = 1; i < 1000; i++)
            {
                ultraPower *= 2;
            }

            string powerResult = ultraPower.ToString();

            foreach (char eachChar in powerResult)
            {
                sumOfChars += int.Parse(eachChar.ToString());
            }

            Console.WriteLine("Problem 16:" + sumOfChars);
        }

        public void Problem17()
        {
            int totalLetters = 0;
            string numberName = string.Empty;

            Console.WriteLine(HelperFunctions.GetNumberName(666));
            Console.WriteLine(HelperFunctions.GetNumberName(1000));
            Console.WriteLine(HelperFunctions.GetNumberName(10));
            Console.WriteLine(HelperFunctions.GetNumberName(100));
            Console.WriteLine(HelperFunctions.GetNumberName(2));


            //for (int i = 1; i <= 1000; i++)
            //{
            //    numberName = HelperFunctions.GetNumberName(i);
            //    totalLetters += numberName.Length;
            //}

            Console.WriteLine("Problem 17: " + totalLetters);
        }
    }
}
