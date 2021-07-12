using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_12
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var roman = new StringBuilder();
            var digit4 = num / 1000;
            var digit3 = (num % 1000) / 100;
            var digit2 = (num % 100) / 10;
            var digit1 = (num % 10);

            for(var i = 0; i < digit4; i++)
            {
                roman.Append("M");
            }

            roman.Append(MapRoman(digit3, 'C', 'D', 'M'));
            roman.Append(MapRoman(digit2, 'X', 'L', 'C'));
            roman.Append(MapRoman(digit1, 'I', 'V', 'X'));

            return roman.ToString();
        }

        private string MapRoman(int digit, char low, char hight, char next)
        {
            var roman = new StringBuilder();
            if (digit < 4)
            {
                for (var i = 0; i < digit; i++)
                {
                    roman.Append(low);
                }
            }
            else if (digit == 4)
            {
                roman.Append(low);
                roman.Append(hight);
            }
            else if (digit == 5)
            {
                roman.Append(hight);
            }
            else if (digit == 9)
            {
                roman.Append(low);
                roman.Append(next);
            }
            else
            {
                roman.Append(hight);
                for (var i = 5; i < digit; i++)
                {
                    roman.Append(low);
                }
            }
            return roman.ToString();
        }
    }
}
