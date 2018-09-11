using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501.cs
{
    /// <summary>
    /// The UI class deals with all user inputs.  This class reads the users input (1, 2, 3, or 4) and
    /// calls the appropriate method from the appropriate database.  
    /// </summary>
    class UI
    {
        /// <summary>
        /// The database holding all Transactions in the program
        /// </summary>
        public static TransactionDatabase TDB = new TransactionDatabase();

        /// <summary>
        /// The database holding all Rebates in the program
        /// </summary>
        public static RebateDatabase RDB = new RebateDatabase();

        /// <summary>
        /// Main method of program, handles all user inputs on a case by case basis (1, 2, 3, or 4)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {    
            while(true)
            {
                Console.WriteLine("Welcome to Sales501! Enter 1 to make a transaction. Enter 2 to return an item. Enter 3 to submit a rebate. Enter 4 to generate rebate check.");
                string response = Console.ReadLine();
                if(response == "1")
                {
                    Console.WriteLine(TDB.makeTransaction());
                }
                if(response == "2")
                {
                    TDB.returnItem();
                }
                if(response == "3")
                {
                    RDB.mailInRebate();
                }
                if(response == "4")
                {
                    Console.WriteLine(RDB.generateRebateCheck());
                }
            }
        }       
    }
}
