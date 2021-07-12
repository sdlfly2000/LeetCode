using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_11
{
    public class Solution2
    {
        // Double Point Arg
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var i = 0;
            var j = height.Length - 1;
            while (i < j)
            {
                var iHeight = height[i] < height[j] ? height[i] : height[j];
                var iWidth = j - i;
                var area = iHeight * iWidth;
                maxArea = area > maxArea ? area : maxArea;
                if(height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxArea;
        }
    }
}
