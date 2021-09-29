namespace LeetCode_28
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if(needle.Length > haystack.Length)
            {
                return -1;
            }

            if(needle.Length == 0)
            {
                return 0;
            }

            for(var i = 0; i < haystack.Length; i++)
            {
                if((i + needle.Length > haystack.Length))
                {
                    break;
                }

                if (IsEqual(haystack[i..(i + needle.Length)], needle))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool IsEqual(string target, string orginal)
        {
            for (var i = 0; i < target.Length; i++)
            {
                if (target[i] != orginal[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
