using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Sol
{
    
    public class ReturnController
    {
        public string IReturnItem(Transaction returnTransaction, TransactionDatabase TransactionDatabase, int TransactionNumber, string itemName)
        {
            for (int i = 0; i < returnTransaction.products.Count; i++)
            {
                if (returnTransaction.products[i].name.Equals(itemName))
                {
                    returnTransaction.products.Remove(returnTransaction.products[i]);
                    string s = ListBoxPopulator(returnTransaction);
                    TransactionDatabase.transactions.Remove(TransactionNumber);
                    if (TransactionDatabase.transactions.Count != 0)
                    {
                        TransactionDatabase.transactions.Add(TransactionNumber, returnTransaction);
                    }
                    MessageBox.Show("Return Successful");
                    return s;
                }
            }
            MessageBox.Show("Return Unsuccessful");
            return "";
        }
        private string ListBoxPopulator(Transaction returnTransaction)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product p in returnTransaction.products)
            {
                sb.Append(p.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
