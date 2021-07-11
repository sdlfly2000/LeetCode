using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_11
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;

            for(var i = 0; i < height.Length; i++)
            {
                for(var j = i + 1; j < height.Length; j++)
                {
                    var iHeight = height[i] < height[j] ? height[i] : height[j];
                    var iWidth = j - i;
                    var iArea = iHeight * iWidth;
                    maxArea = iArea > maxArea ? iArea : maxArea;
                }
            }

            return maxArea;
        }
    }
}
