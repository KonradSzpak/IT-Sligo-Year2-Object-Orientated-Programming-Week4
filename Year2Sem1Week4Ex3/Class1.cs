using System;
using System.Collections.Generic;
using System.Text;

namespace Year2Sem1Week4Ex3
{
    class BankAccount
    {
        public string AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            
        }

        public string AccDetails() //this is called when needed basically XD
        {
            return $"{AccountNumber} {AccountHolder} {Balance}";

                
        }


        public void AddFunds(decimal amount)
        {
            Balance += amount;
        }


        public void WithDraw(decimal amount)
        {
            Balance -= amount;
        }

    }
}
