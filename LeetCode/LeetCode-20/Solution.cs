using System;
using System.Collections;

namespace LeetCode_20
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var symbolStack = new Stack();
            var isValid = true;

            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        symbolStack.Push(s[i]);
                        continue;
                }

                switch (s[i])
                {
                    case ')':
                        isValid = CheckValidation(symbolStack, '(');
                        break;
                    case '}':
                        isValid = CheckValidation(symbolStack, '{');
                        break;
                    case ']':
                        isValid = CheckValidation(symbolStack, '[');
                        break;
                }

                if (!isValid)
                {
                    return false;
                }
            }

            return isValid && symbolStack.Count == 0;
        }

        private bool CheckValidation(Stack symbolStack, char symbol)
        {
            if(symbolStack.Count > 0)
            {
                var symbolPopout = symbolStack.Pop();

                if (symbolPopout.Equals(symbol))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
