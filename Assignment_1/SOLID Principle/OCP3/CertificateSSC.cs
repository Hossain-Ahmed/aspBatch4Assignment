using System;
using System.Collections.Generic;
using System.Text;

namespace OCP3
{
    public class CertificateSSC : ICertificate
    {
        public void Certificate(Student student)
        {
            Console.WriteLine("SSC certificate of having id: "+student.Sid);
            Console.WriteLine(student.SName+" You have got "+student.SGpa);
        }
    }
}
