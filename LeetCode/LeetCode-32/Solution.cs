namespace LeetCode_32
{
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            var result = 0;
            var stack = new Stack<int>();

            stack.Push(-1);

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    stack.Pop();
                    if(stack.Count == 0)
                    {
                        stack.Push(i);
                    }
                    else 
                    {
                        result = GetMax(result, i-stack.Peek());
                    }
                }
            }

            return result;
        }

        private int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}