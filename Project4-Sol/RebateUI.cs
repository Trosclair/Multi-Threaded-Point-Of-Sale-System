using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Sol
{
    public partial class RebateUI : Form
    {
        private int day;
        private int transID;
        private string month;
        private RebateDatabase rd;
        private RebateController rc;
        private TransactionDatabase tb;

        public void beginForm()
        {
            EnterTransactionNumber.Visible = true;
        }
        public RebateUI(RebateDatabase rb, RebateController rc, TransactionDatabase tb)
        {
            rd = rb;
            this.rc = rc;
            this.tb = tb;
            InitializeComponent();
        }

        private void EnterTransactionNumber_Click(object sender, EventArgs e)
        {
            prompter.Text = "Enter the transaction number: ";
            prompter.Visible = true;
            confirmTrans.Visible = true;
            transInfo.Visible = true;
        }

        private void confirmMonth_Click(object sender, EventArgs e)
        {
            string testmonth = monthInfo.Text;
            if (testmonth.Equals(""))
            {
                month = "June";
                monthInfo.Text = "June";
                confirmDay.Visible = true;
                dayInfo.Visible = true;
                prompter.Text = "Enter the day the rebate is being mailed (simply click enter for the 14th)";
            }
            else if (testmonth.Trim().ToUpper() != "JANUARY" && testmonth.Trim().ToUpper() != "FEBRUARY" && testmonth.Trim().ToUpper() != "MARCH" && testmonth.Trim().ToUpper() != "APRIL" && testmonth.Trim().ToUpper() != "MAY" && testmonth.Trim().ToUpper() != "JUNE" && testmonth.Trim().ToUpper() != "JULY" && testmonth.Trim().ToUpper() != "AUGUST" && testmonth.Trim().ToUpper() != "SEPTEMBER" && testmonth.Trim().ToUpper() != "OCTOBER" && testmonth.Trim().ToUpper() != "NOVEMBER" && testmonth.Trim().ToUpper() != "DECEMBER")
            {
                MessageBox.Show("Please enter valid month for transaction.");
            }
            else
            {
                month = testmonth.Trim().ToUpper();
                confirmDay.Visible = true;
                dayInfo.Visible = true;
                prompter.Text = "Enter the day the rebate is being mailed (simply click enter for the 14th)";
            }
        }

        private void confirmTrans_Click(object sender, EventArgs e)
        {
            transID = Convert.ToInt32(transInfo.Text);
            prompter.Text = "Enter the month the rebate is being mailed (simply click enter for June): ";
            confirmMonth.Visible = true;
            monthInfo.Visible = true;
        }

        private void confirmDay_Click(object sender, EventArgs e)
        {
            int x;
            string testdate = dayInfo.Text;
            if (testdate == "")
            {
                day = 14;
                dayInfo.Text = "14";
                generateButton.Visible = true;                
                prompter.Text = "Press enter to generate rebate check:";
            }
            else if (!Int32.TryParse(testdate, out x))
            {
                MessageBox.Show("Please enter a valid number for the date");
            }
            else
            {
                day = Convert.ToInt32(testdate);
                generateButton.Visible = true;
                prompter.Text = "Press enter to generate rebate check:";
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Transaction rebateTransaction = null;
            tb.transactions.TryGetValue(transID, out rebateTransaction);
            string newRebate = rc.generateRebateCheck(rebateTransaction);
            rebateTransaction.rebate = true;
            tb.transactions.Remove(transID);
            tb.transactions.Add(transID, rebateTransaction); 
            if (month.Equals("June"))
            {
                MessageBox.Show(newRebate);
                rd.rebates.Add(rebateTransaction.transactionnumber, new JuneRebate(month, day, rebateTransaction.transactionnumber));
            }
            generateButton.Visible = false;
            confirmDay.Visible = false;
            confirmMonth.Visible = false;
            confirmTrans.Visible = false;
            dayInfo.Visible = false;
            monthInfo.Visible = false;
            transInfo.Visible = false;
            prompter.Visible = false;
            transInfo.Clear();
            monthInfo.Clear();
            dayInfo.Clear();
            return;
        }
    }
}
