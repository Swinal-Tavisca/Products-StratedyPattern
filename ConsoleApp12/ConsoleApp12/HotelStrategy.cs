using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class HotelStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            SingletonInstance.CreateInstance.log("CALCULATE HOTEL FARE");
            totalFare = totalFare + 50;
            return (totalFare);
        }
    }
}
