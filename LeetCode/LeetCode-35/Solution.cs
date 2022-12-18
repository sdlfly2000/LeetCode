namespace LeetCode_35
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return TransSearch(nums, target);
        }

        private int TransSearch(int[] subNums, int target)
        {
            var posIndex = 0;

            var length = subNums.Length;

            if(length == 0)
            {
                return posIndex;
            }

            var halfIndex = length % 2 == 0
                ? length / 2
                : (length - 1) / 2;

            if (subNums[halfIndex] == target)
            {
                return halfIndex;
            }

            if (subNums[halfIndex] < target)
            {
                posIndex = halfIndex + 1 + TransSearch(subNums[(halfIndex + 1)..], target);
            }
            else
            {
                posIndex = TransSearch(subNums[0..halfIndex], target);
            }

            return posIndex;
        }
    }
}