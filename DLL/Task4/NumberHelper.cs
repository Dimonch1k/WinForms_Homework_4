using System;

namespace Task4
{
    public class NumberHelper
    {
        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
