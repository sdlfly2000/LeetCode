using System;
using System.Text;

namespace LeetCode_6_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "AB";
            var row = 2;
            var solution = new Solution(test, row);
            Console.WriteLine(solution.Convert());
        }
    }

    public class Solution
    {
        private string _test;
        private int _numRows;

        public Solution(string testString, int numRows)
        {
            _test = testString;
            _numRows = numRows;
        }

        public string Convert()
        {
            var height = _numRows;
            var unitWidth = height - 1 > 0 ? height - 1 : 1;
            var charNumberInUnit = height + unitWidth - 1;
            var unitNumber = _test.Length / charNumberInUnit;
            var extrCharNumber = (_test.Length % charNumberInUnit);
            var width = extrCharNumber <= height
                        ? (unitWidth * unitNumber) + 1
                        : (unitWidth * unitNumber) + 1 + extrCharNumber - height;

            var zArray = Array.CreateInstance(typeof(char), width, height);
            var currentIndex = 0;
            var currentWidthIndex = 0;
            while (currentIndex < _test.Length)
            {
                if ((_test.Length - 1 - currentIndex) >= charNumberInUnit)
                {
                    zArray = SetupInitRow(zArray, _test.Substring(currentIndex, height), currentWidthIndex);
                    currentIndex += height;
                    currentWidthIndex += 1;

                    zArray = SetupRestRows(zArray, _test.Substring(currentIndex, unitWidth - 1), currentWidthIndex, height);
                    currentIndex += unitWidth - 1;
                    currentWidthIndex += unitWidth - 1;
                }
                else
                {
                    if ((_test.Length - 1 - currentIndex) >= height)
                    {
                        zArray = SetupInitRow(zArray, _test.Substring(currentIndex, height), currentWidthIndex);
                        currentIndex += height;
                        currentWidthIndex += 1;

                        zArray = SetupRestRows(zArray, _test.Substring(currentIndex), currentWidthIndex, height);
                        currentIndex += unitWidth - 1;
                        currentWidthIndex += unitWidth - 1;
                    }
                    else
                    {
                        zArray = SetupInitRow(zArray, _test.Substring(currentIndex), currentWidthIndex);
                        currentIndex += height;
                        currentWidthIndex += 1;
                    }
                }
            }

            return RemoveEmpty(zArray);
        }

        private Array SetupInitRow(Array data, string s, int widthIndex)
        {
            for (var i = 0; i < s.Length; i++)
            {
                data.SetValue(s[i], widthIndex, i);
            }

            return data;
        }

        private Array SetupRestRows(Array data, string s, int widthIndex, int height)
        {
            for (var i = 0; i < s.Length; i++)
            {
                data.SetValue(s[i], widthIndex + i, height - 2 - i);
            }

            return data;
        }

        private string RemoveEmpty(Array data)
        {
            var height = data.GetLength(1);
            var width = data.GetLength(0);
            var result = new StringBuilder();

            for (var h = 0; h < height; h++)
            {
                for (var i = 0; i < width; i++)
                {
                    var tmp = (char)data.GetValue(i, h);
                    if (tmp != '\0')
                    {
                        result.Append(tmp);
                    }
                }
            }

            return result.ToString();
        }
    }
}
