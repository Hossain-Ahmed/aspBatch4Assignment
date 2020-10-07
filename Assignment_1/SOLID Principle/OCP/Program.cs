using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ResultCalculator result = new ResultCalculator();
            result.FinalResult(int.Parse(Console.ReadLine()));
        }
    }
}