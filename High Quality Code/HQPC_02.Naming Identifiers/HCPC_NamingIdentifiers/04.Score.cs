namespace HCPC_NamingIdentifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Score
    {
        private string name;
        private int points;

        public Score()
        {
        }

        public Score(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(this.name) || this.name.Length < 3)
                {
                    throw new ArgumentException("Invalid name input!");
                }

                this.name = value;
            }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}