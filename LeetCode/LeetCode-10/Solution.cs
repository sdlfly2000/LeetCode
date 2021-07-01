namespace LeetCode_10
{
    using System;

    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            var sIndex = 0;
            for (var i = 0; i < p.Length; i++)
            {
                if (p[i] != '.' && p[i] != '*')
                {
                    if (s[sIndex] != p[i])
                    {
                        if (p.Length < i + 1 && p[i + 1] != '*')
                        {
                            return false;
                        }
                    }

                    if (i == p.Length - 1)
                    {
                        if (s.Length > p.Length)
                        {
                            return false;
                        }
                    }
                }

                if (p[i] == '.')
                {
                    if (i >= s.Length)
                    {
                        return false;
                    }
                }

                if (p[i] == '*')
                {
                    var charAstericked = p[i - 1];
                    while (sIndex < s.Length && s[sIndex] == charAstericked)
                    {
                        sIndex++;
                    }

                    continue;
                }

                if (i == p.Length - 1 && sIndex + 1 < s.Length - 1)
                {
                    return false;
                }

                sIndex++;
            }

            return true;
        }
    }
}
