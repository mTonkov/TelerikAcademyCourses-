using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HQPC_Controls_Conditionals_Loops
{
    public abstract class Vegetable
    {
        private bool peeled;
        private bool cut;

        public Vegetable()
        {
            this.peeled = false;
            this.cut = false;
        }

        public bool isPeeled
        {
            get { return this.peeled; }
            set { this.peeled = value; }
        }

        public bool isCut
        {
            get { return this.cut; }
            set { this.cut = value; }
        }        
    }
}