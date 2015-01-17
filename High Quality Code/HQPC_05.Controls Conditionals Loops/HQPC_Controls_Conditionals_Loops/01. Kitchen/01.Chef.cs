namespace HQPC_Controls_Conditionals_Loops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            return new Bowl(); 
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.isPeeled = true;
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.isCut = true;
        }
    }
}