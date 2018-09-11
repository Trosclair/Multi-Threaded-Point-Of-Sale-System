using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Sol
{
    public delegate void InputHandler(object sender, EventArgs e);
    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///models constructed here
            TransactionDatabase tb = new TransactionDatabase();
            RebateDatabase rb = new RebateDatabase();

            ///Controllers constructed here
            TransactionController mt = new TransactionController();
            ReturnController rt = new ReturnController();
            RebateController rc = new RebateController();

            ///views and threads constructed here
            ConsoleUI console = new ConsoleUI(tb, mt.MakeTransaction, mt.AddItem);
            new Thread(ConsoleThreader).Start(console);

            RebateUI RebateForm = new RebateUI(rb, rc, tb);
            new Thread(RebateFormStartFunctionThatStartsTheRebateForm).Start(RebateForm);

            CashierUI CashierForm = new CashierUI(tb, mt.MakeTransaction, mt.AddItem);
            new Thread(CashierFormStartingFunctionThatStartsTheCashierForm).Start(CashierForm);

            /// Declares a Customer Service Form, and passes it to a thread which runs the application
            CustomerServiceUI CSForm = new CustomerServiceUI(tb, rt);
            new Thread(CustomerServiceFormStartingfunctionThatStartsTheCustomerServiceForm).Start(CSForm);

            /// Populate some transactions
            /// side node: CashierUI/Console won't work with these... only rebate/Service desk.
            /*
            List<Product> p = new List<Product>();
            p.Add(new Product("Melk", 1.23));
            p.Add(new Product("Not Melk", 2.69));
            tb.transactions.Add(1, new BasicTransaction("June", 14, "Customer 1", 1, p));

            p = new List<Product>();
            p.Add(new Product("A brand new pony", 1.24));
            p.Add(new Product("Glue making machine", 6.54));
            tb.transactions.Add(2, new BasicTransaction("June", 14, "Customer 2", 2, p));
            */
        }

        static void ConsoleThreader(Object ob)
        {
            ((ConsoleUI)ob).getProductInfo();
        }

        static void RebateFormStartFunctionThatStartsTheRebateForm(Object ob) 
        {
            Application.Run((Form)ob);
        }

        static void CustomerServiceFormStartingfunctionThatStartsTheCustomerServiceForm(Object ob)
        {
            Application.Run((Form)ob);
        }

        static void CashierFormStartingFunctionThatStartsTheCashierForm(Object ob)
        {
            Application.Run((Form)ob);
        }
    }
}
