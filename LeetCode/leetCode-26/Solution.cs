namespace leetCode_26
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var current = 101;

            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] != current)
                {
                    current = nums[i];
                }
                else
                {
                    nums[i] = 101;
                }
            }

            return Compact(nums);
        }

        private int Compact(int[] nums)
        {
            var defaultCount = 0;

            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 101)
                {
                    defaultCount++;
                    continue;
                }
                else
                {
                    nums[i - defaultCount] = nums[i];
                }
            }

            for(var i = nums.Length - defaultCount; i < nums.Length; i++)
            {
                nums[i] = 101;
            }

            return nums.Length - defaultCount;
        }
    }
}
