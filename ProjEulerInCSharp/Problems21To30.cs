using System;
using System.Numerics;

namespace ProjEulerInCSharp
{
    public class Problems21To30
    {
        public static void PrintAllProblemsResults()
        {
            Problems21To30 results21To30 = new Problems21To30();
            results21To30.Problem25();
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
