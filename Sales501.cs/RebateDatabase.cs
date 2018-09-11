using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// The RebateDatabase class functions as the storage mechanism for all Rebates in the program,
    /// as well as the holder for the 2 methods that involve Rebates.  This class creates and stores
    /// Rebates, and contains the methods for the user to mail in a Rebate or generate the final 
    /// Rebate Check.  
    /// </summary>
    class RebateDatabase
    {
        /// <summary>
        /// The Dictionary holding all Rebates
        /// </summary>
        public static Dictionary<int, Rebate> rebates = new Dictionary<int, Rebate>();

        /// <summary>
        /// The 11% discount the user receives for a rebate
        /// </summary>
        public const double discount = .89;

        /// <summary>
        /// The final date for mailing in rebates
        /// </summary>
        public const int DUEDATEOFREBATE = 15;

        /// <summary>
        /// This method allows the user to mail in a rebate by entering their unique Transaction Number
        /// and the current date they are mailing in this rebate.  If the transaction is in the system,
        /// the user has not already mailed in that rebate, and the user is mailing the rebate within the
        /// proper timespan, then that Transaction is added to the Rebate Database as a new Rebate to be
        /// generated with the Rebate Check. 
        /// </summary>
        public void mailInRebate()
        {
            Console.WriteLine("Enter transaction number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(rebates.ContainsKey(num))
            {
                Console.WriteLine("A rebate has already been mailed in for that transaction.");
                Console.WriteLine("\n");
            }
            else
            {
                bool validMonth = false;
                string month = "";
                while (validMonth == false)
                {
                    Console.WriteLine("Enter month rebate is being mailed(simply press enter for July): ");
                    month = Console.ReadLine();
                    if (month == "")
                    {
                        validMonth = true;
                        month = "July";
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
                bool validDate = false;
                int x;
                int date = 15;
                while (!validDate)
                {
                    Console.WriteLine("Enter day rebate is being mailed(simply press enter for 14th): ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        date = 15;
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
                if (TransactionDatabase.transactions.ContainsKey(num))
                {
                    if (TransactionDatabase.transactions[num].month.Trim().ToUpper() != "JUNE")
                    {
                        Console.WriteLine("We are sorry, but our 11% rebate only applies to transactions made in June.");
                        Console.WriteLine();
                    }
                    else
                    {
                        if ((month.Trim().ToUpper() == "JUNE" && date >= TransactionDatabase.transactions[num].date) || (month.Trim().ToUpper() == "JULY" && date <= DUEDATEOFREBATE))
                        {
                            Rebate r = new Rebate(month, date, TransactionDatabase.transactions[num].products);
                            rebates.Add(num, r);
                            TransactionDatabase.transactions[num].rebate = true;
                            Console.WriteLine();
                            Console.WriteLine("Your rebate has been mailed!  Your new receipt reflecting your rebate will be printed when the rebate check is generated.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("We are sorry, but a rebate must be mailed between the date of transaction and the due date for rebates (July 15).");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid transaction, please check that the information you entered is correct.");
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// This method prints out all rebates that have been mailed, reflecting their discounted prices.  These
        /// rebates are then marked as completed so that they wont be printed out again with the next Rebate Check. 
        /// </summary>
        /// <returns></returns>
        public string generateRebateCheck()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Rebate checks for all customers who have mailed in their rebate listed below: " + "\n" + "\n");
            foreach (KeyValuePair<int, Rebate> pair in rebates)
            {
                if(pair.Value.printed == false)
                {
                    sb.Append("Customer: " + TransactionDatabase.transactions[pair.Key].name + "\n");
                    sb.Append("Date of purchase: " + TransactionDatabase.transactions[pair.Key].month + " " + TransactionDatabase.transactions[pair.Key].date + "\n");
                    sb.Append("Date rebate was mailed: " + rebates[pair.Key].month + " " + rebates[pair.Key].date + "\n");
                    sb.Append("\n");
                    sb.Append("Payments: " + "\n");
                    double totalPrice = 0;
                    double rebateTotal = 0;
                    for (int i = 0; i < pair.Value.products.Count; i++)
                    {
                        if (pair.Value.products[i].returned)
                        {
                            sb.Append(pair.Value.products[i].name + ": RETURNED" + "\n");
                        }
                        else
                        {
                            ///sb.Append("Rebate from: " + pair.Value.products[i].name + ": $" + Math.Round((pair.Value.products[i].price - (pair.Value.products[i].price * discount)), 2).ToString());
                            sb.Append("Original cost of: " + pair.Value.products[i].name + ": $" + Math.Round(pair.Value.products[i].price, 2).ToString() + "\t" + "\t" + "Rebate from: " + pair.Value.products[i].name + ": $" + Math.Round((pair.Value.products[i].price - (pair.Value.products[i].price * discount)), 2).ToString() + "\n");
                            totalPrice += pair.Value.products[i].price;
                            rebateTotal += (pair.Value.products[i].price - (pair.Value.products[i].price * discount));

                        }
                    }
                    sb.Append("\n");
                    sb.Append("Order Total: $" + Math.Round(totalPrice, 2).ToString() + "\n");
                    sb.Append("Money from Rebate Check: $" + Math.Round(rebateTotal, 2).ToString() + "\n" + "\n" + "\n" + "\n");
                    pair.Value.printed = true;
                }
            }
            sb.Append("Note: once a rebate has been printed, it will not show up on future generated rebate checks." + "\n");
            return sb.ToString();
        }
    }
}
