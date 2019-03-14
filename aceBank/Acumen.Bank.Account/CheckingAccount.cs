using System;

namespace Ace.Bank.Account
{
    public class CheckingAccount
    {
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }

        public CheckingAccount(string ownerName, double balance)
        {
            this.OwnerName = ownerName;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposit a negative amount");
            }
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot withdraw a negative amount");
            }
            this.Balance -= amount;
        }

        public void Transfer(CheckingAccount destinationAccount, double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot transfer a negative amount");
            }
            destinationAccount.Deposit(amount);
            Withdraw(amount);
        }
    }
}
