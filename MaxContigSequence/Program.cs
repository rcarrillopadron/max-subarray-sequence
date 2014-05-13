using System;

namespace MaxContigSequence
{
    class Program
    {
        static void Main()
        {
            var sequence = new[] {-2, -3, 4, -1, -2, 1, 5, -3};
            var calculator = new SequenceCalculator();
            int result = calculator.CalculateMaxSum(sequence);
            Console.WriteLine(result);
        }
    }
}
