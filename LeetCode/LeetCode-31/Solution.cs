namespace LeetCode_31
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            var isSwapped = false;
            for (var lastIndex = nums.Length - 1; lastIndex > 0; lastIndex--)
            {
                if(nums[lastIndex] > nums[lastIndex - 1])
                {
                    for (var innerIndex = nums.Length - 1; innerIndex > lastIndex-1; innerIndex--)
                    {
                        if (nums[lastIndex - 1] < nums[innerIndex])
                        {
                            Swap(nums, lastIndex - 1, innerIndex);
                            OrderInc(nums, lastIndex);
                            isSwapped = true;
                            return;
                        }
                    }
                }
            }

            if(!isSwapped)
            {
                OrderInc(nums, 0);
            }
        }

        private void Swap(int[] nums, int from, int to)
        {
            var swap = nums[from];
            nums[from] = nums[to];
            nums[to] = swap;
        }

        private void OrderInc(int[] nums, int from)
        {
            var length = nums.Length;

            for(var index = from; index < length; index++)
            {
                for(var innerIndex = index+1; innerIndex < length; innerIndex++)
                {
                    if(nums[innerIndex] < nums[index])
                    {
                        var swap = nums[innerIndex];
                        nums[innerIndex] = nums[index];
                        nums[index] = swap;
                    }
                }
            }
        }
    }
}
