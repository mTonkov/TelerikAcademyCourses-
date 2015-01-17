
namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name should contain of at least 3 letters");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Last name should contain of at least 4 letters");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format(FirstName + " " + LastName);
        }
    }
}
