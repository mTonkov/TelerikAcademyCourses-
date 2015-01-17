
namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string fname, string lname)
            : base(fname, lname)
        { }

        public Worker(string fname, string lname, decimal weekSal, decimal workHoursPerDay)
            : this(fname, lname)
        {
            this.weekSalary = weekSal;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary should be a positive value...");
                }
                this.weekSalary = value;
            }
        }
        public decimal HoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Working hours should be a non-negative value!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        { 
            int workDays = 5;
            return weekSalary / (workHoursPerDay * workDays);
        }

        public override string ToString()
        {
            return string.Format(FirstName.PadRight(10) + " " + LastName.PadRight(15) + " " + WeekSalary.ToString().PadLeft(5) + HoursPerDay.ToString().PadLeft(3));
        }

    }
}
