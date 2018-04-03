using System;
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
    }
}
