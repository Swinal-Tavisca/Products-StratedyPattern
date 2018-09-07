using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class MainProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FOLLOWING(with proper casing) : ");
            Console.WriteLine("CarProduct");
            Console.WriteLine("AirProduct");
            Console.WriteLine("HotelProduct");
            Console.WriteLine();
            
            string product = Console.ReadLine();
            SingletonInstance.CreateInstance.log(product + " entered");
            Console.WriteLine();

            ProductFactory factory = new ConcreteProductFactory();
            Iproduct iproduct = factory.GetProduct(product);

            
            gettingtype obj = new gettingtype();
            ProductService serviceobj = new ProductService();

            Iproduct finalObject = obj.DetermineItemType(product);
            IFareStrategy fareItemType = obj.GetItemTypeForFare(finalObject);
            string dataStorage;
           
            int f = 0;
            do
            {
                Console.WriteLine("ENTER OPTIONS");
                Console.WriteLine("1. BOOK");
                Console.WriteLine("2. SAVE");
                Console.WriteLine("3. EXIT");
                int enter = Convert.ToInt32(Console.ReadLine());
               
                if (enter == 1)
                {
                    SingletonInstance.CreateInstance.log("USER WANTS TO BOOK");
                    Console.WriteLine("ENTER WHERE U WANT TO SAVE DATA(with proper casing)");
                    Console.WriteLine("FileStorage");
                    Console.WriteLine("SqlStorage");
                    dataStorage=Console.ReadLine();
                    SingletonInstance.CreateInstance.log("USER WANTS TO STORE DATA IN " + dataStorage);
                    IRepository finalstorage = obj.GetStorageType(dataStorage);
                    serviceobj.Book(finalObject, finalstorage, fareItemType.CalculateFare(finalObject.fare));
                }
                if (enter == 2)
                {
                    SingletonInstance.CreateInstance.log("USER WANTS TO SAVE");
                    Console.WriteLine("ENTER WHERE U WANT TO SAVE DATA(with proper casing)");
                    Console.WriteLine("FileStorage");
                    Console.WriteLine("SqlStorage");
                    dataStorage = Console.ReadLine();
                    SingletonInstance.CreateInstance.log("USER WANTS TO ENTER DATA IN " + dataStorage);
                    IRepository finalstorage = obj.GetStorageType(dataStorage);
                    serviceobj.Save(finalObject, finalstorage, fareItemType.CalculateFare(finalObject.fare));
                }
                if(enter==3)
                {
                    f = 1;
                    SingletonInstance.CreateInstance.log("USER WANTS TO EXIT");
                }

            } while (f == 0); 
            Console.ReadKey();
        }
    }
}
