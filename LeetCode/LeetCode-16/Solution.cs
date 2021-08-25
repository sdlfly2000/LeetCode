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

            var isIncreaseStartIndex = false;

            while (startIndex < endIndex)
            {
                var moveList = numList.GetRange(startIndex + 1, endIndex - startIndex - 1);
                if(moveList.Count == 0)
                {
                    break;
                }
                for(var moveIndex = 0; moveIndex < moveList.Count; moveIndex++)
                {
                    var tempSum = numList[startIndex] + moveList[moveIndex] + numList[endIndex];

                    if(tempSum == target)
                    {
                        return tempSum;
                    }

                    if(tempSum > target)
                    {
                        CheckClosest(numList[startIndex] + numList[endIndex], moveList[moveIndex], target, mostCloseSum, diffTarget, out mostCloseSum, out diffTarget);
                        isIncreaseStartIndex = false;
                        endIndex--;
                        break;
                    }

                    if(tempSum < target)
                    {
                        CheckClosest(numList[startIndex] + numList[endIndex], moveList[moveIndex], target, mostCloseSum, diffTarget, out mostCloseSum, out diffTarget);
                        isIncreaseStartIndex = true;
                    }
                }

                if (isIncreaseStartIndex)
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
