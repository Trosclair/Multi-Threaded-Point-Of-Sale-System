using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// This class represents a single Rebate stored in the Rebate Database.  It contains all the
    /// information of a single Rebate, as well as a constructor.
    /// the Transaction.  
    /// </summary>
    class Rebate
    {
        /// <summary>
        /// All information to be stored in a single Rebate: the month and date it was mailed, the 
        /// products in the Transaction, and a boolean indicating if it has already been printed out
        /// with a rebate check.  
        /// </summary>
        public string month;
        public int date;
        public bool printed;
        public List<Product> products;

        /// <summary>
        /// The 11% discount a rebate offers
        /// </summary>
        ///public const double discount = .89;

        /// <summary>
        /// Constructor for a new Rebate.  Printed is initially set to false.
        /// </summary>
        /// <param name="monthOfMailing">month rebate is mailed</param>
        /// <param name="dayOfMailing">day rebate is mailed</param>
        /// <param name="itemsInRebate">items in Transaction</param>
        public Rebate(string monthOfMailing, int dayOfMailing, List<Product> itemsInRebate)
        {
            month = monthOfMailing;
            date = dayOfMailing;
            products = itemsInRebate;
            printed = false;
        }

    }
}
