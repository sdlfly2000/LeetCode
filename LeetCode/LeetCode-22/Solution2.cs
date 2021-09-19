using System.Collections.Generic;

namespace LeetCode_22
{
    public class Solution2
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var results = new List<string>();
            var current = "";

            Traverse(n, n, current, results);

            return results;
        }

        private void Traverse(int left, int right, string current, IList<string> results)
        {
            if(left == 0 && right == 0)
            {
                results.Add(new string(current));
                return;
            }

            if(left > 0)
            {
                Traverse(left - 1, right, current + '(', results);
            }

            if(right > left)
            {
                Traverse(left, right - 1, current + ')', results);
            }
        }
    }
}
