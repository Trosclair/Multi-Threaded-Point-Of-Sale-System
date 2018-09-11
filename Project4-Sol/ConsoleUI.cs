using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Sol
{
    public class ConsoleUI
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
        /// The database holding all Transactions in the program
        /// </summary>
        public static TransactionDatabase TDB;

        public ConsoleUI(TransactionDatabase transactionModel, MakeTransaction mt, AddItem ai)
        {
            TDB = transactionModel;
            AddItem = ai;
            AddTransaction = mt;
        }

        /// <summary>
        /// The list of products the user wants to buy.
        /// </summary>
        List<Product> products = new List<Product>();

        public void getProductInfo()
        {
            string enterNew = "";
            Console.WriteLine("Press enter to enter a new transaction");
            enterNew = Console.ReadLine();
            while(enterNew=="")
            {
                Console.WriteLine("Enter customer name: ");
                string name = Console.ReadLine();
                bool validMonth = false;
                string month = "";
                while (validMonth == false)
                {
                    Console.WriteLine("Month of purchase(simply press enter for June): ");
                    month = Console.ReadLine();
                    if (month == "")
                    {
                        validMonth = true;
                        month = "June";
                    }
                    else if (month.Trim().ToUpper() != "JANUARY" && month.Trim().ToUpper() != "FEBRUARY" && month.Trim().ToUpper() != "MARCH" && month.Trim().ToUpper() != "APRIL" && month.Trim().ToUpper() != "MAY" && month.Trim().ToUpper() != "JUNE" && month.Trim().ToUpper() != "JULY" && month.Trim().ToUpper() != "AUGUST" && month.Trim().ToUpper() != "SEPTEMBER" && month.Trim().ToUpper() != "OCTOBER" && month.Trim().ToUpper() != "NOVEMBER" && month.Trim().ToUpper() != "DECEMBER")
                    {
                        Console.WriteLine("Please enter valid month for transaction.");
                        Console.WriteLine();
                    }
                    else
                    {
                        validMonth = true;
                    }
                }
                int date = 14;
                bool validDate = false;
                int x;
                while (!validDate)
                {
                    Console.WriteLine("Day of purchase(simply press enter for the 14th): ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        date = 14;
                        validDate = true;
                    }
                    else if (!Int32.TryParse(input, out x))
                    {
                        Console.WriteLine("Please enter a valid number for the date");
                    }
                    else
                    {
                        date = Convert.ToInt32(input);
                        validDate = true;
                    }
                }
                Console.WriteLine("Enter the product name: ");
                string product = Console.ReadLine();
                bool validPrice = false;
                double z;
                double price = 0;
                while (!validPrice)
                {
                    Console.WriteLine("Enter price of product: ");
                    string priceInput = Console.ReadLine();
                    if (Double.TryParse(priceInput, out z))
                    {
                        price = Math.Round(Convert.ToDouble(priceInput), 2);
                        validPrice = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid price.");
                    }
                }
                products = AddItem(products, product, price);
                
                string response = "yes";
                while (response.Equals("yes"))
                {
                    Console.WriteLine("Would you like to add another item? (yes/no): ");
                    response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("Enter the product name: ");
                        string product2 = Console.ReadLine();
                        bool validPrice2 = false;

                        double price2 = 0;
                        while (!validPrice2)
                        {
                            Console.WriteLine("Enter price of product: ");
                            string priceInput = Console.ReadLine();
                            if (Double.TryParse(priceInput, out z))
                            {
                                price2 = Math.Round(Convert.ToDouble(priceInput), 2);
                                validPrice2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid price.");
                            }
                        }
                        products = AddItem(products, product2, price2);
                    }
                }
                AddTransaction(name, month, TransactionDatabase.TransactionNumber, date, TDB, products);
                Console.WriteLine(ReceiptGenerator.generateReceipt(TDB.transactions[TransactionDatabase.TransactionNumber]));
                TransactionDatabase.TransactionNumber += 1;
                products = new List<Product>();
                Console.WriteLine("Press enter to enter a new transaction");
                enterNew = Console.ReadLine();
            }
            

        }
    }
}
