using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public class BasicTransaction : Transaction
    {
        public BasicTransaction(string m, int d, string nameOfCustomer,  int number, List<Product> items)
        {
            name = nameOfCustomer;
            month = m;
            date = d;
            rebate = false;
            products = items;
            transactionnumber = number;
        }
    }
}
