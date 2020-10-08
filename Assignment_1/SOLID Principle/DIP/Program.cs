using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            ChipSet chip = new ChipSet();

            Laptop laptop = new Laptop(chip);
        }
    }
}
