using System.Collections.Generic;

namespace LeetCode_17
{
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var letterMap = InitialDigitMap();

            var retList = new List<string>();

            var len = digits.Length;

            var matrix = new List<char[]>();

            var temp = new StringBuilder();

            for (var i = 0; i < len; i++)
            {
                matrix.Add(letterMap[digits[i]]);
            }

            for (var bigRow = 0; bigRow < matrix.Count; bigRow++)
            {
                for (var column = 0; column < matrix[bigRow].Length; column++)
                {
                    temp.Clear();
                    temp.Append(matrix[bigRow][column]);
                    for (var row = 1; row < matrix.Count; row++)
                    {
                        if (column < matrix[row].Length)
                        {
                            temp.Append(matrix[row][column]);
                        }

                        retList.Add(temp.ToString());
                    }
                }
            }

            return retList;
        }

        private Dictionary<char, char[]> InitialDigitMap()
        {
            var retDict = new Dictionary<char, char[]>();
            retDict.Add('2', new char[] { 'a', 'b', 'c' });
            retDict.Add('3', new char[] { 'd', 'e', 'f' });
            retDict.Add('4', new char[] { 'g', 'h', 'i' });
            retDict.Add('5', new char[] { 'j', 'k', 'l' });
            retDict.Add('6', new char[] { 'm', 'n', 'o' });
            retDict.Add('7', new char[] { 'p', 'q', 'r', 's' });
            retDict.Add('8', new char[] { 't', 'u', 'v' });
            retDict.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            return retDict;
        }
    }
}