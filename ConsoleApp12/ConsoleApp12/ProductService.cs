using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ProductService
    {
        public void Book(Iproduct product, IRepository storage, int fare)
        {
            product.IsBooked = true;
            storage.Add(product, fare);
            Console.WriteLine(product.ProductType + "Product Booked Successfully!!");
        }
        public void Save(Iproduct product, IRepository storage, int fare)
        {
            storage.Add(product, fare);
            Console.WriteLine(product.ProductType + "Product Saved Successfully!!");
        }
    }
}
