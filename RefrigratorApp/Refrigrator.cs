using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigratorApp
{
    class Refrigrator
    {
        public double maxWeight;

        public int noofItems;

        public double weightPerItems;

        public double itemsWeight;


        public double GetCurrentWeight()
        {
            itemsWeight = noofItems*weightPerItems;

            return itemsWeight;
        }

        public double GetRemainingWeight()
        {
            return maxWeight - GetCurrentWeight();

        }
    }
}
