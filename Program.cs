using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] { -3, 1, 2, -2, 5, 6 };
            Console.WriteLine(GetMaximumProductOfThree(a));
        }

        private static int GetMaximumProductOfThree(int[] a)
        {
            // .Net Core 5 standard sort
            Array.Sort(a);
            var n = a.Length;

            var max1 = a[n - 3] * a[n - 2] * a[n - 1];
            var max2 = a[0] * a[1] * a[n - 1];

            if (max1 > max2)
                return max1;
            else
                return max2;

        }
    }
}
