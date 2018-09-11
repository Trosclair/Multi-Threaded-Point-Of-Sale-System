using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// This class represents a single Product within a Transaction or Rebate. 
    /// </summary>
    class Product
    {
        /// <summary>
        /// The name of the Product
        /// </summary>
        public string name;

        /// <summary>
        /// The price of the Product
        /// </summary>
        public double price;

        /// <summary>
        /// If the Product has been returned.
        /// </summary>
        public bool returned;

        /// <summary>
        /// Constructor for a new Product.  Returned is initially set to false
        /// </summary>
        /// <param name="title">name of Product</param>
        /// <param name="cost">Cost of Product</param>
        public Product(string title, double cost)
        {
            name = title;
            price = cost;
            returned = false;
        }

    }
}
