using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp12
{
    class FileStorage : IRepository
    {
        public void Add(Iproduct product, int fare)
        {
            File.AppendAllText("C:/save.txt","PRODUCT NAME : "+product.ProductName + "    ");
            File.AppendAllText("C:/save.txt", "PRODUCT TYPE : " + product.ProductType + "    ");
            File.AppendAllText("C:/save.txt", "IsBooked : " + product.IsBooked + "    ");
            File.AppendAllText("C:/save.txt", "FARE : " + product.fare + "    ");
        }
    }
}
