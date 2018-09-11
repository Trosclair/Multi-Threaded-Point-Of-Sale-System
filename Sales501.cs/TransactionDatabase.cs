using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// The TransactionDatabase class functions as the storage mechanism for all Transactions in the program,
    /// as well as the holder for the 2 methods that involve transactions.  This class creates and stores
    /// Transactions, and contains the methods for the user to submit a transaction or return an item.
    /// </summary>
    class TransactionDatabase
    {
        /// <summary>
        /// The Dictionary holding all Transactions
        /// </summary>
        public static Dictionary<int, Transaction> transactions = new Dictionary<int, Transaction>();

        /// <summary>
        /// Keeps track of the number of Transactions, as well as serves as each customers unique Transaction
        /// ID number when the customer wants to return and item or submit a rebate.
        /// </summary>
        public static int TransactionNumber = 1;

        /// <summary>
        /// This method is called when the user wants to enter a transaction into the system.  It asks for their
        /// name, date and month of purchase, and allows the user to enter as many items as they would like.  The
        /// system stores each of these items as a Product and adds it to the Transaction.  After the user is 
        /// finished entering items, their Transaction is stored in the system (with the Transaction number stored
        /// as the unique key in the Dictionary for the user) and a receipt is generated from the generateReceipt 
        /// method in Transaction.cs for the user.
        /// </summary>
        /// <returns>The customers receipt to be printed out</returns>
        public string makeTransaction()
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
            while(!validDate)
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
            Product item = new Product(product, price);
            List<Product> products = new List<Product>();
            products.Add(item);
            while (true)
            {
                Console.WriteLine("Would you like to add another item? (yes/no): ");
                if (Console.ReadLine() == "yes")
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
                    Product item2 = new Product(product2, price2);
                    products.Add(item2);
                }
                else
                {
                    Transaction t = new Transaction(month, date, name, products, TransactionNumber);
                    Console.WriteLine();
                    Console.WriteLine("Receipt below: ");
                    Console.WriteLine();
                    transactions.Add(TransactionNumber, t);
                    TransactionNumber++;
                    return (t.generateReceipt());
                }
            }
        }

        /// <summary>
        /// This method is called when the user selects to return an item.  The user can pull their Transaction
        /// from the database by entering their Transaction Number, and then they are prompted to select an item
        /// or multiple items to return.  After the user is finished, a new receipt is generated for them reflecting
        /// the items they have returned.  
        /// </summary>
        public void returnItem()
        {
            Console.WriteLine("Enter transaction number: ");
            int num = Convert.ToInt32(Console.ReadLine().Trim());
            if (transactions.ContainsKey(num))
            {
                Transaction t = transactions[num];
                if (t.rebate == true)
                {
                    Console.WriteLine("You have already mailed in a rebate on that transaction, you cannot return an item from that transaction.");
                    Console.WriteLine();
                }
                else
                {
                    bool doneReturning = false;
                    while(!doneReturning)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Select a product to return from your purchase (type name of item): ");
                        for (int i = 1; i < t.products.Count + 1; i++)
                        {
                            Console.WriteLine(t.products[i - 1].name + ": $" + t.products[i - 1].price);
                        }
                        string item = Console.ReadLine().Trim();
                        foreach (Product p in t.products)
                        {
                            if (p.name == item)
                            {
                                p.returned = true;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to return another item? (yes/no): ");
                        if (Console.ReadLine().Trim().ToUpper() == "NO")
                        {
                            doneReturning = true;
                        }
                        Console.WriteLine();
                    }
                    



                    Console.WriteLine("Your new receipt reflecting the item you returned will be printed below: ");
                    Console.WriteLine();
                    Console.WriteLine(t.generateReceipt());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid transaction, please check that the information you entered is correct.");
                Console.WriteLine();
            }
        }
    }
}
