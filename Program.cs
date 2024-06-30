// Program.cs
using System;

namespace ATM_Mockup
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(500.00m); // Initial balance set to 500.00

            while (true)
            {
                Console.WriteLine("\nWelcome to the ATM");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        atm.CheckBalance();
                        break;
                    case "2":
                        Console.Write("Enter the amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            atm.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter the amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            atm.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
