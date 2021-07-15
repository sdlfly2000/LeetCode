using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_14
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var prefix = new StringBuilder();

            for (var j = 0; j < strs[0].Length; j++)
            {
                prefix.Append(strs[0][j]);

                for (var i = 1; i < strs.Length; i++)
                {
                    if ((strs[i].Length - 1) < j || strs[0][j] != strs[i][j])
                    {
                        prefix.Remove(prefix.Length - 1, 1);
                        return prefix.ToString();
                    }
                }
            }

            return prefix.ToString();
        }
    }
}
