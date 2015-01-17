using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HQPC_Controls_Conditionals_Loops
{
    public class Bowl
    { 
        private List<Vegetable> vegetables;

        public Bowl()
        {
        }

        public List<Vegetable> Vegetables
        {
            get 
            {
                return new List<Vegetable>(vegetables); 
            }

            private set
            {
                this.vegetables = value;
            }
        }

        public void Add(Vegetable vegetable)
        {
            vegetables.Add(vegetable);
        }
    }
}