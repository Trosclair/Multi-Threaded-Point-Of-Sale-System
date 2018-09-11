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
    public partial class CashierUI : Form
    {
        /// <summary>
        /// delegate for adding a transaction to the Model
        /// </summary>
        private MakeTransaction AddTransaction;

        /// <summary>
        /// delegate for adding another item to the Transaction
        /// </summary>
        private AddItem AddItem;

        /// <summary>
        /// the Transaction database passed to this form
        /// </summary>
        public TransactionDatabase database;
        
     
 
        ///temporary variables used to store data from user, before being passed to delegates
  
        string userName;

        int date;

        string month;

        string nameofproduct;

        double priceofproduct;

        List<Product> items = new List<Product>();

        /// <summary>
        /// Constructor for form, is passed the database and 2 delegates as fields
        /// </summary>
        /// <param name="model">the transaction database model passed to this form</param>
        /// <param name="mt">the delegate to add a transaction to the model</param>
        /// <param name="ai">the delegate to add an item to a transaction</param>
        public CashierUI(TransactionDatabase model, MakeTransaction mt, AddItem ai)
        {
            InitializeComponent();
            database = model;
            AddItem = ai;
            AddTransaction = mt;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            ///handler(sender, e);
            prompter.Text = "Enter customer name: ";
            prompter.Visible = true;
            confirmName.Visible = true;
            userInfo.Visible = true;
        }

        private void confirmMonth_Click(object sender, EventArgs e)
        {
            string testmonth = monthTextBox.Text;
            if (testmonth == "")
            {
                month = "June";
                monthTextBox.Text = "June";
                confirmDate.Visible = true;
                dateTextBox.Visible = true;
                prompter.Text = "Enter the day of purchase (simply click enter for the 14th)";
            }
            else if (testmonth.Trim().ToUpper() != "JANUARY" && testmonth.Trim().ToUpper() != "FEBRUARY" && testmonth.Trim().ToUpper() != "MARCH" && testmonth.Trim().ToUpper() != "APRIL" && testmonth.Trim().ToUpper() != "MAY" && testmonth.Trim().ToUpper() != "JUNE" && testmonth.Trim().ToUpper() != "JULY" && testmonth.Trim().ToUpper() != "AUGUST" && testmonth.Trim().ToUpper() != "SEPTEMBER" && testmonth.Trim().ToUpper() != "OCTOBER" && testmonth.Trim().ToUpper() != "NOVEMBER" && testmonth.Trim().ToUpper() != "DECEMBER")
            {
                MessageBox.Show("Please enter valid month for transaction.");
            }
            else
            {
                month = testmonth.Trim().ToUpper();
                confirmDate.Visible = true;
                dateTextBox.Visible = true;
                prompter.Text = "Enter the day of purchase (simply click enter for the 14th)";
            }
        }

        private void confirmName_Click(object sender, EventArgs e)
        {
            userName = userInfo.Text;
            prompter.Text = "Enter the month of transaction(simply click enter for June): ";
            confirmMonth.Visible = true;
            monthTextBox.Visible = true;
        }

        private void confirmDate_Click(object sender, EventArgs e)
        {
            int x;
            string testdate = dateTextBox.Text;
            if (testdate == "")
            {
                date = 14;
                dateTextBox.Text = "14";
                confirmProductName.Visible = true;
                productName.Visible = true;
                prompter.Text = "Enter the name of the product:";
            }
            else if (!Int32.TryParse(testdate, out x))
            {
                MessageBox.Show("Please enter a valid number for the date");
            }
            else
            {
                date = Convert.ToInt32(testdate);
                confirmProductName.Visible = true;
                productName.Visible = true;
                prompter.Text = "Enter the name of the product:";
            }
        }

        private void confirmProductName_Click(object sender, EventArgs e)
        {
            nameofproduct = productName.Text;
            confirmProductPrice.Visible = true;
            productPrice.Visible = true;
            prompter.Text = "Enter the price of the product: ";
        }

        private void confirmProductPrice_Click(object sender, EventArgs e)
        {
            double x;
            if(!Double.TryParse(productPrice.Text, out x))
            {
                MessageBox.Show("Please enter a valid number for the price.");
            }
            else
            {
                priceofproduct = Convert.ToDouble(productPrice.Text);
                prompter.Text = "Click complete transaction, or enter the name of another product";
                finished.Visible = true;
                items = AddItem(items, nameofproduct, priceofproduct);
            }
        }

        private void finished_Click(object sender, EventArgs e)
        {
            AddTransaction(userName, month, TransactionDatabase.TransactionNumber, date, database, items);
            MessageBox.Show(ReceiptGenerator.generateReceipt(database.transactions[TransactionDatabase.TransactionNumber]));
            TransactionDatabase.TransactionNumber += 1;
            confirmDate.Visible = false;
            confirmMonth.Visible = false;
            confirmName.Visible = false;
            confirmProductName.Visible = false;
            confirmProductPrice.Visible = false;
            userInfo.Visible = false;
            monthTextBox.Visible = false;
            dateTextBox.Visible = false;
            productName.Visible = false;
            productPrice.Visible = false;
            finished.Visible = false;
            prompter.Visible = false;
            items = new List<Product>();
            userInfo.Text = "";
            monthTextBox.Text = "";
            dateTextBox.Text = "";
            productName.Text = "";
            productPrice.Text = "";
        }
    }
}
