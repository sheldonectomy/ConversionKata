using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata03
{

    /*
        I 	1
        V 	5
        X 	10
        L 	50
        C 	100
        D 	500
        M 	1000
    */

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

            remaining = appendNumeral(remaining, 10, "X", result);
            remaining = appendNumeral(remaining, 9, "IX", result);
            remaining = appendNumeral(remaining, 5, "V", result);
            remaining = appendNumeral(remaining, 4, "IV", result);
            remaining = appendNumeral(remaining, 1, "I", result);

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
