using System;

namespace MaxContigSequence
{
    class SequenceCalculator
    {
        public int CalculateMaxSum(int[] sequence)
        {
            if (sequence == null) throw new ArgumentNullException("sequence");
            int current = 0;
            int max = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (current < 0) current = 0;
                current = current + sequence[i];
                if (current > max) max = current;
            }
            return max;
        }
    }
}