using System;
using System.Text;

namespace LeetCode_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            solution.Reverse(int.MaxValue);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            var sX = x.ToString();
            var sign = sX[0] == '-';
            var numProcessed = sign ? sX.Remove(0, 1) : sX;
            var rev = Reverse(numProcessed, sign);

            Console.WriteLine(rev);

            return 0;
        }

        private int Reverse(string num, bool sign)
        {
            var ret = new StringBuilder();
            var i = num.Length - 1;

            while(i >= 0)
            {
                ret.Append(num[i]);
                i--;
            }

            return Parse(ret.ToString(), sign);
        }

        private int Parse(string num, bool sign)
        {
            var ret = 0;
            for(var i = 0; i < num.Length; i++)
            {
                ret += (num[i] - 48) * GetMultiply(num.Length - i);
            }

            if (sign)
            {
                ret *= -1;
            }

            return ret;            
        }

        private int GetMultiply(int time)
        {
            var ret = 1;
            while(time > 1)
            {
                ret *= 10;
                time--;
            }

            return ret;
        }
    }
}
