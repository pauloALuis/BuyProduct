using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyProduct
{
    /// <summary>
    /// Car Buy
    /// </summary>
    class CarBuy
    {
        List<Product> Car = new List<Product>();
        public DateTime DateBuy { get; set; }
        public double Total { get; set; }
      

        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <param name="dateBuy"></param>
        public CarBuy(List<Product> car, DateTime dateBuy )
        {
            Car = car;
            DateBuy = dateBuy;
        }


        /// <summary>
        /// Show list item product the car
        /// </summary>
        public void ShowListItemCar(){
            string product = "";
            double sum = 0;
            foreach (var item in Car)
            {
                sum += item.Price;
                product += item.CodProduct + "\t" + item.Name + "\t" + (int)item.TypeIVA + "%\t" + item.Price +"€\n";


            }
            Console.WriteLine(DateBuy +"\n Cod \t Name \t IVA \t Price \n" + product);
            Console.WriteLine("-----------------------------\nTotal €" + sum);

        }


        public CarBuy(List<Product> car, DateTime dateBuy, double total) : this(car, dateBuy)
        {
            Total = total;
        }

        public override string ToString()
        {
            string product = "";

            foreach (var item in Car)
            {
                
                product += item.CodProduct + "   " + item.Name + "   " + item.TypeIVA + "   " + item.Price + "\n";

            }
            return base.ToString() + "" +product + "" + DateBuy;
        }
    }
}
