using System.Collections.Generic;

namespace LeetCode_17
{
    public class Solution
    {
        private int MaxRow;

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Equals(string.Empty))
            {
                return new List<string>();
            }

            var letterMap = InitialDigitMap();

            var retList = new List<string>();

            var len = digits.Length;

            var matrix = new List<char[]>();

            for (var i = 0; i < len; i++)
            {
                matrix.Add(letterMap[digits[i]]);
            }

            MaxRow = matrix.Count - 1;
            var total = string.Empty;

            Travel(0, total, retList, matrix);

            return retList;
        }

        private void Travel(int row, string total, IList<string> finalReturn, IList<char[]> matrix)
        {
            if (row == MaxRow)
            {
                for(var column = 0; column < matrix[MaxRow].Length; column++)
                {
                    finalReturn.Add(total + matrix[row][column]);
                }

                return;
            }

            for (var column = 0; column < matrix[row].Length; column++)
            {
                Travel(row + 1, total + matrix[row][column], finalReturn, matrix);
            }
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