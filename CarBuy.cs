using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyProduct
{
    class CarBuy
    {
        List<Product> Car = new List<Product>();
        public DateTime DateBuy { get; set; }
        public double Total { get; set; }

        public CarBuy(List<Product> car, DateTime dateBuy)
        {
            Car = car;
            DateBuy = dateBuy;
        }


        public void ListItem (){
            string product = "";
            double sum = 0;
            foreach (var item in Car)
            {
                sum += item.Price;
                product += item.CodProduct + "   " + item.Name + "   " + item.TypeIVA + "   " + item.Price +"\n";


            }
            Console.WriteLine("Cod     Name     IVA   Price \n" + product);
            Console.WriteLine("Total € \n" + sum);

        }


    }
}
