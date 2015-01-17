using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer cl, decimal bal, decimal intrst)
            : base(cl, bal, intrst)
        { }


        public override decimal InterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Number of months should be a non-negative value");
            }

            decimal halfInterest = base.InterestAmount(6);
                // half of the interest for the first 12 months equals the full interest for 6 months             

            if (this.Client == Customer.Individual && months <= 6)
            {
                return 0;
            }
            else if (this.Client == Customer.Company && months<=12)
            {
                halfInterest = base.InterestAmount(months/2);
            }

            return base.InterestAmount(months) - halfInterest;
        }
    }
}
