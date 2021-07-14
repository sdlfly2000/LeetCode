namespace LeetCode_13
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var ret = 0;
            for(var i = s.Length - 1; i >= 0; i--)
            {
                var sign = ((i + 1) == s.Length) ? GetSign(s[i]) : GetSign(s[i], s[i + 1]);
                var temp = MapToInt(s[i]) * sign;
                ret = ret + temp;
            }

            return ret;
        }

        private int GetSign(char current, char previous = '\0')
        {
            if(previous == '\0')
            {
                return 1;
            }

            return (current == 'I' && previous == 'V') || 
                (current == 'I' && previous == 'X') || 
                (current == 'X' && previous == 'L' ) ||
                (current == 'X' && previous == 'C') ||
                (current == 'C' && previous == 'D') ||
                (current == 'C' && previous == 'M')                
                ? -1
                : 1;

        }

        private int MapToInt(char roman)
        {
            switch (roman)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }

            return 0;
        }
    }
}
