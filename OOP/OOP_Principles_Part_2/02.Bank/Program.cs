using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {           
            var individualLoan = new Loan(Customer.Individual, 10000m, 5.5m);

            Console.WriteLine(individualLoan.InterestAmount(4));
            
            var companyLoan = new Loan(Customer.Company, 10000m, 5.5m);

            Console.WriteLine(companyLoan.InterestAmount(4));

        }
    }
}
