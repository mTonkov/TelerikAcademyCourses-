using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer cl, decimal bal, decimal intrst)
            : base(cl, bal, intrst)
        { }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal InterestAmount(int months)
        {
            decimal minimumInterestAmount = 1000;

            if (this.Balance < minimumInterestAmount)
            {
                return 0;
            }
            return base.InterestAmount(months);
        }
    }
}
