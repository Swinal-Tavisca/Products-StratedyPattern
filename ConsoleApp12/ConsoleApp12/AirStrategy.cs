using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class AirStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            SingletonInstance.CreateInstance.log("CALCULATING FARE FOR AIR");
            totalFare = totalFare + 80;
            return (totalFare);
        }
    }
}
