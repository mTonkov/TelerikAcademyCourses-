
namespace School
{
    using System;
    public abstract class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length<2)
                {
                    throw new ArgumentNullException("You have not entered a valid name for person!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
