using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_16
{
    public class Solution2
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            var mostClosestSum = 0;
            var mostClosestDiff = int.MaxValue;

            for (var index = 0; index < nums.Length; index++)
            {
                var startIndex = index + 1;
                var endIndex = nums.Length - 1;

                while (startIndex < endIndex)
                {
                    var currentSum = nums[index] + nums[startIndex] + nums[endIndex];
                    var currentDiff = currentSum - target;

                    if (currentSum == target)
                    {
                        return currentSum;
                    }

                    if (Math.Abs(currentDiff) < Math.Abs(mostClosestDiff))
                    {
                        mostClosestSum = currentSum;
                        mostClosestDiff = currentDiff;
                    }

                    if (currentSum <= target)
                    {
                        startIndex++;
                    }

                    if (currentSum > target)
                    {
                        endIndex--;
                    }
                }
            }

            return mostClosestSum;
        }
    }
}
