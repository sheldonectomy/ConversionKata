using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata03
{
    public class Conversion
    {
        public string ArabicToRoman(int arabic)
        {
            var result = new StringBuilder(string.Empty);
            var remaining = arabic;

            if(remaining >= 5)
            {
                result.Append("V");
                remaining -= 5;
            }

            if (remaining == 4)
            {
                result.Append("IV");
                remaining -= 4;
            }

            for (int i = 0; i < remaining; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }
    }
}
