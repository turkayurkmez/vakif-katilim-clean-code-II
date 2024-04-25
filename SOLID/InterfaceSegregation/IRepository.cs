using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();

     

    }

    public interface ISearchableWithName<T>
    {
        IEnumerable<T> SearchByName(string name);
    }

    public class Product
    {

    }

    public class ProductRepository : IRepository<Product>, ISearchableWithName<Product>
    {
        public Product Get(int id)
        {
            return new Product();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Order
    {

    }

    public class OrderRepository : IRepository<Order>
    {
        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

     
    }
}
