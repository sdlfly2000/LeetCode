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

            for(var i = 0; i < sortedNums.Count - 2; i++)
            {
                var groups = GetGroups(sortedNums.GetRange(i + 1, sortedNums.Count - i - 1), sortedNums[i]);
                foreach (var group in groups)
                {
                    if (!Exist(retList, group))
                    {
                        retList.Add(group);
                    }
                }                
            }          

            return retList;
        }

        private IList<IList<int>> GetGroups(IList<int> sortedSubNumbers, int targetNumber)
        {
            var retList = new List<IList<int>>();
            var startIndex = 0;
            var endIndex = sortedSubNumbers.Count - 1;

            while(startIndex < endIndex)
            {
                if((sortedSubNumbers[startIndex] + sortedSubNumbers[endIndex] + targetNumber) > 0)
                {
                    endIndex--;
                }
                else if ((sortedSubNumbers[startIndex] + sortedSubNumbers[endIndex] + targetNumber) == 0)
                {
                    var group = new List<int> { targetNumber, sortedSubNumbers[startIndex], sortedSubNumbers[endIndex] };

                    if (!Exist(retList, group))
                    {
                        retList.Add(group);
                    }

                    startIndex++;
                    endIndex--;

                    while ((startIndex < endIndex) && (sortedSubNumbers[startIndex] == sortedSubNumbers[startIndex - 1])) startIndex++;
                    while ((startIndex < endIndex) && (sortedSubNumbers[endIndex] == sortedSubNumbers[endIndex + 1])) endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            
            return retList;
        }

        private bool Exist(IList<IList<int>> container, IList<int> target)
        {
            var isFound = false;
            foreach (var item in container)
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
