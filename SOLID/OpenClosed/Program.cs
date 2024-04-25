// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");

//Bir nesne .....GELİŞİME..... açık .....DEĞİŞİME...... kapalı
Customer customer = new Customer { Card = new Premium(), Name = "Türkay" };
OrderManagement orderManagement = new OrderManagement() { Customer = customer };
var discounted = orderManagement.GetDiscountedPrice(1000);
Console.WriteLine(discounted);