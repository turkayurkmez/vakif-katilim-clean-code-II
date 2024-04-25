using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductService
    {
        public void AddNewProduct(Product product)
        {
            //if (product is null)
            //{
            //    throw new ArgumentNullException("olmaz böyle argüman!");
            //}
            ArgumentNullException.ThrowIfNull(product,nameof(product));
            checkPrice(product);
            checkName(product);

            //db'ye kaydedemediyse:
            throw new ProductServiceException(reason: "DB bağlantısı kurulamadı", message: "Lütfen bağlantı adresini kontrol edin!");

        }

        private void checkName(Product product)
        {
            if (product.Name.Length > 10) throw new ArgumentException($"{product.Name} en fazla 10 karakter uzunluğunda olmalı");
        }

        private void checkPrice(Product product)
        {
            if (product.Price <0)
            {
                ArgumentOutOfRangeException.ThrowIfNegative(product.Price, "Price");

            }
        }
    }
}
