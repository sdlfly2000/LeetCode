using System.Collections.Generic;

namespace LeetCode_30
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var checkWord = new Dictionary<string, int>();
            var numOfWord = words.Length > 0 ? words[0].Length : 0;
            var numOfTestString = numOfWord * words.Length;

            InitialCheckWord(checkWord, words);

            var retList = new List<int>();

            for(var i = 0; i <= s.Length - numOfTestString; i++)
            {
                var testString = s[i..(i + numOfTestString)];

                if(IsValid(testString, checkWord, numOfWord))
                {
                    retList.Add(i);
                }

                InitialCheckWord(checkWord, words);
            }

            return retList;
        }

        #region Private Methods
        private bool IsValid(string target, IDictionary<string, int> checkWord, int wordCount)
        {
            for(var i = 0; i < target.Length; i += wordCount)
            {
                var testString = target[i..(i+wordCount)];

                if (!checkWord.TryGetValue(testString, out var findCount))
                {
                    return false;
                }

                if (findCount > 0)
                {
                    checkWord[testString] = findCount - 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private void InitialCheckWord(IDictionary<string, int> checkWord, string[] words)
        {
            checkWord.Clear();
            for (var indexWord = 0; indexWord < words.Length; indexWord++)
            {
                if (!checkWord.TryAdd(words[indexWord], 1))
                {
                    checkWord[words[indexWord]] += 1;
                }
            }
        }

        #endregion
    }
}
