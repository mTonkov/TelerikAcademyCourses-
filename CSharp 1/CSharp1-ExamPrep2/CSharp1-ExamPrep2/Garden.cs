using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            //inputs
            uint tomatoSeeds = uint.Parse(Console.ReadLine());
            uint tomatoArea = uint.Parse(Console.ReadLine());
            uint cucumberSeeds = uint.Parse(Console.ReadLine());
            uint cucumberArea = uint.Parse(Console.ReadLine());
            uint potatoSeeds = uint.Parse(Console.ReadLine());
            uint potatoArea = uint.Parse(Console.ReadLine());
            uint carrotSeeds = uint.Parse(Console.ReadLine());
            uint carrotArea = uint.Parse(Console.ReadLine());
            uint cabbageSeeds = uint.Parse(Console.ReadLine());
            uint cabbageArea = uint.Parse(Console.ReadLine());
            uint beansSeeds = uint.Parse(Console.ReadLine());

            uint totalArea = 250;

            //solution
            decimal tomatoCosts = tomatoSeeds * 0.5m;
            decimal cucumberCosts = cucumberSeeds * 0.4m;
            decimal potatoCosts = potatoSeeds * 0.25m;
            decimal carrotCosts = carrotSeeds * 0.6m;
            decimal cabbageCosts = cabbageSeeds * 0.3m;
            decimal beansCosts = beansSeeds * 0.4m;

            decimal totalCosts = tomatoCosts + cucumberCosts + potatoCosts + carrotCosts + cabbageCosts + beansCosts;
            uint usedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

            //output1  
            Console.WriteLine("Total costs: {0:F2}", totalCosts);

            if (totalArea>usedArea)
            {
                Console.WriteLine("Beans area: {0}", totalArea-usedArea);
            }
            else if (totalArea==usedArea)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }

        }
    }
}
