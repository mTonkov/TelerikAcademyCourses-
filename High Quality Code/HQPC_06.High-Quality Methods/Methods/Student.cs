namespace Methods
{
    using System;

    public class Student : IAgeable
    {
        private string firstName;
        private string lastName;
        private string otherInfo;
        private DateTime birthDate;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input");
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

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input");
                }

                this.otherInfo = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public bool IsOlderThan(IAgeable other) // IAgeable brings loose coupling and greater abstraction
        {
            bool result = this.DateOfBirth < other.DateOfBirth;
            
            return result;
        }
    }
}
