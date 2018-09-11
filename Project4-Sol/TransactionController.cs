using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{

    public class TransactionController
    {
        /// <summary>
        /// the delegate implementation to add a Transaction to the Transaction Database Model
        /// </summary>
        /// <param name="nameOfCustomer">name of customer</param>
        /// <param name="monthOfPurchase">month of transaction</param>
        /// <param name="transnumber">transaction number</param>
        /// <param name="dateOfPurchase">date of transaction</param>
        /// <param name="tb">the model</param>
        /// <param name="items">the products in the transaction</param>
        public void MakeTransaction(string nameOfCustomer, string monthOfPurchase, int transnumber, int dateOfPurchase, TransactionDatabase tb, List<Product> items)
        {
            Transaction t = new BasicTransaction(monthOfPurchase, dateOfPurchase, nameOfCustomer, transnumber, items);
            tb.transactions.Add(transnumber, t);
        }

        /// <summary>
        /// the delegate to add an item to a list of products in a transaction
        /// </summary>
        /// <param name="list">the list of products</param>
        /// <param name="product">the item</param>
        /// <param name="cost">the price of the item</param>
        /// <returns></returns>
        public List<Product> AddItem(List<Product> list, string product, double cost)
        {
            Product item = new Product(product, cost);
            list.Add(item);
            return list;
        }

    }
}
