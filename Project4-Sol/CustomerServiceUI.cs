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

    public partial class CustomerServiceUI : Form
    {
        private ReturnController returnItem;
        private TransactionDatabase TransactionDatabase;
        private Transaction returnTransaction = null;
        private int TransactionNumber;

        public CustomerServiceUI(TransactionDatabase tb, ReturnController rt)
        {
            TransactionDatabase = tb;
            returnItem = rt;
            InitializeComponent();
        }

        private void StartReturn_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionNumber = Convert.ToInt32(TransactionIDTextBox.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Error in input");
            }
            if (TransactionDatabase.transactions.ContainsKey(TransactionNumber))
            {
                returnTransaction = TransactionDatabase.transactions[TransactionNumber];
                if (returnTransaction.rebate == true)
                {
                    MessageBox.Show("You have already mailed in a rebate on that transaction, you cannot return an item from that transaction.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Product p in returnTransaction.products)
                    {
                        sb.Append(p.ToString() + "\n");
                    }
                    ItemList.Text = sb.ToString();

                    ReturnItemButton.Enabled = true;
                    EndTransaction.Enabled = true;
                    StartReturn.Enabled = false;
                }
            }
            else MessageBox.Show("Transaction Not Found");
        }

        private void ReturnItem_Click(object sender, EventArgs e)
        {
            ItemList.Text = returnItem.IReturnItem(returnTransaction, TransactionDatabase, TransactionNumber, (textBox3.Text.Trim()));
        }

        private void EndTransaction_Click(object sender, EventArgs e)
        {
            TransactionDatabase.transactions[TransactionNumber] = returnTransaction;
            MessageBox.Show("Transaction Complete");
            ItemList.Clear();
            StartReturn.Enabled = true;
            EndTransaction.Enabled = false;
            ReturnItemButton.Enabled = false;
        }
    }
}