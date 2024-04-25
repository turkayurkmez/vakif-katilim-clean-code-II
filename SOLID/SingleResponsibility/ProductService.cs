using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateProduct(string productName, decimal price)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=sampleDb;Integrated Security=True";
            var commandText = "Insert into Products (Name,Price) values (@name,@price)";
            Dictionary<string, object> paremeterList = new Dictionary<string, object>();
            paremeterList.Add("@name", productName);
            paremeterList.Add("@price", price);

            SqlHelper sqlHelper = new SqlHelper (connectionString);
           var affectedRows =  sqlHelper.ExecuteNonQuery (commandText, paremeterList);


           

            return affectedRows;

        }
    }
}
