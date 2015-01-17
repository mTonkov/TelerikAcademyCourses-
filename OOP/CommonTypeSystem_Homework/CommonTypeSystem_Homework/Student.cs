
namespace CommonTypeSystem_Homework
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {   
        //fields
        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSecurityNumber;
        public long MobilePhone { get; private set; }
        public string PermanentAddress { get; private set; }
        public string EMail { get; private set; }
        public string Course { get; private set; }
        private Specialty Specialty;
        private Faculty Faculty;
        private University University;

        //constructors
        public Student()
        {
        }
        public Student(string fName, string mName, string lName, long ssn, string address, string mail, string course,
                                Specialty specialty, Faculty faculty, University uni, long? phone = null)
        {                                                                   // as in most registry forms, here phone is also optional
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SocialSecurityNumber = ssn;
            this.PermanentAddress = address;
            this.EMail = mail;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = uni;
            if (phone != null)
            {
                this.MobilePhone = (long)phone;
            }
        }

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.lastName = value;
            }
        }
        public long SocialSecurityNumber
        {
            get { return this.socialSecurityNumber; }
             set
            {
                if (value.ToString().Length != 9)
                {
                    throw new ArgumentException("SSN should be 9-digits long");
                }
                this.socialSecurityNumber = value;
            }
        }

        //overrides
        public override bool Equals(object obj)
        {
            Student st = obj as Student;
            if (st == null)
            {
                return false;
            }

            if ((this.FirstName != st.FirstName) || (this.MiddleName != st.MiddleName) || (this.LastName != st.LastName))
            {
                return false;
            }

            if (this.SocialSecurityNumber != st.SocialSecurityNumber)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendLine(this.FirstName);
            printInfo.AppendLine(this.MiddleName);
            printInfo.AppendLine(this.LastName);
            printInfo.AppendLine(this.SocialSecurityNumber.ToString());
            printInfo.AppendLine(this.Specialty.ToString());
            printInfo.AppendLine(this.Faculty.ToString());
            printInfo.AppendLine(this.University.ToString());
            if (this.MobilePhone != 0)
            {
                printInfo.AppendLine(this.MobilePhone.ToString());
            }
            return printInfo.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SocialSecurityNumber.GetHashCode();
        }

        public static bool operator ==(Student st1, Student st2)
        {
            if (st1.Equals(st2))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Student st1, Student st2)
        {
            if (st1.Equals(st2))
            {
                return false;
            }
            return true;
        }
        
        public object Clone()
        {
            return new Student(this.FirstName,
                               this.MiddleName,
                               this.LastName,
                               this.SocialSecurityNumber,
                               this.PermanentAddress,
                               this.EMail,
                               this.Course,
                               this.Specialty,
                               this.Faculty,
                               this.University,
                               this.MobilePhone);
        } //task 02
        
        public int CompareTo(Student other) // task 03
        {
            int result = this.FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = this.MiddleName.CompareTo(other.MiddleName);
                if (result != 0)
                {
                    return result;
                }
                else
                {
                    result = this.LastName.CompareTo(other.LastName);
                    if (result != 0)
                    {
                        return result;
                    }
                    else
                    {
                        result = this.SocialSecurityNumber.CompareTo(other.SocialSecurityNumber);
                    }
                }
            }
            return result;
        }
    }
}
