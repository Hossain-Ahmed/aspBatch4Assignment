using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class EvenOdd : Calculation
    {
        public override void Result(int a)
        {
            if (a%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
