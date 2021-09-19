using System.Collections.Generic;

namespace LeetCode_22
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var current = new char[2 * n];
            var results = new List<string>();

            Traverse(current, 0, results);

            return results;
        }

        private void Traverse(char[] current, int pos, IList<string> results)
        {
            if(pos == current.Length)
            {
                if (IsValid(current))
                {
                    results.Add(new string(current));
                }

                return;
            }

            current[pos] = '(';
            Traverse(current, pos + 1, results);
            current[pos] = ')';
            Traverse(current, pos + 1, results);
        }

        private bool IsValid(char[] current)
        {
            var balanceCount = 0;

            for(var i = 0; i < current.Length; i++)
            {
                if(current[i] == '(')
                {
                    balanceCount++;
                }
                else
                {
                    balanceCount--;
                }

                if(balanceCount < 0)
                {
                    return false;
                }
            }

            return balanceCount == 0;
        }
    }
}
