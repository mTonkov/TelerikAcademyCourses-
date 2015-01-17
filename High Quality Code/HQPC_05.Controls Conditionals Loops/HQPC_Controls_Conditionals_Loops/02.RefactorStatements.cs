namespace HQPC_Controls_Conditionals_Loops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class RefactorStatements
    {
        public void Cooking()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.isPeeled && potato.isCut)
                {
                    Chef masterChef = new Chef();
                    masterChef.Cook();
                }
            }
        }

        public void VisitingCell()
        {
            const int MIN_X = 0;
            const int MIN_Y = 0;
            const int MAX_X = 1;
            const int MAX_Y = 1;

            int x = 0;
            int y = 1;

            bool shoudVisitCell = false;
            bool isYInRange = MIN_Y <= y && MAX_Y >= y;
            bool isXInRange = x >= MIN_X && x <= MAX_X;

            if (isXInRange && isYInRange && shoudVisitCell)
            {
                this.VisitCell();
            }
        }

        public void VisitCell() 
        {
        }
    }
}