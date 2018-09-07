using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ConcreteProductFactory:ProductFactory
    {
        public override Iproduct GetProduct(string product)
        {
            switch(product)
            {
                case "CarProduct":
                    return new CarProduct();
                case "AirProduct":
                    return new AirProduct();
                case "HotelProduct":
                    return new HotelProduct();
                default:
                    throw new ApplicationException();
            }
            
        }
    }
}
