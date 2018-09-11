using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public class TransactionDatabase
    {
        /// <summary>
        /// The Dictionary holding all Transactions
        /// </summary>
        public Dictionary<int, Transaction> transactions = new Dictionary<int, Transaction>();

        /// <summary>
        /// Keeps track of the number of Transactions, as well as serves as each customers unique Transaction
        /// ID number when the customer wants to return and item or submit a rebate.
        /// </summary>
        public static int TransactionNumber = 1;
    }
}
