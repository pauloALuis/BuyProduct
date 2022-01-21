using System;
using System.Collections.Generic;

namespace BuyProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProtuct = new List<Product>();

            Product product = new Product("0001", "PC - ", 10, 1000, IVAs.IvaNormal);
            Product product1 = new Product("0002", "PC -2 ", 11, 1200, IVAs.IvaNormal);
            Product product2 = new Product("0003", "PC -3 ", 12, 1300, IVAs.IvaReduzido);
            listProtuct.Add(product);
            listProtuct.Add(product1);
            listProtuct.Add(product2);
            listProtuct.Add(product);
            listProtuct.Add(product1);
            listProtuct.Add(product2);
            Console.WriteLine("Pro " + product);



            CarBuy carBuy = new CarBuy(listProtuct,DateTime.Now);

            carBuy.ListItem();

        }
    }
}
