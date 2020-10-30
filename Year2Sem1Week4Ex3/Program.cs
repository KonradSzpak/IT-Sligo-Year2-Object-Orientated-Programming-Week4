using System;

namespace Year2Sem1Week4Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount b1 = new BankAccount("123456", "tom", 1000);
            BankAccount b2 = new BankAccount("654321", "mary", 2000);

            Console.WriteLine(b1.AccDetails());
            Console.WriteLine(b2.AccDetails());

            b1.AddFunds(1000);

            Console.WriteLine(b1.AccDetails());

            b2.WithDraw(100);

            Console.WriteLine(b2.AccDetails());

        }
    }
}
