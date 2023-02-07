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
    }
}
 