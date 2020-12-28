using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Numerics;

namespace ProjEulerInCSharp
{
    public class Problems21To30
    {
        public static void PrintAllProblemsResults()
        {
            Problems21To30 results21To30 = new Problems21To30();
            results21To30.Problem21();
            results21To30.Problem22();
            results21To30.Problem23();
            results21To30.Problem25();
            results21To30.Problem29();
            results21To30.Problem30();
        }

        public void Problem21()
        { }

        public void Problem22() // Names scores
        {
            string path = ConfigurationManager.AppSettings["PathToProblem22"];
            StreamReader reader = new StreamReader(path);
            string fileContent = reader.ReadToEnd().Replace("\"", "");
            reader.Close();

            var listOfNames = fileContent.Split(',');
            Array.Sort(listOfNames);
            int namePosition = 1, totalCurrentName = 0;
            double totalNameScores = 0;

            foreach(string name in listOfNames)
            {
                var nameArray = name.ToCharArray();
                for (int i = 0; i < name.Length; i++)
                {
                    totalCurrentName += HelperFunctions.GetLetterValue(nameArray[i]);
                }

                totalNameScores += namePosition * totalCurrentName;
                totalCurrentName = 0;
                namePosition++;
            }

            Console.WriteLine("Problem 22: " + totalNameScores.ToString());
        }

        public void Problem23() // Non-abundant sums
        {
            int result = 0;

            for (int i = 28123; i > 0; i--)
            {
                result += (HelperFunctions.IsAbundantNumber(i) ? i : 0);
            }

            Console.WriteLine("Problem 23: " + result);
        }

        public void Problem25() // 1000-digit Fibonacci number
        {
            BigInteger largeFibonacci = 1, previous = 0;
            int index = 0, finalIndex = 1000;

            for (index = 2; largeFibonacci.ToString().Length < finalIndex; index += 2)
            {
                largeFibonacci += previous;
                previous += largeFibonacci;
                if (largeFibonacci.ToString().Length == finalIndex || previous.ToString().Length == finalIndex)
                { 
                    if (largeFibonacci.ToString().Length == finalIndex)
                        index--;

                    break;
                }
            }

            Console.WriteLine("Problem 25: " + index);
        }

        public void Problem29() //Distinct powers
        {
            int a = 100, b = 100;
            double currentPower = 0;
            List<double> allPowers = new List<double>();

            for (int j = 2; j <= b; j++)
            {
                for (int i = 2; i <= a; i++)
                {
                    currentPower = Math.Pow(i, j) ;
                    if (!allPowers.Contains(currentPower))
                        allPowers.Add(currentPower);
                }
            }

            Console.WriteLine("Problem 29: " + allPowers.Count);
        }

        public void Problem30() //Digit fifth powers
        {
            double powerNumber = 5, sumOfDigits = 0, sumOfFifths = 0;

            // Note: I still haven't found a criterium to define the maximum number as the ceiling for this problem
            for (int i = 2; i < 1000000; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sumOfDigits += Math.Pow(double.Parse(i.ToString().Substring(j, 1)), powerNumber);
                    if (sumOfDigits > i)
                        break;
                }

                if (sumOfDigits == i)
                {
                    sumOfFifths += i;
                    Console.WriteLine(i);
                }
                    

                sumOfDigits = 0;
            }

            Console.WriteLine("Problem 30: " + sumOfFifths.ToString());
        }
    }
}
