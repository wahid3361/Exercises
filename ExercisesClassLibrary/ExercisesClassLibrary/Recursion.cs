using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClassLibrary
{
    public static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int Power(int n, int power)
        {
            if (power == 1)
            {
                return n;
            }
            else
            {
                return n * Power(n, power - 1);
            }
        }
    }
}
