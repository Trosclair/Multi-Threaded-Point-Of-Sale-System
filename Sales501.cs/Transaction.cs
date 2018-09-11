using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// This class represents a single Transaction stored in the Transaction Database.  It contains all the
    /// information of a single Transaction, as well as a constructor and a method to print a receipt for
    /// the Transaction.  
    /// </summary>
    class Transaction
    {
        /// <summary>
        /// All the information stored under a Transaction: customer name, date and month of purchase, the
        /// Transaction Number ID, whether the Transaction has been rebated, and a list of Products within
        /// the Transaction. 
        /// </summary>
        public string name;
        public string month;
        public int transactionnumber;
        public int date;
        public bool rebate = false;
        public List<Product> products;
 
        /// <summary>
        /// Constructor for a new Transaction
        /// </summary>
        /// <param name="m">month of Transaction</param>
        /// <param name="d">date of Transaction</param>
        /// <param name="nameOfCustomer">name of customer</param>
        /// <param name="items">all Products in Transaction</param>
        /// <param name="number">the Transaction Number</param>
        public Transaction(string m, int d, string nameOfCustomer, List<Product> items, int number)
        {
            name = nameOfCustomer;
            month = m;
            date = d;
            rebate = false;
            products = items;
            transactionnumber = number;
        }

        /// <summary>
        /// This method uses the information stored in a Transaction to print a receipt for the user.  This
        /// receipt can also reflect returned items.
        /// </summary>
        /// <returns></returns>
        public string generateReceipt()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Customer: " + name + "\n");
            sb.Append("Date of purchase: " + month + " " + date + "\n");
            sb.Append("Transaction number: " + transactionnumber.ToString() + "\n");
            sb.Append("\n");
            sb.Append("Payments: " + "\n");
            double totalPrice = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].returned)
                {
                    sb.Append(products[i].name + ": RETURNED" + "\n");
                }
                else
                {
                    sb.Append(products[i].name + ": $" + products[i].price.ToString() + "\n");
                    totalPrice += products[i].price;
                }
            }
            sb.Append("\n");
            sb.Append("Total: $" + totalPrice.ToString() + "\n");
            return sb.ToString();
        }
    }
}
