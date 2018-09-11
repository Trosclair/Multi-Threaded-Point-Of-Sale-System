using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Sol
{
    public class RebateController
    {
        public string generateRebateCheck(Transaction t)
        {
            if (t.rebate)
            {
                MessageBox.Show("Rebate already Printed");
                return null;
            }
            t.rebate = true;
            double total = 0;
            foreach (Product p in t.products) total += p.price;
            StringBuilder sb = new StringBuilder();
   
            sb.Append("Rebate checks for customer who have mailed in their rebate listed below: " + "\n" + "\n");
            /*sb.Append("Customer: " + t.name);
            sb.Append("Date of Purchase" + t.date + "\n");
            ///sb.Append("Date rebate was mailed:" +);
            /// sb.Append("\n");
            sb.Append("Payments: " +"\n");
            sb.Append()
            sb.Append("\n");
            sb.Append("Order Total: $" + Math.Round(total, 2).ToString() + "\n");*/
            sb.Append(ReceiptGenerator.generateReceipt(t));
            sb.Append("Money from Rebate Check: $" + Math.Round((total*.11), 2).ToString() + "\n" + "\n" + "\n" + "\n");
            return sb.ToString();
        }
    }
}
