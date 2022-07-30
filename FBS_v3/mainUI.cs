using System;
using FBSAppLayer;

namespace FBS_v3
{
    internal class MainUI
    {
        private static void Main(string[] args)
        {
            textCreate.createNewFile();

            //specificSearchUI.searchspecificUI();
            MainMenu();
            //specificDeleteUI.deletespecificUI();
            //ReserveUI.UIreserve();
            //ReserveUI.UIreserveReminders();

           
        }


        internal static void MainMenu()
        {
            try
            {

                int choice = 0;
                //for looping


                Console.WriteLine("\n\n\t\t\t*******************************************************************");
                Console.WriteLine("\n\t\t\t                    AIRLINE BOOKING SYSTEM                  ");
                Console.WriteLine("\n\t\t\t*******************************************************************");

                Console.Write("\n\t\t\t\t\t\t\t\t\t\t");

                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine(currentDateTime.ToString("D"));

                Console.WriteLine("\n\n\t\t 1 - My Menu");

                /* additional function siguro */
                //Console.WriteLine("\n\n\t\t 2. Cancel");

                /* search by name function, sana */
                Console.WriteLine("\n\n\t\t 2 - Records");

                Console.WriteLine("\n\n\t\t 3 - EXIT");

                Console.Write("\n\n\t\t Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                //validationUI.validateMainUI(choice);



                bool isTrue = validationUI.validateMainUI(choice);

                if (!isTrue)
                {

                    Console.Clear();
                    Console.Write("Wrong input. Please Choose 1-3 Only.");

                    MainMenu();


                }
                else if (isTrue)
                {
                    UserChoi(choice);
                }



            }
            catch (FormatException a)
            {
                Console.Clear();
                Console.Write($"Wrong Input! {a.Message}");

                MainMenu();
            }
        }


        internal static void UserChoi(int userChoi)
        {


            //switch (userChoi)
            //{
            //    case 1:
            //        bool fileExists = validationUI.validateFileExist();

            //        if (!fileExists)
            //        {


            //            Console.Clear();
            //            Console.WriteLine("\n\n\t\t\t*******************************************************************");
            //            Console.WriteLine("\n\t\t\t                    AIRLINE BOOKING SYSTEM                  ");
            //            Console.WriteLine("\n\t\t\t*******************************************************************");

            //            Console.WriteLine("\n\n\t********************************************************************************************************");
            //            Console.WriteLine("\tx\tWARNING: FILE DOES NOT EXIST OR DELETED! PLEASE CONTACT THE ADMINISTRATOR IMMEDIATELY.\t       x");
            //            Console.WriteLine("\t********************************************************************************************************");

            //            Console.WriteLine("\n\t\t*\tPress Enter to continue...\t\t\t\t\t*");

            //            Console.Write("\t\t\t");
            //            Console.ReadLine();


            //            Console.Clear();
            //            MainMenu();


            //        }
            //        else if (fileExists)
            //        {
            //            UserCase1(userChoi);
            //        }
            //        break;
            //    case 2:
            //        Console.Clear();

            //        allsearchUI.searchallUI();
            //        break;
            //    case 3:

            //        break;
            //}

            if (userChoi == 1)
            {
                bool fileExists = validationUI.validateFileExist();

                if (!fileExists)
                {


                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t*******************************************************************");
                    Console.WriteLine("\n\t\t\t                    AIRLINE BOOKING SYSTEM                  ");
                    Console.WriteLine("\n\t\t\t*******************************************************************");

                    Console.WriteLine("\n\n\t********************************************************************************************************");
                    Console.WriteLine("\tx\tWARNING: FILE DOES NOT EXIST OR DELETED! PLEASE CONTACT THE ADMINISTRATOR IMMEDIATELY.\t       x");
                    Console.WriteLine("\t********************************************************************************************************");

                    Console.WriteLine("\n\t\t*\tPress Enter to continue...\t\t\t\t\t*");

                    Console.Write("\t\t\t");
                    Console.ReadLine();


                    Console.Clear();
                    MainMenu();


                }
                else if (fileExists)
                {
                    UserCase1(userChoi);
                }
            }

            else if (userChoi == 2)
            {
                Console.Clear();

                allsearchUI.searchallUI();
            }

           


        }


        internal static void UserCase1(int userChoice1)
        {

            if (userChoice1 == 1)
            {
                Console.Clear();
                case1UI();
            }





        }


        internal static void case1UI()
        {
            
            Console.WriteLine("\n\n\t\t---------------------------------------------------------------------------------");
            Console.WriteLine("\t\t*\t\t\t\t* USER MAIN MENU *\t\t\t\t*");
            Console.WriteLine("\t\t*\t\t\t                       \t\t\t\t\t*");

            Console.WriteLine("\t\t*\t1 - Order Ticket,  2 - My History,  3 - Cancel Order ,  4 - BACK \t*");




            Console.WriteLine("\t\t---------------------------------------------------------------------------------");


            Console.Write("\n\t\t\tUSER :  ");
            int choiceCase1 = Convert.ToInt32(Console.ReadLine());

            case1UIChoice(choiceCase1);

        }


        internal static void case1UIChoice(int choiceCase1)
        {
            //switch (searchRes)
            //{
            //    case 1:

            //        Console.Clear();
            //        ReserveUI.UIreserve();

            //        break;
            //    case 2:
            //        Console.Clear();
            //        specificSearchUI.searchspecificUI();

            //        break;
            //    case 3:
            //        Console.Clear();
            //        specificDeleteUI.deletespecificUI();
            //        break;

            //    case 4:


            //        Console.Clear();
            //        MainMenu();
            //        break;

            //}

            if (choiceCase1 == 1)
            {
                Console.Clear();
                ReserveUI.UIreserve();
            }
            else if (choiceCase1 == 2)
            {
                Console.Clear();
                specificSearchUI.searchspecificUI();
            }
            else if (choiceCase1 == 3)
            {
                Console.Clear();
                specificDeleteUI.deletespecificUI();
            }
            else if (choiceCase1 == 4)
            {
                Console.Clear();
                MainMenu();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Input out of range. Please Choose options 1-4 Only.");

                case1UI();
            }
        }
    }
}
