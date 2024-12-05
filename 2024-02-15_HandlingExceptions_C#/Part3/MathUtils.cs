using System;

namespace Part3
{
    public class MathUtils
    {
        public static long Factorial(int n)
        {
            long fact = 1;
            for (int i = n; i > 0; i--)//For the number to 1, Fact * i, ie. 5 *1, 4*5, 3*20, 2*60 1* 120
            {
                fact *= i;
            }
            return fact;//Return the result
        }
    }
}
