﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjEulerInCSharp
{
    public class HelperFunctions
    {
        public static string GetNumberName(int proposedNumber)
        {
            string numberName = string.Empty;
            List<int> dividedNumbers = new List<int>();
            double multiplier = 10, current = 0, powerValue = 0;

            var partitionedNumber = proposedNumber.ToString().ToArray();
            powerValue = partitionedNumber.Length - 1;

            for (int i = 0; i < partitionedNumber.Length; i++)
            {
                multiplier = Math.Pow(multiplier, powerValue);
                current = double.Parse(partitionedNumber[i].ToString());

                if (i == 0 && powerValue >= 2)
                {
                    dividedNumbers.Add(Int32.Parse(partitionedNumber[i].ToString()));
                    dividedNumbers.Add(Int32.Parse(multiplier.ToString()));
                }
                else
                {
                    if (current == 1 && multiplier == 10)
                    {
                        dividedNumbers.Add(Int32.Parse(partitionedNumber[i].ToString() + partitionedNumber[i + 1]));
                        break;
                    }
                    else
                        dividedNumbers.Add(Int32.Parse(partitionedNumber[i].ToString()) * (Int32.Parse(multiplier.ToString())));
                }

                multiplier = 10;
                powerValue--;
            }

            foreach(int number in dividedNumbers)
            {
                switch (number)
                {
                    case 1:
                        numberName += " one";
                        break;
                    case 2:
                        numberName += " two";
                        break;
                    case 3:
                        numberName += " three";
                        break;
                    case 4:
                        numberName += " four";
                        break;
                    case 5:
                        numberName += " five";
                        break;
                    case 6:
                        numberName += " six";
                        break;
                    case 7:
                        numberName += " seven";
                        break;
                    case 8:
                        numberName += " eight";
                        break;
                    case 9:
                        numberName += " nine";
                        break;
                    case 10:
                        numberName += " ten";
                        break;
                    case 11:
                        numberName += " eleven";
                        break;
                    case 12:
                        numberName += " twelve";
                        break;
                    case 13:
                        numberName += " thirteen";
                        break;
                    case 14:
                        numberName += " fourteen";
                        break;
                    case 15:
                        numberName += " fifteen";
                        break;
                    case 16:
                        numberName += " sixteen";
                        break;
                    case 17:
                        numberName += " seventeen";
                        break;
                    case 18:
                        numberName += " eighteen";
                        break;
                    case 19:
                        numberName += " nineteen";
                        break;
                    case 20:
                        numberName += " twenty";
                        break;
                    case 30:
                        numberName += " thirty";
                        break;
                    case 40:
                        numberName += " forty";
                        break;
                    case 50:
                        numberName += " fifty";
                        break;
                    case 60:
                        numberName += " sixty";
                        break;
                    case 70:
                        numberName += " seventy";
                        break;
                    case 80:
                        numberName += " eighty";
                        break;
                    case 90:
                        numberName += " ninety";
                        break;
                    case 100:
                        numberName += proposedNumber == 100 ? " hundred" : " hundred and";
                        break;
                    case 1000:
                        numberName += " thousand ";
                        break;
                    default:
                        break;
                }
            }

            if (proposedNumber % 100 == 0 && proposedNumber != 1000)
                numberName = numberName.Replace("and", "");

            return numberName.Trim();
        }

        public static int GetLetterValue(char letter)
        {
            int letterValue = 0;
            switch(letter)
            {
                case 'A':
                    letterValue = 1;
                    break;
                case 'B':
                    letterValue = 2;
                    break;
                case 'C':
                    letterValue = 3;
                    break;
                case 'D':
                    letterValue = 4;
                    break;
                case 'E':
                    letterValue = 5;
                    break;
                case 'F':
                    letterValue = 6;
                    break;
                case 'G':
                    letterValue = 7;
                    break;
                case 'H':
                    letterValue = 8;
                    break;
                case 'I':
                    letterValue = 9;
                    break;
                case 'J':
                    letterValue = 10;
                    break;
                case 'K':
                    letterValue = 11;
                    break;
                case 'L':
                    letterValue = 12;
                    break;
                case 'M':
                    letterValue = 13;
                    break;
                case 'N':
                    letterValue = 14;
                    break;
                case 'O':
                    letterValue = 15;
                    break;
                case 'P':
                    letterValue = 16;
                    break;
                case 'Q':
                    letterValue = 17;
                    break;
                case 'R':
                    letterValue = 18;
                    break;
                case 'S':
                    letterValue = 19;
                    break;
                case 'T':
                    letterValue = 20;
                    break;
                case 'U':
                    letterValue = 21;
                    break;
                case 'V':
                    letterValue = 22;
                    break;
                case 'W':
                    letterValue = 23;
                    break;
                case 'X':
                    letterValue = 24;
                    break;
                case 'Y':
                    letterValue = 25;
                    break;
                case 'Z':
                    letterValue = 26;
                    break;
                default:
                    break;
            }

            return letterValue;
        }

        public static bool IsAbundantNumber(int numberToCheck)
        {
            int sumOfDivisors = 0, divisor = 0;
            List<int> divisors = new List<int>();

            divisor = (int)Math.Sqrt(numberToCheck);
            for (int i = 1; i <= divisor; ++i)
            {
                if (numberToCheck % i == 0 && i != numberToCheck)
                {
                    divisors.Add(i);

                    if (i != numberToCheck/i && i != 1 )
                        divisors.Add(numberToCheck/i);
                }
            }

            foreach (int number in divisors)
            {
                sumOfDivisors += number;
            }

            Console.WriteLine("Is Abundant: " +  (sumOfDivisors > numberToCheck) + " sum is " + sumOfDivisors);
            return sumOfDivisors > numberToCheck;
        }

        public static bool IsPrime(Int64 numberToCheck)
        {
            Int64 tempNumber = Convert.ToInt64(Math.Sqrt(numberToCheck));

            if (numberToCheck == 2 || numberToCheck == 3)
                return true;

            if (numberToCheck % 2 == 0 || numberToCheck % 3 == 0)
                return false;

            if (numberToCheck % Math.Sqrt(numberToCheck) == 0)
                return false;

            for (int j = 3; j < Math.Sqrt(numberToCheck); j += 2)
            {
                if (numberToCheck % j == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(string stringToCheck)
        {
            int indexEnd = stringToCheck.Length - 1;
            for (int i = 0; i < stringToCheck.Length / 2; i++)
            {
                if (stringToCheck[i] != stringToCheck[indexEnd])
                    return false;

                indexEnd--;
            }

            return true;
        }
    }
}
