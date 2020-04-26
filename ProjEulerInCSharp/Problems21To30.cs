using System;
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
            //results21To30.Problem22();
            //results21To30.Problem23();
            //results21To30.Problem25();
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
    }
}
