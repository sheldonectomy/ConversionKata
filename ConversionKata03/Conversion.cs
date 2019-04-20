using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata03
{

    public class Conversion
    {
        private int[] arabicIndex = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private string[] romanIndex = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public string ArabicToRoman(int arabic)
        {
            var result = new StringBuilder(string.Empty);
            var remaining = arabic;

            for(int i = 0; i < 13; i++)
            {
                remaining = appendNumeral(remaining, arabicIndex[i], romanIndex[i], result);
            }

            return result.ToString();
        }

        private int appendNumeral(int remaining, int arabic, string roman, 
            StringBuilder builder)
        {
            while(remaining >= arabic)
            {
                builder.Append(roman);
                remaining -= arabic;
            }

            return remaining;
        }
    }
}
