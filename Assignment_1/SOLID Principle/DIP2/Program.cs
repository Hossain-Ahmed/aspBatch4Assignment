using System;

namespace DIP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            SmartMobile smartMobile = new SmartMobile(display);

        }
    }
}
