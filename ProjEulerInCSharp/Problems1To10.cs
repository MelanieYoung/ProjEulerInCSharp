using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEulerInCSharp
{
    public class Problems1To10
    {
        public void Problem1() // Multiples of 3 and 5
        {
            int sumResult = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sumResult += i;
            }
            Console.WriteLine("Problem 1: " + sumResult);
            Console.ReadLine();
        }

        public void Problem2() // Even Fibonacci numbers
        {
            int fibonacci = 1, sumOfEven = 0;

            for (int i = 1; i < 4000000; i += fibonacci)
            {
                fibonacci += i;

                if (fibonacci % 2 == 0)
                    sumOfEven += fibonacci;
                if (i % 2 == 0)
                    sumOfEven += i;
            }

            Console.WriteLine("Problem 2: " + sumOfEven);
            Console.ReadLine();
        }

        public void Problem3() // Largest prime factor
        {
            Int64 largestPrime = 600851475143;
            for (Int64 i = 1; i < largestPrime; i++)
            {
                if (largestPrime % i == 0)
                    largestPrime /= i;
            }

            Console.WriteLine("Problem 3: " + largestPrime);
            Console.ReadLine();
        }

        public void Problem4() // Largest palindrome product
        {
            int largestPalindrome = 0, product= 0;
            string resultingString = string.Empty;
            bool isPalindrome = false;

            for (int i = 101; i < 999; i++)
            {
                for (int j = 101; j < 999; j++)
                {
                    product = i * j;

                    resultingString = product.ToString();

                    for (int index = 0; index < resultingString.Length / 2; index++)
                    {
                        if (resultingString[index] != resultingString[resultingString.Length - index - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                        else
                            isPalindrome = true;
                    }

                    if (isPalindrome && largestPalindrome < product)
                        largestPalindrome = product;

                    isPalindrome = false;
                }
            }

            Console.WriteLine("Problem 4: " + largestPalindrome);
            Console.ReadLine();
        }

        public void Problem5() // Smallest multiple
        {
            Int64 smallestNumber = 30;
            bool smallestNumberFound = false;
            while (!smallestNumberFound)
            {
                smallestNumber++;

                for (int i = 2; i <= 20; i++)
                {
                    if (smallestNumber % i != 0)
                        break;

                    if (i == 20)
                        smallestNumberFound = true;
                }
            }

            Console.WriteLine("Problem 5: " + smallestNumber);
            Console.ReadLine();
        }

        public void Problem6() // Sum square difference
        {
            Int64 sumOfSquares = 0, squareOfSums = 0, result = 0;

            for (int i = 1; i <= 100; i++ )
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            result = (squareOfSums * squareOfSums) - sumOfSquares;

            Console.WriteLine("Problem 6: " + result);
            Console.ReadLine();
        }

        public void Problem7()
        {
            int primeNumber = 4, tempNumber = 4;
            bool isPrime = false;

            for (int i = 3; i <= 10001; i++)
            {
                tempNumber++;

                for (int a = 2; a < tempNumber; a++)
                {
                    if (tempNumber % a == 0)
                        break;

                    if (a == tempNumber - 1)
                        isPrime = true;
                }

                if (isPrime)
                    primeNumber = tempNumber;

                isPrime = false;
            }

            //Console.WriteLine("Problem 7: " + primeNumber);
            Console.WriteLine("Problem 7: In progress!");
            Console.ReadLine();
        }
    }
}
