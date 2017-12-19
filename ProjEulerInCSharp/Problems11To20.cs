using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEulerInCSharp
{
    public class Problems11To20
    {
        public static void PrintAllProblemsResults()
        {
            Problems11To20 results11to20 = new Problems11To20();
            results11to20.Problem11();
            //results11to20.test();
        }

        public void Problem11() // Largest product in a grid
        {
            StreamReader reader = new StreamReader("D:\\GitHub\\ProjEulerInCSharp\\Problem11.txt");
            string fileContent = reader.ReadToEnd().Replace("\r\n", " # ");
            reader.Close();

            int largestProduct = 0, currentProduct = 1, currentNumber = 0;
            var a = fileContent.Split('#');
            int[,] matrix = new int[20,20];
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

        private bool test()
        {
            int[] sequence = { 1, 2, 1, 2 };

            bool repeatedFound = false, isAlmostIncreasing = true;
            int position = -1, j = 0;

            for (int i = 0; i <= sequence.Length - 2; i++)
            {
                if (i == position)
                    i++;

                j = i + 1;

                if (sequence[i] > sequence[j])
                {
                    
                    if (repeatedFound)
                    {
                        isAlmostIncreasing = false;
                        break;
                    }

                    repeatedFound = true;
                    position = j;
                }
                else
                {
                    if (sequence[i] != sequence[j] - 1)
                    {
                        if (j < sequence.Length - 2)
                        {
                            if (sequence[i] != sequence[j + 1] - 1)
                            {
                                isAlmostIncreasing = false;
                                break;
                            }

                            repeatedFound = true;
                            position = j;
                        }
                        else
                        {
                            isAlmostIncreasing = false;
                            break;
                        }
                    }
                }
            }

            return isAlmostIncreasing;

        }
    }
}
