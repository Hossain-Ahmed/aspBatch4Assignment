using System;
using System.Collections.Generic;
using System.Text;

namespace OCP2
{
    public interface IDeptAccount
    {
        double Balance { get; set; }
        double CalcInterest();
    }
}
