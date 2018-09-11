using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    /// <summary>
    /// The RebateDatabase class functions as the storage mechanism for all Rebates in the program.
    /// </summary>
    public class RebateDatabase
    {
        public Dictionary<int, Rebate> rebates = new Dictionary<int, Rebate>();
    }

}
