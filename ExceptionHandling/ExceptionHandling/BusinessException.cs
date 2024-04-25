using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class BusinessException<T> : Exception
    {
        public string Reason { get; set; }
        public string Layer { get; set; }
        public T? Model { get; set; }

        public BusinessException(string? message):base(message)
        {
                
        }

    }

    public class ProductServiceException : BusinessException<Product>
    {
        public ProductServiceException() : base("ProductService sınıfından kaynaklı bir hata oluştu")
        {
        }
        public ProductServiceException(string? message):base(message)
        {
                
        }
        public ProductServiceException(string reason,string? message) : base(message)
        {
            Reason = reason;
            Layer = "Application";
        }
    }


}
