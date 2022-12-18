namespace LeetCode_34
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new int[2];

            if(nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }

            if (nums.Length == 1)
            {

                return nums[0] == target 
                    ? new int[] {0,0} 
                    : new int[] { -1, -1 };
            }

            var posIndex = TransverseSearch(nums, target);
            if (posIndex == -1)
            {
                result[0] = posIndex;
                result[1] = posIndex;
            }
            else
            {
                for(var i = posIndex; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        result[1] = i;
                    }
                    else
                    {
                        break;
                    }
                }

                for(var i = posIndex; i >= 0; i--)
                {
                    if (nums[i] == target)
                    {
                        result[0] = i;
                    }
                    else
                    {
                        break;
                    }
                }         
            }

            return result;
        }

        private int TransverseSearch(int[] subNums, int target)
        {
            var pos = -1;

            var totalLength = subNums.Length;

            if(totalLength == 0)
            {
                return -1;
            }

            var halfLength = totalLength%2 == 0
                ? totalLength / 2
                : (totalLength + 1) / 2;

            var midIndex = halfLength - 1;

            if (subNums[midIndex] == target)
            {
                return midIndex;
            }
            else if (subNums[midIndex] < target)
            { 
                pos = TransverseSearch(subNums[(midIndex+1)..], target);
                pos = (pos == -1) ? -1 : midIndex + pos + 1;
            }
            else
            {
                pos = TransverseSearch(subNums[0..midIndex], target);
                pos = (pos == -1) ? -1 : pos;
            }

            return pos;
        }
    }
}