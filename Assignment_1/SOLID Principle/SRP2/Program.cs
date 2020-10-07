using System;
using System.ComponentModel.DataAnnotations;

namespace SRP2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Division division = new Division();
            division.Divider(input);
        }
    }
}
