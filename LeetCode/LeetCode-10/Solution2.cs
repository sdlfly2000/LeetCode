using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_10
{
    public class Solution2
    {
        public bool IsMatch(string s, string p)
        {
            var markedTarget = new int[s.Length];

            var asterickPatterns = GetAsterickPattern(p);

            if (asterickPatterns == default)
            {
                return false;
            }

            var dotPatterns = GetDotPattern(p);

            var constPatterns = GetConstPattern(p, asterickPatterns, dotPatterns);

            var patternIndex = CreatePatternIndex(asterickPatterns, dotPatterns, constPatterns);

            for(var i = 0; i < patternIndex.Count; i++)
            {
                var constString = string.Empty;
                if (constPatterns.TryGetValue(patternIndex[i], out constString))
                {
                    if(!IsMatchConst(constString, s, markedTarget))
                    {
                        return false;
                    }

                    continue;
                }

                if (dotPatterns.Contains(patternIndex[i]))
                {
                    if (!IsMatchDot(s, markedTarget))
                    {
                        return false;
                    }

                    continue;
                }

                var asterickChar = '\0';
                if(asterickPatterns.TryGetValue(patternIndex[i], out asterickChar))
                {
                    if (!IsMatchAsterick(asterickChar, s, markedTarget))
                    {
                        return false;
                    }

                    continue;
                }
            }

            if(markedTarget.Any(i => i == 0))
            {
                return false;
            }

            return true;
        }

        private bool IsMatchDot(string target, int[] markedTarget)
        {
            for (var i = 0; i < markedTarget.Length; i++)
            {
                if (markedTarget[i] == 1)
                {
                    continue;
                }

                markedTarget[i] = 1;
                return true;    
            }
            
            return false;
        }

        private bool IsMatchAsterick(char asterickChar, string target, int[] markedTarget)
        {
            var isFound = false;
            var startCount = 0;
            for (var i = 0; i < markedTarget.Length; i++)
            {
                if (markedTarget[i] == 1)
                {
                    continue;
                }

                startCount++;

                if(target[i] == asterickChar)
                {
                    if (!isFound && startCount > 1)
                    {
                        return false;
                    }

                    isFound = true;
                    markedTarget[i] = 1;
                    continue;
                }
                else
                {
                    if (isFound)
                    {
                        return true;
                    }

                    markedTarget[i] = 1;
                    continue;
                }
            }

            if (!isFound)
            {
                var lastProcessedIndex = Array.LastIndexOf(markedTarget, 1);

                if (startCount > 0)
                {
                    for (var i = lastProcessedIndex; i >= 0 ; i--)
                    {
                        markedTarget[i] = 0;
                    }
                }
            }

            return true;
        }

        private bool IsMatchConst(string constString, string target, int[] markedTarget)
        {
            var startCount = 0;
            for(var i = 0; i < markedTarget.Length; i++)
            {
                if(markedTarget[i] == 1)
                {
                    continue;
                }

                startCount++;

                for(var n = 0; n < constString.Length; n++)
                {
                    if(i + n >= target.Length)
                    {
                        return false;
                    }

                    if(target[i + n] == constString[n])
                    {
                        markedTarget[i + n] = 1;
                        continue;
                    }

                    return false;
                }

                return true;
            }

            if(startCount == 0)
            {
                return false;
            }

            return true;
        }

        private IList<int> CreatePatternIndex(Dictionary<int, char> asterickPattern, IList<int> dotPattern, Dictionary<int, string> constPattern)
        {
            var constPoss = new List<int>();
            var patterns = new List<int>(); 
            
            foreach(var c in constPattern)
            {
                if (c.Value.Length == 1)
                {
                    var constPos = c.Key;
                    if (asterickPattern.Keys.Contains(constPos - 2))
                    {
                        var asterickValue = asterickPattern[constPos - 2];
                        if (asterickValue == c.Value[0])
                        {
                            constPoss.Add(constPos);
                        }
                    }
                }
            }

            constPoss.ForEach(c => constPattern.Remove(c));

            patterns.AddRange(constPattern.Keys.ToList());
            patterns.AddRange(dotPattern);
            patterns.AddRange(asterickPattern.Keys.ToList());
            patterns.Sort();
            return patterns;
        }

        private Dictionary<int, string> GetConstPattern(string p, Dictionary<int, char> asterickPattern, IList<int> dotPattern)
        {
            var results = new Dictionary<int, string>();
            var consts = new Dictionary<int, string>();
            var tempString = new StringBuilder();
            var tempStartIndex = -1;

            for (var i = 0; i < p.Length; i++)
            {
                if (tempStartIndex == -1)
                {
                    tempStartIndex = i;
                }

                if (asterickPattern.ContainsKey(i) || 
                    dotPattern.Contains(i) ||
                    p[i] == '.' || p[i] =='*')
                {
                    consts.Add(tempStartIndex, tempString.ToString());
                    tempStartIndex = -1;
                    tempString.Clear();
                    continue;
                }

                if(i == (p.Length - 1))
                {
                    tempString.Append(p[i]);
                    consts.Add(tempStartIndex, tempString.ToString());
                    tempStartIndex = -1;
                    tempString.Clear();
                    continue;
                }

                tempString.Append(p[i]);
            }

            foreach(var c in consts)
            {
                if (!c.Value.Equals(string.Empty))
                {
                    results.Add(c.Key, c.Value);
                }
            }

            return results;
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

        private Dictionary<int, char> GetAsterickPattern(string p)
        {
            var pairs = new Dictionary<int, char>();

            for (var i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    if (i > 0)
                    {
                        pairs.Add(i - 1, p[i - 1]);
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
