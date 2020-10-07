using System;
using System.Collections.Generic;
using System.Text;

namespace OCP2
{
    public class SavingAccount : IDeptAccount
    {
        public double Balance { get; set; }

        public SavingAccount(double balance)
        {
            Balance = balance;
        }

        public double CalcInterest()
        {
            double Interest = (Balance * 4) / 100;
            return Interest;
        }
    }
}
