namespace LeetCode_27
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var removeCount = 0;

            for(var i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] != val ? nums[i] : 51;
            }

            for(var i = 0; i< nums.Length; i++)
            {
                if(nums[i] == 51)
                {
                    removeCount++;
                    continue;
                }

                nums[i-removeCount] = nums[i];
            }

            for(var i = nums.Length - removeCount; i < nums.Length; i++)
            {
                nums[i] = 51;
            }

            return nums.Length - removeCount;
        }
    }
}
