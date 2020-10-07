using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class ResultCalculator
    {

        public void FinalResult(int a)
        {
            var evenOdd = new EvenOdd();
            evenOdd.Result(a);
            var primeNumber = new PrimeNumber();
            primeNumber.Result(a);

 
        }
    }
}
