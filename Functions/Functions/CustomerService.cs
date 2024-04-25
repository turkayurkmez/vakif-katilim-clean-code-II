using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        //public string Street { get; set; }
        //public string City { get; set; }
        //public string Country { get; set; }

        public Adddress Adddress { get; set; }
        public decimal Budget { get; set; }
        public Customer(string street, string city, string country)
        {
            Adddress = new Adddress (street, city, country);    
        }
    }


    public record Adddress(string Street, string City, string Country);
    public class CustomerService
    {
        public void CreateCustomer(Customer customer)
        {
            //customer, db'ye kaydedildi.   
        }
    }
}
