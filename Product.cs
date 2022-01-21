using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyProduct
{ 
    /// <summary>
    /// Product
    /// </summary>
    class Product
    {

        public string Name { get; set; }

        public string CodProduct { get; set; }
        public int Unit { get; set; }
        private double _price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IVAs TypeIVA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codProduct"></param>
        /// <param name="name"></param>
        /// <param name="unit"></param>
        /// <param name="price"></param>
        /// <param name="typeIVA"></param>
        public Product(string codProduct, string name, int unit=1 , double price = 0.0, IVAs typeIVA= IVAs.IvaNormal)
        {
            CodProduct = codProduct;
            Unit = unit;
            _price = price;
            TypeIVA = typeIVA;
            Name = name;
        }


        /// <summary>
        ///  add the IVA of the product
        /// </summary>
        public double Price { get { return (_price * ((double)TypeIVA/100)) + _price;  }  }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString()+ "("+ CodProduct + ", " +  Unit + ","+ TypeIVA + "%, "+ Price + "€)";
        }
    }
}
