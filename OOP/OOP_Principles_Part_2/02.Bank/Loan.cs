using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Loan : Account, IDepositable
    {
        public Loan(Customer cl, decimal bal, decimal intrst)
            : base(cl, bal, intrst)
        { }


        public override decimal InterestAmount(int months)
        {
            if (months<0)
            {
                throw new ArgumentException("Number of months should be a non-negative value");
            }
 
            if (months >= 3)
            {
                months -= (int)this.Client;
            }
            else
            {
                months = 0;
            }
            return base.InterestAmount(months);
        }
    }
}
