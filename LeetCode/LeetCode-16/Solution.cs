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

            var startIndex = 0;
            var endIndex = numList.Count - 1;

            var mostCloseSum = 0;
            var diffTarget = int.MaxValue;

            while (startIndex < endIndex)
            {
                var sumStartAndEnd = numList[startIndex] + numList[endIndex];

                if(sumStartAndEnd >= target &&
                    (endIndex - startIndex + 1) > 2)
                {
                    CheckClosest(sumStartAndEnd, numList[startIndex + 1], target, mostCloseSum, diffTarget, out mostCloseSum, out diffTarget);
                    endIndex--;
                    continue;
                }else if (sumStartAndEnd < target)
                {
                    var tempList = numList.GetRange(startIndex + 1, endIndex - startIndex - 1);

                    tempList.ForEach(temp =>
                    {
                        CheckClosest(sumStartAndEnd, temp, target, mostCloseSum, diffTarget, out mostCloseSum, out diffTarget);
                    });

                    startIndex++;
                }
                else
                {
                    startIndex++;
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
