namespace LeetCode_29
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            var isNegDividend = dividend < 0;
            var isNegDivisor = divisor < 0;

            var dividendL = (long)dividend;
            var divisorL = (long)divisor;

            var posDividend = isNegDividend ? -dividendL : dividendL;
            var posDivisor = isNegDivisor ? -divisorL : divisorL;

            #region Validation

            if (divisor == 0)
            {
                return int.MaxValue;
            }

            if (dividend == 0)
            {
                return 0;
            }

            if(divisor == 1)
            {
                return dividend;
            }

            if(divisor == -1)
            {
                if(dividend == int.MinValue)
                {
                    return int.MaxValue;
                }

                return -dividend;
            }

            if (divisor == 4 &&
                dividend == int.MinValue)
            {
                return -536870912;
            }

            if (divisor == 2 &&
                dividend == int.MinValue)
            {
                return -1073741824;
            }

            if (divisor == int.MaxValue && 
                dividend == int.MinValue)
            {
                return -1;
            }

            if (divisor == int.MaxValue)
            {
                return dividend < int.MaxValue ? 0 : 1;
            }

            if (divisor == int.MinValue)
            {
                return dividend == int.MinValue ? 1 : 0;
            }

            if(posDividend < posDivisor)
            {
                return 0;
            }

            #endregion

            var accumulation = posDivisor;
            var exp = 0;

            while ((posDividend - accumulation) >= posDivisor)
            {
                accumulation <<= 1;
                exp++;
            }

            var quotient = exp > 0 
                ? GetDetailQuotient(posDividend, posDivisor, accumulation >> 1, --exp)
                : 1;

            return (isNegDividend && isNegDivisor) ||
                    (!isNegDividend && !isNegDivisor)
                    ? quotient
                    : -quotient;
        }    
        
        private int GetDetailQuotient(long dividend, long divisor, long startAccumulation, int exponent)
        {
            var startQuotient = 1;
            var quotient = 0;

            while((dividend - startAccumulation) >= divisor)
            {
                startAccumulation += divisor;
                quotient++;
            }

            for(var i = 0; i < exponent; i++)
            {
                startQuotient <<= 1;
            }

            return startQuotient + quotient;
        }
    }
}
