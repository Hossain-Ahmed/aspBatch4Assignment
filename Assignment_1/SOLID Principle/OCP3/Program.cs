using System;
using System.Collections.Generic;

namespace OCP3
{
    class Program
    {
        static void Main(string[] args)
        {
            CertificateSSC certS = new CertificateSSC();
            certS.Certificate(new Student { Sid = 1, SName = "Rashed", SGpa = 3.78 });

            Console.WriteLine();

            CertificateHSC certH = new CertificateHSC();
            certH.Certificate(new Student { Sid = 8, SName = "Abir", SGpa = 3.80 });
        }
    }
}
