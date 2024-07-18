using System;

namespace Task3
{
    public class MinMaxSum
    {
        public string GetMinMaxSum(int a, int b, int c)
        {
            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));
            int sum = a + b + c;

            return $"Min: {min} \nMax: {max} \nSum: {sum}";
        }
    }
}
