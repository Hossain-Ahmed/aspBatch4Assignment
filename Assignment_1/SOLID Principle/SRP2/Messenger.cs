using System;
using System.Collections.Generic;
using System.Text;

namespace SRP2
{
    public class Messenger
    {
        public void Message(string error)
        {
            Console.WriteLine("Division not possible:"+ error);
        }
    }
}