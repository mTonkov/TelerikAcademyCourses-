using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account : IDepositable, IInterest
    {
        private decimal balance;
        private decimal interest;
       
        public Account(Customer client, decimal bal, decimal interest)
        {
            this.Client = client;
            this.Balance = bal;
            this.InterestRate = interest;
        }

        
        public Customer Client { get; set; }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The initial amount in the account must be a non-negative value");
                }
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interest;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate for the account must be a non-negative value");
                }
                this.interest = value;
            }
        }

        public virtual void DepositMoney(decimal amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Your input is a negative value. To subtract money, you should use the \"Withdraw\" method.");
            }
            this.Balance += amount;
        }
        public virtual decimal InterestAmount(int months) 
        {
            return months * (InterestRate/100) * Balance;
        }
    }
}
