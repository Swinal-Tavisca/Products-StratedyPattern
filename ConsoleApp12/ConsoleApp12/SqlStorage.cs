using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp12
{
    class SqlStorage:IRepository
    {
        public void Add(Iproduct product, int fare)
        {
            SqlConnection connectionobject = new SqlConnection();

            SingletonInstance.CreateInstance.log("DATABASE CONNECTION STABLISHED");
            connectionobject.ConnectionString = "Data Source=TAVDESK033;Initial Catalog=ProductDB;User ID=sa;Password=test123!@#";
            connectionobject.Open();
            string query = "insert into "+product.ProductType+" values(@name,@fare,@isbooked)";
            SqlCommand cmd = new SqlCommand(query, connectionobject);
            cmd.Parameters.Add(new SqlParameter("@name", product.ProductName));
            cmd.Parameters.Add(new SqlParameter("@fare", fare));
            cmd.Parameters.Add(new SqlParameter("@isbooked", product.IsBooked));
            SingletonInstance.CreateInstance.log("DATA INSERTED");

            cmd.ExecuteNonQuery();

            connectionobject.Close();
            SingletonInstance.CreateInstance.log("DATABASE CONNECTION CLOSED");
        }
    }
}
