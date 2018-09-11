using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public delegate void MakeTransaction(string name, string month, int transnumber, int date, TransactionDatabase database, List<Product> items);    
}
