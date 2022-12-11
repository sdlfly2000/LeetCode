namespace LeetCode_33
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            var result = -1;
            var maxIndex = nums.Length - 1;
            
            if (nums.Length < 4)
            {
                for(var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        return i;
                    }
                }

                return -1;
            }

            for(var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result = i;
                    break;
                }
                else if (nums[i] > target)
                {
                    if (nums[maxIndex-i] == target)
                    {
                        result = maxIndex - i;
                        break;
                    }

                    if (nums[maxIndex - i] < target)
                    {
                        result = -1;
                        break;
                    }

                    if (nums[maxIndex - i] > target)
                    {
                        for(var n = maxIndex - i - 1; n >= 0 && nums[n] < nums[n+1]; n--)
                        {
                            if (nums[n] > target)
                            {
                                continue;
                            }
                            if (nums[n] == target)
                            {
                                result = n; 
                                break;
                            }
                            if (nums[n] < target)
                            {
                                result = -1;
                                break;
                            }

                        }

                        break;
                    }
                }
                else if (nums[i] < target)
                {
                    for (var n = i + 1; n <= maxIndex && nums[n] > nums[n - 1]; n++)
                    {
                        if (nums[n] == target)
                        {
                            result = n; 
                            break;
                        }

                        if (nums[n] > target)
                        {
                            result = -1; 
                            break;
                        }

                        if (nums[n] < target)
                        {
                            continue;
                        }
                    }

                    break;
                }
            }

            return result;
        }
    }
}