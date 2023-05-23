using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Bank_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(2000M, 3000M, "Jimothy Halpert");
            bool isRunning = true;
            string option;

            void printMenu()
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. See Balance");
                Console.WriteLine("4. Exit");
            }

            while (isRunning)
            {
                printMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("How much would you like to deposit, " + c._memberName + "? ");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Depositing: " + String.Format("{0:C2}", deposit));
                        c.Deposit(deposit);
                        Console.WriteLine("Your new balances are: ");
                        Console.WriteLine("Checking: " + String.Format("{0:C2}", c._checkingBalance));
                        Console.WriteLine("Savings: " + String.Format("{0:C2}", c._savingsBalance));
                        break;

                    case "2":
                        Console.Write("How much would you like to withdraw, " + c._memberName + "? ");
                        decimal withdrawal = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Withdrawing: " + String.Format("{0:C2}", withdrawal));
                        if (withdrawal <= (c._checkingBalance + c._savingsBalance) - 10)
                        {
                            c.Withdraw(withdrawal);
                            Console.WriteLine("Your new balances are: ");
                            Console.WriteLine("Checking: " + String.Format("{0:C2}", c._checkingBalance));
                            Console.WriteLine("Savings: " + String.Format("{0:C2}", c._savingsBalance));
                        }
                        else if (withdrawal > (c._checkingBalance + c._savingsBalance - 10))
                        {
                            Console.WriteLine(c.errorWMessage);  // use exception instead which can be used in test
                        }
                        break;

                    case "3":
                        Console.WriteLine("Your account balances are: ");
                        Console.WriteLine("Checking: " + String.Format("{0:C2}", c._checkingBalance));
                        Console.WriteLine("Savings: " + String.Format("{0:C2}", c._savingsBalance));
                        break;

                    case "4":
                        Console.WriteLine("Exiting Program...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please select an option from the menu...");
                        break;
                }
            }
        }
    }
}