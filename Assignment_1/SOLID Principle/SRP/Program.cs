using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryUtility factoryUtility = new FactoryUtility();
            Factory factory = new Factory(factoryUtility);
            factory.StartServiceMachine();
            factory.StopServiceMachine();
        }
    }
}
