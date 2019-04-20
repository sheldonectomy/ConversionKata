using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata
{

    public static class Conversion
    {
        private static int[] arabicValue = new int[13] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] romanValues = new string[13] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string ArabicToUrnfield(int arabic)
        {
            StringBuilder builder = new StringBuilder();

            int fives = (int)Math.Floor((double)arabic / 5f);
            int ones = arabic % 5;

            builder.Append('/', ones);
            builder.Append('\\', fives);

            return builder.ToString();
        }

        public static int UrnfieldToArabic(string urnfield)
        {
            int ones = urnfield.Where(a => a == '/').ToArray().Length;
            int fives = urnfield.Where(a => a == '\\').ToArray().Length;
            return ones + (fives * 5);
        }

        public static string ArabicToRoman(int arabic)
        {
            var builder = new StringBuilder();
            var remaining = arabic;

            for(int i=0; i<arabicValue.Length; i++)
            {
                remaining = appendRomanNumerals(remaining, arabicValue[i], romanValues[i], builder);
            }
            
            return builder.ToString();
        }

        private static int appendRomanNumerals(int remaining, 
            int arabic, string romanNumerals, StringBuilder builder)
        {
            while (remaining >= arabic)
            {
                builder.Append(romanNumerals);
                remaining -= arabic;
            }
            return remaining;
        }
    }
}
