using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace.Bank.Account
{
    public class SavingsAccount
    {
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }
        public double Interest { get; private set; }

        public SavingsAccount(string ownerName, double balance, double interest)
        {
            this.OwnerName = ownerName;
            this.Balance = balance;
            this.Interest = interest;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposit a negative amount");
            }
            this.Balance += amount;
        }

        private void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot withdraw a negative amount");
            }
            this.Balance -= amount;
        }

        public void Transfer(SavingsAccount destinationAccount, double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot transfer a negative amount");
            }
            destinationAccount.Deposit(amount);
            Withdraw(amount);
        }

        public void ApplyInterest(int years)
        {
            double rate = this.Interest;
            const double numPerYear = 1;
            double temp = (1 + (rate/numPerYear));
            temp = Math.Pow(temp, (years*numPerYear));
            this.Balance = (this.Balance * temp);
        }
    }
}
