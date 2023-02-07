using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBank
{
    public class CheckingAccount
    {
        public int agency;
        public string account;
        public string accountHolder;
        public double balance;

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
                return true;
            }
            else
            { return false; }
        }

        public bool Transfer(double amount, CheckingAccount targetAccount)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                this.balance -= amount;
                targetAccount.balance += amount;
                return true;
            }
        }
    }
}
 