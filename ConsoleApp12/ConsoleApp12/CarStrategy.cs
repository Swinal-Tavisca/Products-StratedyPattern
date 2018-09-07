using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class CarStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            SingletonInstance.CreateInstance.log("CALCULATE CAR FARE");
            totalFare = totalFare + 20;
            return (totalFare);
        }
    }
}
