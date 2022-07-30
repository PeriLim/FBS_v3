using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FBSAppLayer;

namespace FBS_v3
{
    internal class allsearchUI
    {
        internal static void searchallUI() 
        {
            Console.WriteLine("\n\n\t\t-----------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t*\t\t\t********HISTORY********\t\t\t\t\t\t*");
            Console.WriteLine("\t\t*\t\t\t                       \t\t\t\t\t\t*");


            bool isEmpty = textRead.readAll();

            if (!isEmpty)
            {
                Console.WriteLine("\n\t\t*\t\tWARNING: FILE DOES NOT EXIST\t\t\t\t\t\t*");
            }
           

            Console.Write("\t\t*\t\t\t\t                       \t\t\t\t\t*");
            Console.WriteLine("\n\t\t*\t\tPress Enter to continue...\t\t\t\t\t\t*");
            Console.WriteLine("\t\t-----------------------------------------------------------------------------------------");
            
            Console.Write("\n\t\t\t");
            Console.ReadKey();

            Console.Clear();
            MainUI.MainMenu();
        }
    }
}