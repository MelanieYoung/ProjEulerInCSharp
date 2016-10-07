using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        }

        public void Problem7() // 10001st prime
        {
            int primeNumber = 4, tempNumber = 4;
            bool isPrime = false;

            for (int i = 3; i <= 10001; i++)
            {
                while (!isPrime)
                {
                    tempNumber++;

                    for (int a = 2; a < tempNumber; a++)
                    {
                        if (tempNumber % a == 0)
                            break;

                        if (a == tempNumber - 1)
                            isPrime = true;
                    }
                }
                
                primeNumber = tempNumber;

                isPrime = false;
            }

            Console.WriteLine("Problem 7: " + primeNumber);
        }

        public void Problem8() // Largest product in a series
        {
            StreamReader reader = new StreamReader("D:\\GitHub\\ProjEulerInCSharp\\Problem8.txt");
            string fileContent = reader.ReadToEnd().Replace("\r\n", "");
            reader.Close();

            Int64 currentProduct = 1, largestProduct = 0;

            for(int i = 0; i < fileContent.Length-13; i++)
            {
                for (int index = i; index < i + 13; index++)
                {
                    currentProduct *= Convert.ToInt32(fileContent[index].ToString());
                }

                if (largestProduct < currentProduct)
                    largestProduct = currentProduct;

                currentProduct = 1;
            }

            Console.WriteLine("Problem 8: " + largestProduct);
        }

        public void Problem9() // Special Pythagorean triplet
        {
            int a = 1, b = 1, c = 1;
            double result = 0;
            Int64 pythagoreanProduct = 0;
            bool pythagoreanFound = false;

            for (a = 2;  (a + b + c <= 1000) && !pythagoreanFound; a++)
            {
                for (b = a + 1; a + b + c <= 1000; b++)
                {
                    result = (a * a) + (b * b);
                    c = Convert.ToInt32(Math.Sqrt(result));

                    if (c > b)
                    {
                        if ((c * c) == (a * a) + (b * b))
                        {
                            if (a + b + c == 1000)
                            {
                                pythagoreanProduct = Convert.ToInt64(a * b * c);
                                pythagoreanFound = true;
                            }
                        }
                    }
                }

                b = a + 1;

                if (pythagoreanFound)
                    break;
            }

            Console.WriteLine("Problem 9: " + pythagoreanProduct);
        }

        public void Problem10() // Summation of primes
        {
            object sumOfPrimes = 0;
            //Thread t1 = new Thread( sumOfPrimes => PrimeCalc(2000000, 1000000));
            Thread t1 = new Thread(() => { sumOfPrimes = PrimeCalc(10, 2); });
            t1.Start();
            //Console.WriteLine("Problem 10: " + sumOfPrimes);
            Console.WriteLine("Problem 10: In progress!");
        }

        private Int64 PrimeCalc(int maxVal, int minVal)
        {
            Int64 sum = 0;

            for (int i = maxVal - 1; i >= minVal; i--)
            {
                for (int j = i - 1; j >= 2; j--)
                {
                    if (i % j == 0)
                        break;

                    if (j == 2 && (i % j != 0))
                        sum += i;
                }
                Console.WriteLine(sum);
            }

            return sum;
        }
    }
}
