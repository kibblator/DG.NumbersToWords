using System.Collections.Generic;
using System.Linq;

namespace DG.NumbersToWords
{
    public class NumberConverterService
    {
        private readonly Dictionary<int, string> _numberWordLookup = new Dictionary<int, string>
        {
            {1, "One" },
            {2, "Two" },
            {3, "Three" },
            {4, "Four" },
            {5, "Five" },
            {6, "Six" },
            {7, "Seven" },
            {8, "Eight" },
            {9, "Nine" },
            {10, "Ten" },
            {11, "Eleven" },
            {12, "Twelve" },
            {13, "Thirteen" },
            {14, "Fourteen" },
            {15, "Fifteen" },
            {16, "Sixteen" },
            {17, "Seventeen" },
            {18, "Eighteen" },
            {19, "Nineteen" },
            {20, "Twenty" },
            {30, "Thirty" },
            {40, "Forty" },
            {50, "Fifty" },
            {60, "Sixty" },
            {70, "Seventy" },
            {80, "Eighty" },
            {90, "Ninety" }
        };

        public string ConvertNumberToWord(int number)
        {
            var word = "";
            if (number < 0)
            {
                number *= -1;
                word += "Minus";
            }

            if (number == 0)
            {
                return "Zero";
            }

            if (number >= 1000)
            {
                var thousandWord = GetThousandWord(number);
                number -= thousandWord.Key;
                word += thousandWord.Value;
            }

            word += GetHundredWord(number).Value;

            return word.Trim();
        }

        private KeyValuePair<int, string> GetThousandWord(int number)
        {
            var numThousands = GetThousands(number);
            var thousandWord = $"{GetHundredWord(numThousands).Value} Thousand";
            var thousandsDetected = numThousands * 1000;

            number -= thousandsDetected;
            thousandWord += number > 0 && number.ToString().Length != 3 ? $" and" : "";
            return new KeyValuePair<int, string>(thousandsDetected, thousandWord);
        }

        private KeyValuePair<int, string> GetHundredWord(int number)
        {
            var hundredWord = "";
            if (number >= 100)
            {
                var numHundreds = GetHundreds(number);
                hundredWord = $"{GetLessThanHundredWord(numHundreds)} Hundred";
                var hundredsDetected = numHundreds * 100;

                number -= hundredsDetected;
                hundredWord += number > 0 ? $" and" : "";
            }

            var lessThanHundredWord = GetLessThanHundredWord(number);
            hundredWord += lessThanHundredWord;

            return new KeyValuePair<int, string>(0, hundredWord);
        }

        private string GetLessThanHundredWord(int numberRemaining)
        {
            var lessThanHundredWord = "";
            while (numberRemaining > 0)
            {
                foreach (var numberWord in _numberWordLookup.OrderByDescending(n => n.Key))
                {
                    if (numberWord.Key > numberRemaining)
                    {
                        continue;
                    }

                    lessThanHundredWord += $" {numberWord.Value}";
                    numberRemaining -= numberWord.Key;
                }
            }

            return lessThanHundredWord;
        }

        private int GetThousands(int number)
        {
            return number /= 1000;
        }

        private static int GetHundreds(int number)
        {
            return number /= 100;
        }
    }
}
