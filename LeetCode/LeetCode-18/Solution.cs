using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_18
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        { 
            var results = new List<IList<int>>();

            if (nums.Length < 3)
            {
                return results;
            }
            else if (nums.Length == 4)
            {
                var sum = nums[0] + nums[1] + nums[2] + nums[3];
                if (sum == target)
                {
                    results.Add(new List<int> { nums[0], nums[1], nums[2], nums[3] });
                }

                return results;
            }

            Array.Sort(nums);

            for (var i = 0; i <= nums.Length - 4; i++)
            {
                for(var j = i + 1; j <= nums.Length - 3; j++)
                {
                    var startIndex = j + 1;
                    var endIndex = nums.Length - 1;

                    while(startIndex < endIndex)
                    {
                        var tempSum = nums[i] + nums[j] + nums[startIndex] + nums[endIndex];

                        if(tempSum == target)
                        {
                            var check = new List<int> { nums[i], nums[j], nums[startIndex], nums[endIndex] };
                            if (!IsExist(check, results))
                            {
                                results.Add(check);
                            } 
                        }

                        if (tempSum < target)
                        {
                            startIndex++;
                        }
                        else
                        {
                            endIndex--;
                        }
                    }
                }
            }

            return results;
        }

        private bool IsExist(IList<int> check, IList<IList<int>> container)
        {
            return container.Any(item => IsEqual(check.ToArray(), item.ToArray()));
        }

        private bool IsEqual(int[] checks, int[] references)
        {
            Array.Sort(checks);
            Array.Sort(references);

            if(checks.Length != references.Length) 
            { 
                return false;
            }

            for(var i = 0; i< checks.Length; i++)
            {
                if (checks[i] != references[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
