using System;

namespace ProjEulerInCSharp
{
    public class Problems31To40
    {
        public static void PrintAllProblemsResults()
        {
            Problems31To40 results31to40 = new Problems31To40();
            results31to40.Problem36();
        }

        public void Problem36() //Double-base palindromes
        {
            int sumOfPalindromes = 0;

            for (int i = 0; i < 1000000; i++)
            {
                string binaryNumber = Convert.ToString(i, 2);
                if (!HelperFunctions.IsPalindrome(i.ToString()) || !HelperFunctions.IsPalindrome(binaryNumber))
                    continue;
                else
                    sumOfPalindromes += i;
            }

            Console.WriteLine("Problem 36: " + sumOfPalindromes);
        }
    }
}
