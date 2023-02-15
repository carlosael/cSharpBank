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
        public static int AccountsCreated { get; private set; }

        public static float OperationFee { get; private set; }

        private int agency;
        public int Agency
        {
            get { return this.agency; }
            private set { 
                    if(value > 0)
                    {
                        this.agency = value;
                    }
                }
        }
        private string Account {  get; set; }  
        
        private double balance = 0;

        public Client AccountHolder { get; set; }
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

        public CheckingAccount(int agency, string account)
        {
            if (agency <= 0)
            {
                throw new ArgumentException("Agency number must be higher than 0.", nameof(agency));
            }
            this.agency = agency;
            this.Account = account;

            //OperationFee = 30 / AccountsCreated;
            AccountsCreated++;
        }
    }
}
