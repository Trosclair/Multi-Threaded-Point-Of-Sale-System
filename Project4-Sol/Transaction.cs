using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public abstract class Transaction
    {
        public string name;
        public string month;
        public int transactionnumber;
        public int date;
        public bool rebate = false;
        public List<Product> products;     
     }
}
