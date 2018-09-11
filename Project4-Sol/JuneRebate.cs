using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    class JuneRebate : Rebate
    {
        private string monthOfMailing;
        private int dayOfMailing;
        private int transactionNumber;
        private double discount = .11;
        private int duedate = 15;
        private bool printed = false;

        public JuneRebate(string monthOfMailing, int dayOfMailing, int transactionNumber)
        {
            this.monthOfMailing = monthOfMailing;
            this.dayOfMailing = dayOfMailing;
            this.transactionNumber = transactionNumber;
        }
    }
}
