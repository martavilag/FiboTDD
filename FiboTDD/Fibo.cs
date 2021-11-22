using System;

namespace FiboTDD
{
    public class Fibo
    {
        public static int Calculate(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Calculate(n - 1) + Calculate(n - 2);

        }
    }
}