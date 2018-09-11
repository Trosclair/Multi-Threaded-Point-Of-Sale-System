using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    /// <summary>
    /// This class represents a single Rebate stored in the Rebate Database.  It contains all the
    /// information of a single Rebate, as well as a constructor.
    /// the Transaction.  
    /// </summary>
    public abstract class Rebate
    {
        /// <summary>
        /// All information to be stored in a single Rebate: the month and date it was mailed, the 
        /// products in the Transaction, and a boolean indicating if it has already been printed out
        /// with a rebate check.  
        /// </summary>
        private double discount;
        private int duedate;
        private bool printed;
        private int transactionNumber;
    }
}