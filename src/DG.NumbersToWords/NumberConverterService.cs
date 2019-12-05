using System.Collections.Generic;

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
        };

        public string ConvertNumberToWord(int number)
        {
            return _numberWordLookup[number];
        }
    }
}
