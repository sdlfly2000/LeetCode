using System.Collections.Generic;

namespace LeetCode_15
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var retList = new List<IList<int>>();
            var sortedNums = new List<int>(nums);
            sortedNums.Sort();
            var startIndex = 0;
            var endIndex = nums.Length - 1;
            var equalFound = false;

            while(startIndex < endIndex)
            {
                var group = GetGroup(sortedNums.GetRange(startIndex, endIndex - startIndex + 1)); 

                if (group != null && !Exist(retList, group))
                {
                    retList.Add(group);
                }

                if (equalFound)
                {
                    startIndex--;
                    endIndex--;
                    equalFound = false;
                    continue;
                }

                if (Abs(sortedNums[startIndex]) > Abs(sortedNums[endIndex]))
                {
                    startIndex++;
                    equalFound = false;
                }
                else if(Abs(sortedNums[startIndex]) == Abs(sortedNums[endIndex]))
                {
                    startIndex++;
                    equalFound = true;
                }
                else
                {
                    endIndex--;
                    equalFound = false;
                }
            }

            return retList;
        }

        private IList<int> GetGroup(IList<int> sortedSubNumbers)
        {
            var leftNumber = sortedSubNumbers[0];
            var rightNumber = sortedSubNumbers[sortedSubNumbers.Count - 1];
            var sumLeftAndRight = rightNumber + leftNumber;

            for(var i = 1; i < sortedSubNumbers.Count - 1; i++)
            {
                if((sumLeftAndRight + sortedSubNumbers[i]) == 0)
                {
                    return new List<int> { leftNumber, sortedSubNumbers[i], rightNumber };
                }
            }

            return null;
        }

        private int Abs(int number)
        {
            return number > 0 
                ? number 
                : number * (-1);
        }

        private bool Exist(IList<IList<int>> container, IList<int> target)
        {
            var isFound = false;
            foreach(var item in container)
            {
                if (!isFound)
                {
                    if (item.Count == target.Count)
                    {
                        var i = 0;
                        while (item[i] == target[i])
                        {
                            i++;
                            if (i >= item.Count)
                            {
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
            }

            return isFound;
        }
    }
}
