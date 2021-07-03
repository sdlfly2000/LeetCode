using System.Collections.Generic;

namespace LeetCode_10
{
    using System.Linq;
    using System.Text;

    public class Solution2
    {
        public bool IsMatch(string s, string p)
        {
            var asterickPattern = GetAsterickPattern(p);

            if (asterickPattern == default)
            {
                return false;
            }

            var dotPattern = GetDotPattern(p);

            var constPattern = GetConstPattern(p, asterickPattern, dotPattern);

            var constMatches = MatchConst(s, constPattern);

            if (constMatches.Values.Contains(-1))
            {
                return false;
            }



            return false;
        }

        private Dictionary<string, int> MatchConst(string s, Dictionary<string, int> constPatterns)
        {
            var matchResults = new Dictionary<string, int>();

            foreach (var constPattern in constPatterns)
            {
                matchResults.Add(constPattern.Key, s.IndexOfAny(constPattern.Key.ToCharArray()));
            }

            return matchResults;
        }

        private Dictionary<string, int> GetConstPattern(string p, Dictionary<char, int> asterickPattern, IList<int> dotPattern)
        {
            var consts = new Dictionary<string, int>();
            var tempString = new StringBuilder();
            var tempStartIndex = -1;

            for (var i = 0; i < p.Length; i++)
            {
                if (asterickPattern.ContainsValue(i) || dotPattern.Contains(i))
                {
                    consts.Add(tempString.ToString(), tempStartIndex);
                    tempStartIndex = -1;
                    tempString.Clear();
                    continue;
                }

                if (tempStartIndex == -1)
                {
                    tempStartIndex = i;
                }

                tempString.Append(p[i]);
            }

            return consts;
        }

        private IList<int> GetDotPattern(string p)
        {
            var dots = new List<int>();

            for (var i = 0; i < p.Length; i++)
            {
                if (p[i] == '.')
                {
                    dots.Add(i);
                }
            }

            return dots;
        }

        private Dictionary<char, int> GetAsterickPattern(string p)
        {
            var pairs = new Dictionary<char, int>();

            for (var i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    if (i > 0)
                    {
                        pairs.Add(p[i - 1], i - 1);
                    }
                    else
                    {
                        return default;
                    }
                }
            }

            return pairs;
        }
    }
}
