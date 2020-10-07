using System;
using System.Collections.Generic;
using System.Text;

namespace OCP2
{
    public class CurrentAccount:IDeptAccount
    {
        public double Balance { get; set; }

        public CurrentAccount(double balance) 
        {
            Balance = balance;
        }

        public double CalcInterest()
        {
            double Interest = (Balance * 6) / 100;
            return Interest;
        }
    }
}
