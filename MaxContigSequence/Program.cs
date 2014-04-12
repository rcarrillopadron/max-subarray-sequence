using System;

namespace MaxContigSequence
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(MaxSequence(new[] {5, -2, 3}));
            Console.WriteLine(MaxSequence(new[] {-2, -3, 4, -1, -2, 1, 5, -3}));
        }

        private static int MaxSequence(int[] a)
        {
            if (a == null) throw new ArgumentNullException("a");
            int current = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (current < 0) current = 0;
                current = current + a[i];
                if (current > max) max = current;
            }
            return max;
        }
    }
}
