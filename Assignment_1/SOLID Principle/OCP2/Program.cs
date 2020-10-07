using System;

namespace OCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputBalance = int.Parse(Console.ReadLine());

            SavingAccount saving = new SavingAccount(inputBalance);
            Console.WriteLine(saving.CalcInterest());
            

            CurrentAccount current = new CurrentAccount(inputBalance);
            Console.WriteLine(current.CalcInterest()); 
        }
    }
}
