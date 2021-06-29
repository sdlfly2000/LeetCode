using System;
using System.Text;

namespace LeetCode_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // "00000-42a1234" -> 0
            // "  -0012a42" -> -12
            // "   -42" -> -42
            // "   +0 123" -> 0
            // "    -88827   5655  U" -> -88827
            // "-5-" -> -5

            var solution = new Solution();
            var result = solution.MyAtoi("  -0012a42");

            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            var numExtract = Extract(s);

            return numExtract.Equals(string.Empty) ? 0 : ConvertToInt(numExtract);
        }

        private int ConvertToInt(string num)
        {
            var ret = 0L;
            var sign = num[0] == '-';
            var numPart = sign ? num.Substring(1) : num;

            if(numPart.Length > 10)
            {
                return sign ? int.MinValue : int.MaxValue;
            }

            for(var i = 0; i < numPart.Length; i++)
            {
                ret += (numPart[i] - 48) * GetMultiply(numPart.Length - i); 
            }

            ret *= sign ? -1L : 1L;

            if (ret > int.MaxValue)
            {
                return int.MaxValue;
            }

            if(ret < int.MinValue)
            {
                return int.MinValue;
            }

            return (int)ret;
        }

        private long GetMultiply(int dig)
        {
            var ret = 1L;
            for(var i = 0; i < dig-1; i++)
            {
                ret *= 10L;
            }

            return ret;
        }

        private string Extract(string s)
        {
            var ret = new StringBuilder();
            var validSign = false;
            var sign = false;
            var len = s.Length;
            for(var i = 0; i < len; i++)
            {
                if(s[i] == '-')
                {
                    if (validSign)
                    {
                        break;
                    }

                    if(ret.Length > 0 || (i > 0 && validSign))
                    {
                        break;
                    }

                    sign = true;
                    validSign = true;
                }
                else if(s[i] == '+')
                {
                    if (validSign)
                    {
                        break;
                    }

                    if (ret.Length > 0)
                    {
                        break;
                    }

                    sign = false;
                    validSign = true;
                }
                else if(s[i] == ' ')
                {
                    if (ret.Length > 0 || validSign)
                    {
                        break;
                    }

                    continue;
                }
                else if(s[i] > 48 && s[i] < 59)
                {
                    ret.Append(s[i]);
                    validSign = true;
                }
                else if (s[i] == 48)
                {
                    validSign = true;
                    if (i == 0 || ret.Length == 0) 
                    {
                        continue;
                    }

                    ret.Append(s[i]);
                }
                else if (s[i] == 46)
                {
                    break;
                }
                else
                {
                    if (ret.Length == 0)
                    {
                        sign = false;
                    }

                    break;                   
                }
            }

            if (sign && ret.Length > 0)
            {
                ret.Insert(0, '-'); 
            }

            return ret.ToString();
        }
    }
}
