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

            while(startIndex < endIndex)
            {
                var group = GetGroup(sortedNums.GetRange(startIndex, endIndex));
                if(group != null)
                {
                    retList.Add(group);
                }

                if( Abs(sortedNums[startIndex]) > Abs(sortedNums[endIndex]))
                {
                    startIndex++;
                }
                else
                {
                    endIndex--;
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
    }
}
