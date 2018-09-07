using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class gettingtype
    {
        public Iproduct DetermineItemType(string itemType)
        {
           // singleton.Instance.AddToLogFile("returning the instance dynamically.");

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == itemType);
            return (Iproduct)Activator.CreateInstance(productType);

        }

        public IRepository GetStorageType(string storageType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == storageType);
            return (IRepository)Activator.CreateInstance(productType);
        }

        public IFareStrategy GetItemTypeForFare(Iproduct product)
        {
            Type t = product.GetType();
            if (t == typeof(CarProduct))
            {
                return new CarStrategy();
            }
            if(t==typeof(HotelProduct))
            {
                return new HotelStrategy();
            }
            if(t==typeof(AirProduct))
            {
                return new AirStrategy();
            }
            return new CarStrategy();
        }
    }
}
