using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
            var numberRemaining = number;
            var word = "";

            while (numberRemaining > 0)
            {
                var needsAnd = false;
                if (numberRemaining >= 100)
                {
                    var numHundreds = GetHundreds(numberRemaining);
                    word += $"{_numberWordLookup[numHundreds]} Hundred";
                    needsAnd = true;
                    numberRemaining -= (numHundreds * 100);
                }

                foreach (var numberWord in _numberWordLookup.OrderByDescending(n => n.Key))
                {
                    if (numberWord.Key > numberRemaining)
                    {
                        continue;
                    }

                    word += needsAnd ? $"and {numberWord.Value} " : $"{numberWord.Value} ";
                    numberRemaining -= numberWord.Key;
                    break;
                }
            }

            return word.TrimEnd();
        }

        private static int GetHundreds(int number)
        {
            return number /= 100;
        }
    }
}
