using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp12
{
    class AirProduct:Iproduct
    {
        public string prodtype = "AirProduct";
        public string prodname = "Air";
        public bool isbooked = false;
        public int Fare = 30;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }

        public int fare { get { return Fare; } set { Fare = value; } }
    }
}
