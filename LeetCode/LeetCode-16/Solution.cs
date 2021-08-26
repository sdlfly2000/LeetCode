using System;

namespace LeetCode_16
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            var mostCloseSum = 0;
            var diffTarget = int.MaxValue;

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        var tempSum = nums[i] + nums[j] + nums[k];

                        var currentDiff = tempSum - target;

                        if (tempSum == target)
                        {
                            return tempSum;
                        }

                        if (Math.Abs(currentDiff) < Math.Abs(diffTarget))
                        {
                            mostCloseSum = tempSum;
                            diffTarget = tempSum - target;
                        }

                        if (tempSum > target && Math.Abs(currentDiff) >= Math.Abs(diffTarget))
                        {
                            break;
                        }
                    }
                }
            }

            return mostCloseSum;
        }
    }
}
