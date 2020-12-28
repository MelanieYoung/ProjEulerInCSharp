using System;
using System.Numerics;

namespace ProjEulerInCSharp
{
    public class Problems41To50
    {
        public static void PrintAllProblemsResults()
        {
            Problems41To50 results41to50 = new Problems41To50();
            results41to50.Problem48();
        }

        public void Problem48() // Self powers
        {
            BigInteger sumOfPowers = 0;

            for (int i = 1; i <= 1000; i++)
            {
                sumOfPowers += BigInteger.Pow(i, i);
            }

            string result = sumOfPowers.ToString();
            result = result.Substring(result.Length - 10);
            Console.WriteLine("Problem 48: " + result);
        }
    }
}
