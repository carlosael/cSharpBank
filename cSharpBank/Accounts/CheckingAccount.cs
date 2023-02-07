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
        public double balance = 0;

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
    }
}
