using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface Iproduct
    {
        string ProductType { get; set; }
        string ProductName { get; set; }
        bool IsBooked { get; set; }

        int fare { get; set; }
        

    }
}
