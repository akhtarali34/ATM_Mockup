// ATM.cs
using System;

namespace ATM_Mockup
{
    class ATM
    {
        private decimal balance;

        public ATM(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"You have successfully deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"You have successfully withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }
}
