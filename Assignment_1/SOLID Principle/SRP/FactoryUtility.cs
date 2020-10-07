using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class FactoryUtility : IFactorySupport
    {
        public void StartMachine()
        {
            Console.WriteLine("From Start machine");
        }

        public void StopMachine()
        {
            Console.WriteLine("From Stop machine");   
        }
    }
}
