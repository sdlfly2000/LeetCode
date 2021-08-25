using System;
using System.Collections.Generic;

namespace LeetCode_16
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var numList = new List<int>(nums);
            numList.Sort();

            var mostCloseSum = 0;
            var diffTarget = int.MaxValue;

            for(var i = 0; i < numList.Count; i++)
            {
                for(var j = i+1; j<numList.Count; j++)
                {
                    for(var k= j+ 1; k < numList.Count; k++)
                    {
                        var tempSum = numList[i] + numList[j] + numList[k];

                        if (tempSum == target)
                        {
                            return tempSum;
                        }

                        if(Math.Abs(tempSum - target) < Math.Abs(diffTarget))
                        {
                            mostCloseSum = tempSum;
                            diffTarget = tempSum - target;
                        }
                    }
                }
            }

            return mostCloseSum;
        }

        private void CheckClosest(int sumBeforeCheck, int check, int target, int currentMostCloseSum, int currentDiff, out int newMostCloseSum, out int newDiff)
        {
            var sum = sumBeforeCheck + check;
            var diffTarget = sum - target;

            if(Math.Abs(diffTarget) < Math.Abs(currentDiff))
            {
                newMostCloseSum = sum;
                newDiff = diffTarget;
            }
            else
            {
                newMostCloseSum = currentMostCloseSum;
                newDiff = currentDiff;
            }
        }
    }
}
