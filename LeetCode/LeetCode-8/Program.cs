using System;
using System.Text;

namespace LeetCode_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.MyAtoi("9223372036854775808");

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
            var signed = false;
            var sign = false;
            var len = s.Length;
            for(var i = 0; i < len; i++)
            {
                if(s[i] == '-')
                {
                    if (signed)
                    {
                        sign = false;
                        break;
                    }

                    if(ret.Length > 0)
                    {
                        sign = false;
                        break;
                    }

                    sign = true;
                    signed = true;
                }
                else if(s[i] == '+')
                {
                    if (signed)
                    {
                        sign = false;
                        break;
                    }

                    if (ret.Length > 0)
                    {
                        sign = false;
                        break;
                    }

                    sign = false;
                    signed = true;
                }
                else if(s[i] == ' ')
                {
                    if (ret.Length > 0)
                    {
                        sign = false;
                        break;
                    }
                    continue;
                }
                else if(s[i] > 47 && s[i] < 59)
                {
                    ret.Append(s[i]);
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

            if (sign)
            {
                ret.Insert(0, '-'); 
            }

            return ret.ToString();
        }
    }
}
