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
        public double balance = 0;
        public string accountHolder;

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
                this.Withdraw(amount);
                targetAccount.Deposit(amount);
                return true;
            }
        }
    }
}
 