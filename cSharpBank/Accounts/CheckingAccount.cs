using cSharpBank.AccountHolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBank.Accounts
{
    public class CheckingAccount
    {
        public int agency;
        public string account;
        private double balance = 0;

        public Client accountHolder;
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            { return false; }
        }

        public bool Transfer(double amount, CheckingAccount targetAccount)
        {
            if (balance < amount)
            {
                return false;
            }
            else
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
                return true;
            }
        }

        public void SetBalance(double amount)
        {
            if (amount < 0) 
            {
                return;
            }
            else
            {
                this.balance = amount;
            }
        }

        public double GetBalance()
        {
            return this.balance;
        }
    }
}
