using System;

namespace SRP3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            FibonacciClass fibonacciClass = new FibonacciClass();
            fibonacciClass.FibonacciNumber(input);

            Console.WriteLine();
            Console.WriteLine();

            EvenOdd evenOdd = new EvenOdd();
            evenOdd.check(input);

        }
    }
}
