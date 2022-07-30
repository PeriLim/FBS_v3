using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FBSAppLayer;

namespace FBS_v3
{
    internal class specificDeleteUI
    {

        public static void deletespecificUI()
        {
            Console.WriteLine("\n\n\t\t-------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t* REMINDER: PLEASE SEARCH USING YOUR ACTUAL TRANSACTION ID TO ENSURE DATA ACCURACY. *");
            Console.WriteLine("\t\t*                                                                                   *");
            Console.WriteLine("\t\t* UPON VIEWING THE PRINTED OR SCREENSHOT OF YOUR RECEIPT, YOU SHOULD SEE \t    *");
            Console.WriteLine("\t\t* YOUR TRANSACTION ID ABOVE BESIDE YOUR VISA ID NUMBER.                             *");
            Console.WriteLine("\t\t*                                                                                   *");
            Console.WriteLine("\t\t* TO GO BACK, JUST PRESS ENTER.                                                     *");
            Console.WriteLine("\t\t-------------------------------------------------------------------------------------");

            Console.Write("\n\t\t\t  -----------------------------------------------------------------------\n");
            Console.WriteLine("\t\t\t  *\t\t\t* CANCEL ORDER Search *\t\t\t\t*");
            Console.WriteLine("\t\t\t  *\t\t\t                       \t\t\t\t*");


            Console.Write("\t\t\t\tTransaction ID:  ");
            string search = Console.ReadLine();

            bool isEmptySearch = textRead.validatespecificSearch(search);

            if (isEmptySearch)
            {
                Console.Clear();
                MainUI.case1UI();
            }

            else
            {

                Console.Write("\t\t\t  -----------------------------------------------------------------------\n");

                // 1st: show transaction
                bool lineExist = searchLine(search);

                if (lineExist)
                {
                    Console.WriteLine("\n\t\t\t-------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t*\t\t\t                       \t\t\t\t*");
                    Console.WriteLine("\t\t\t*\t    Do you want to Delete Selected Transaction? (Y/N)\t\t*");
                    Console.WriteLine("\t\t\t*\t\t\t                       \t\t\t\t*");

                    Console.Write("\t\t\t\t\t: ");
                    string userConfirm = Console.ReadLine().ToUpper();

                    Console.Write("\t\t\t-------------------------------------------------------------------------");


                    bool isEmptyConfirm = textDelete.validateconfirmDelete(userConfirm);





                    if (isEmptyConfirm)
                    {
                        Console.Clear();

                        Console.WriteLine("\n\t\tX------------------------------------------------------------------------------------X");
                        Console.WriteLine("\t\t|     WARNING: Fill up the necessary information. Do not leave blank!                |");
                        Console.WriteLine("\t\tX------------------------------------------------------------------------------------X");
                        deletespecificUI();
                    }

                    else 
                    {
                        if (userConfirm == "Y")
                        {
                            bool deleted = textDelete.deleteSpecific(search);

                            if (deleted)
                            {
                                Console.WriteLine("\n\t\t\t-------------------------------------------------------------------------");
                                Console.WriteLine($"\t\t\t*\t    *Transaction ID {search} has been deleted*\t\t\t*");
                                Console.WriteLine("\t\t\t-------------------------------------------------------------------------");

                                Console.Write("\t\t\t\t ");
                                Console.ReadKey();

                                Console.Clear();
                                MainUI.case1UI();
                            }
                            else
                            {
                                Console.Write("\n\n\t\t\t----------------------------------------------------------------------------------\n");
                                Console.WriteLine("\t\t\t*\tError deleting data from file. Either data or the file is not existing.\t*");
                                Console.Write("\t\t\t----------------------------------------------------------------------------------");

                                Console.Write("\t\t\t\t ");
                                Console.ReadKey();

                                Console.Clear();
                                MainUI.case1UI();
                            }
                        }
                        else if (userConfirm == "N")
                        {
                            Console.Clear();
                            deletespecificUI();

                        }
                    }
                        
                    
                }
            }
        }

        public static bool searchLine(string search)
        {
            bool dataExist = textRead.readSpecific(search);

            if (!dataExist)
            {
                Console.WriteLine("\n\t\t\t  *\t\t\t                       \t\t\t\t*");
                Console.WriteLine("\t\t\t  -----------------------------------------------------------------------");
                Console.WriteLine("\t\t\t  *\tNotice: Searched Data does not Exist!\t\t\t\t*");
                Console.WriteLine("\t\t\t  -----------------------------------------------------------------------");

                Console.Write("\t\t\t\t ");
                Console.ReadKey();

                Console.Clear();
                deletespecificUI();

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
