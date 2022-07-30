using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FBSAppLayer;

namespace FBS_v3
{
    public class specificSearchUI
    {
        public static void searchspecificUI()
        {
           
            Console.WriteLine("\n\n\t\t-------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t* REMINDER: PLEASE SEARCH USING YOUR VALID *VISA ID* TO ENSURE DATA ACCURACY.       *");
            Console.WriteLine("\t\t*                                                                                   *");
            Console.WriteLine("\t\t* TO GO BACK, JUST PRESS ENTER.                                                     *");
            Console.WriteLine("\t\t-------------------------------------------------------------------------------------");





            Console.Write("\n\t\t\t  -----------------------------------------------------------------------\n");
            Console.WriteLine("\t\t\t  *\t\t\t* VISA History Search *\t\t\t\t*");
            Console.WriteLine("\t\t\t  *\t\t\t                       \t\t\t\t*");


            Console.Write("\t\t\t\t  SEARCH:  ");
            string search = Console.ReadLine();


            Console.Write("\t\t\t  ----------------------------------------------------------------------\n");

            bool isEmptySearch = textRead.validatespecificSearch(search);

            if (isEmptySearch)
            {
                Console.Clear();
                MainUI.case1UI();
            }

            else
            {
                bool dataExist = textRead.readSpecific(search);

                if (!dataExist)
                {
                    Console.WriteLine("\n\t\t\t  -----------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t  *\t\t\t                       \t\t\t\t*");
                    Console.WriteLine("\t\t\t  *\tNOTE: Searched Data does not Exist!\t\t\t\t*");

                    Console.Write("\t\t\t  *\t\t\t                       \t\t\t\t*");
                    Console.WriteLine("\n\t\t\t  *\tPress Enter to continue...\t\t\t\t\t*");
                    Console.WriteLine("\t\t\t  -----------------------------------------------------------------------");

                    Console.Write("\t\t\t\t ");
                    Console.ReadKey();

                    Console.Clear();
                    searchspecificUI();
                }
                else
                {
                    Console.WriteLine("\n\t\t\t  -----------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t  *\t\t\t                       \t\t\t\t*");
                    Console.WriteLine("\t\t\t  *\t\t\t**SEARCH SUCCESSFULL!**\t\t\t\t*");

                    Console.Write("\t\t\t  *\t\t\t                       \t\t\t\t*");
                    Console.WriteLine("\n\t\t\t  *\tPress Enter to continue...\t\t\t\t\t*");
                    Console.WriteLine("\t\t\t  -----------------------------------------------------------------------");

                    Console.Write("\t\t\t\t ");
                    Console.ReadKey();

                    Console.Clear();
                    searchspecificUI();
                }
            }
        }


    }
}
