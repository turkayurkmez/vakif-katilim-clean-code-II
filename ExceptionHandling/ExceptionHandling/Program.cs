// See https://aka.ms/new-console-template for more information
using ExceptionHandling;

Console.WriteLine("Hello, World!");
Product product = new Product { Id = 1, Price = 15, Name = "abc" };
ProductService productService = new ProductService();
productService.AddNewProduct(product);
