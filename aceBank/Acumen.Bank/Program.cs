using System;
using System.Threading;
using Ace.Bank.Account;

namespace Ace.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ace Bank!");
		    Console.WriteLine();

		    CheckingAccount michaelsAccount = new CheckingAccount("Michael", 5000);
		    CheckingAccount gobsAccount = new CheckingAccount("Gob", 2000);

		    Console.WriteLine("Open Accounts:");
		    Console.WriteLine();
		    PrintAccountDetails(michaelsAccount);
		    Console.WriteLine();
		    PrintAccountDetails(gobsAccount);

		    Console.WriteLine();
		    Console.WriteLine("Making transfer of $1000.00...");
            try
            {
                Thread.Sleep(500);
            }
            catch (ThreadInterruptedException)
            {
                return;
            }

		    michaelsAccount.Transfer(gobsAccount, 1000);

		    Console.WriteLine("Updated Account Details:");
		    Console.WriteLine();
		    PrintAccountDetails(michaelsAccount);
		    Console.WriteLine();
		    PrintAccountDetails(gobsAccount);
            Console.WriteLine();


            // Initialize new savings account with initial balance of $30,000 and 0.89% interest
            SavingsAccount acesSavingsAccount = new SavingsAccount("Ace", 30000, .0089);
             
            SavingsAccount garysSavingsAccount = new SavingsAccount("Gary", 10000, .0056);

            SavingsAccount kaelsSavingsAccount = new SavingsAccount("Kael", 1500, 0.043);

            Console.WriteLine("Open Accounts:");
            Console.WriteLine();
            PrintSavingsAccountDetails(acesSavingsAccount);
            Console.WriteLine();
            PrintSavingsAccountDetails(garysSavingsAccount);
            Console.WriteLine();
            PrintSavingsAccountDetails(kaelsSavingsAccount);
            Console.WriteLine();

            acesSavingsAccount.Transfer(garysSavingsAccount, 5000);
            Console.WriteLine("Making transfer of $5000.00...");
            try
            {
                Thread.Sleep(500);
            }
            catch (ThreadInterruptedException)
            {
                return;
            }

            Console.WriteLine("Updated Savings Account Details:");
            Console.WriteLine();
            PrintSavingsAccountDetails(acesSavingsAccount);
            Console.WriteLine();
            PrintSavingsAccountDetails(garysSavingsAccount);
            Console.WriteLine();

            // apply 2 years of interest to the savings accounts
            acesSavingsAccount.ApplyInterest(2);
            garysSavingsAccount.ApplyInterest(2);
            // apply 6 years of interest to Kael
            kaelsSavingsAccount.ApplyInterest(6);

            Console.WriteLine("Updated Savings Account Balance After Interest:");
            Console.WriteLine();
            PrintSavingsAccountDetails(acesSavingsAccount);
            Console.WriteLine();
            PrintSavingsAccountDetails(garysSavingsAccount);
            Console.WriteLine();
            PrintSavingsAccountDetails(kaelsSavingsAccount);
            Console.WriteLine();
            Console.ReadLine();

        }

	    private static void PrintAccountDetails(CheckingAccount account) {
		    Console.WriteLine("Account for {0}:\r\n", account.OwnerName);
            Console.WriteLine("Balance: {0:C2}\r\n", account.Balance);
	    }

        private static void PrintSavingsAccountDetails(SavingsAccount account)
        {
            Console.WriteLine("Account for {0}:\r\n", account.OwnerName);
            Console.WriteLine("Balance: {0:C2}\r\n", account.Balance);
        }
    }
}
