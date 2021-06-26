using System;
using System.Linq;
using System.Text;

namespace LeetCode_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "A";
            var row = 1;
            Console.WriteLine(Solution.Convert(test, row));
        }
    }

    public static class Solution 
    {
        public static string Convert(string s, int numRows) 
        {
            var height = numRows;
            var unitWidth = height - 1;
            var charNumberInUnit = height + unitWidth - 1;
            var unitNumber = s.Length / charNumberInUnit;
            var extrCharNumber = (s.Length % charNumberInUnit);
            var width = extrCharNumber <= height
                        ? (unitWidth * unitNumber) + 1
                        : (unitWidth * unitNumber) + 1 + extrCharNumber - height;

            var zArray = Array.CreateInstance(typeof(char), width, height);
            var currentIndex = 0;
            var currentWidthIndex = 0;
            while(currentIndex < s.Length)
            {
                if((s.Length -1 - currentIndex) >= charNumberInUnit)
                {
                    zArray = SetupInitRow(zArray, s.Substring(currentIndex, height), currentWidthIndex);
                    currentIndex += height;
                    currentWidthIndex += 1;                

                    zArray = SetupRestRows(zArray, s.Substring(currentIndex, unitWidth - 1), currentWidthIndex, height);
                    currentIndex += unitWidth - 1;
                    currentWidthIndex += unitWidth - 1;
                }
                else
                {
                    if((s.Length -1 - currentIndex) >= height)
                    {
                        zArray = SetupInitRow(zArray, s.Substring(currentIndex, height), currentWidthIndex);
                        currentIndex += height;
                        currentWidthIndex += 1;                

                        zArray = SetupRestRows(zArray, s.Substring(currentIndex), currentWidthIndex, height);
                        currentIndex += unitWidth - 1;
                        currentWidthIndex += unitWidth - 1;
                    }
                    else
                    {
                        zArray = SetupInitRow(zArray, s.Substring(currentIndex), currentWidthIndex);
                        currentIndex += height;
                        currentWidthIndex += 1;     
                    }                
                }
            }

            return RemoveEmpty(zArray);
        }

        private static Array SetupInitRow(Array data, string s, int widthIndex)
        {
            for(var i = 0; i < s.Length; i++)
            {
                data.SetValue(s[i], widthIndex, i);
            }

            return data;
        }

        private static Array SetupRestRows(Array data, string s, int widthIndex, int height)
        {
            for(var i = 0; i < s.Length; i++)
            {
                data.SetValue(s[i], widthIndex + i, height - 2 - i);
            }

            return data;
        }

        private static string RemoveEmpty(Array data )
        {
            var height = data.GetLength(1);
            var width = data.GetLength(0);
            var result = new StringBuilder();

            for(var h = 0; h < height; h++)
            {
                for(var i = 0; i < width; i++)
                {
                    var tmp = (char)data.GetValue(i, h);
                    if(tmp != '\0')
                    {
                        result.Append(tmp);
                    }                    
                }
            }

            return result.ToString();
        }
    }
}
