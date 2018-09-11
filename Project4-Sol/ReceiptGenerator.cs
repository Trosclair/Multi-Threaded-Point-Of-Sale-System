using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public static class ReceiptGenerator
    {
        /// <summary>
        /// used to print receipts for transactions
        /// </summary>
        /// <param name="t">the transaction to print a receipt for</param>
        /// <returns></returns>
        public static string generateReceipt(Transaction t)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Customer: " + t.name + "\n");
            sb.Append("Date of purchase: " + t.month + " " + t.date + "\n");
            sb.Append("Transaction number: " + t.transactionnumber.ToString() + "\n");
            sb.Append("\n");
            sb.Append("Payments: " + "\n");
            double totalPrice = 0;
            for (int i = 0; i < t.products.Count; i++)
            {
                if (t.products[i].returned)
                {
                    sb.Append(t.products[i].name + ": RETURNED" + "\n");
                }
                else
                {
                    sb.Append(t.products[i].name + ": $" + t.products[i].price.ToString() + "\n");
                    totalPrice += t.products[i].price;
                }
            }
            sb.Append("\n");
            sb.Append("Total: $" + totalPrice.ToString() + "\n");
            return sb.ToString();
        }
    }
}
