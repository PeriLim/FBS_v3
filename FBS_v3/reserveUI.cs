using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FBSAppLayer;

namespace FBS_v3
{
    internal class ReserveUI
    {
        internal static void UIreserve()
        {
            UIreserveReminders();

            Console.WriteLine("\n\n\t\t--------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t|                                                                                    |");
            Console.WriteLine("\t\t|           Please fill up the necessary information to proceed                      |");
            Console.WriteLine("\t\t|                                                                                    |");
            Console.WriteLine("\t\t|           REMINDER: Press ENTER Immediately to go back                             |");
            Console.WriteLine("\t\t|                                                                                    |");
            Console.WriteLine("\t\t|           OR ELSE, YOU WILL NOW PROCEED ON FILLING UP THE FORM.                    |");
            Console.WriteLine("\t\t|                                                                                    |");
            Console.WriteLine("\t\t--------------------------------------------------------------------------------------");
            // privacy act
            string transID = textAppend.TransID();

            Console.WriteLine("\t\t|                                                                                    |");

            Console.WriteLine($"\t\t|           Transaction ID:  {transID}                                               |");


            Console.WriteLine("\t\t|                                                                                    |");


            Console.WriteLine("\t\t|           VISA ID Number:                                                          |");
            Console.Write("\n\t\t|\t\tNOTE: *Proper VISA number Format*\t\t\t\t     |");
            Console.WriteLine("\n\t\t|\t\t\t20xx-xxxxx-PH\t\t\t\t\t\t     |");
            Console.Write("\n\t\t\t\t: ");
            string userID = Console.ReadLine();
            Console.Write("\t\t|                                                                                    |");

            bool enterOnly = textAppend.validateVISA2(userID);

            if (enterOnly)
            {
                Console.Clear();
                MainUI.case1UI();
            }

            else
            {
                textAppend.validateVISA(userID);


                Console.WriteLine("\n\t\t|                                                                                    |");

                Console.WriteLine("\t\t|           Name: (FIRSTNAME M.I SURNAME)                                            |");
                Console.Write("\n\t\t\t\t: ");
                string userName = Console.ReadLine().ToUpper();
                Console.WriteLine("\t\t|                                                                                    |");



                Console.Write("\t\t|           Preferred Flight Destination:                                            |");
                Console.WriteLine("\n\t\t|           (1) MANILA - USA                                                         |");
                Console.WriteLine("\t\t|           (2) MANILA - BRAZIL                                                      |");
                Console.WriteLine("\t\t|           (3) MANILA - CHINA                                                       |");
                Console.WriteLine("\t\t|           (4) MANILA - ITALY                                                       |");
                Console.WriteLine("\t\t|           (5) MANILA - NORTH POLE                                                  |");
                Console.Write("\n\t\t\t\t: ");
                string userDesti = Console.ReadLine();
                Console.WriteLine("\t\t|                                                                                    |");

                string userDestination = USERchoiceDestination(userDesti);



                Console.WriteLine("\t\t|           Preferred Time:                                                          |");
                Console.WriteLine("\n\t\t|           (1) 7:00am - 8:00am                                                      |");
                Console.WriteLine("\t\t|           (2) 9:00am - 10:00am                                                     |");
                Console.WriteLine("\t\t|           (3) 11:00am - 12:00pm                                                    |");
                Console.WriteLine("\t\t|           (4) 1:00pm - 2:00pm                                                      |");
                Console.WriteLine("\t\t|           (5) 3:00pm - 4:00pm                                                      |");
                Console.Write("\n\t\t\t\t: ");
                string userTim = Console.ReadLine();

                string userTime = USERChoiceTime(userTim);



                Console.WriteLine("\n\t\t--------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t|     Confirm Information? Y/N                                                       |");
                Console.Write("\t\t|\t\t: ");
                string userConfirm = Console.ReadLine().ToUpper();

                bool validateInput = textAppend.validateInput(userConfirm, userID, userName, userDestination, userTime);














                if (validateInput)
                {
                    Console.Clear();

                    Console.WriteLine("\n\t\tX------------------------------------------------------------------------------------X");
                    Console.WriteLine("\t\t|     WARNING: Fill up the necessary information. Do not leave blank!                |");
                    Console.WriteLine("\t\tX------------------------------------------------------------------------------------X");
                    UIreserve();
                }

                else
                {
                    if (userConfirm == "Y")
                    {

                        bool fileExist = textAppend.confirmReserve(transID, userID, userName, userDestination, userTime);
                        if (fileExist)
                        {
                            Console.WriteLine("\n\t\tSaving...... Completed");
                        }
                        else
                        {
                            Console.WriteLine("\n\t\tX------------------------------------------------------------------------------------X");
                            Console.WriteLine("\t\t|     WARNING: File does not Exist!                                                  |");
                            Console.WriteLine("\t\tX------------------------------------------------------------------------------------X");
                        }




                        Console.WriteLine("\n\t\tPress Enter to continue.....");
                        Console.Write("\n\t\t");
                        Console.ReadLine();

                        Console.Clear();
                        MainUI.case1UI();
                    }

                    else if (userConfirm == "N")
                    {
                        Console.Clear();
                        UIreserve();
                    }
                }





            }
        }

        internal static string USERchoiceDestination(string userDesti)
        {
            switch (userDesti)
            {
                case "1":
                    userDesti = "MANILA - USA";
                    break;
                case "2":
                    userDesti = "MANILA - BRAZIL";
                    break;
                case "3":
                    userDesti = "MANILA - CHINA";
                    break;
                case "4":
                    userDesti = "MANILA - ITALY";
                    break;
                case "5":
                    userDesti = "MANILA - NORTH POLE";
                    break;

            }

            return userDesti;

        }

        internal static string USERChoiceTime(string userTim)
        {
            switch (userTim)
            {
                case "1":
                    userTim = "7:00am - 8:00am";
                    break;
                case "2":
                    userTim = "9:00am - 10:00am";
                    break;
                case "3":
                    userTim = "11:00am - 12:00pm";
                    break;
                case "4":
                    userTim = "1:00pm - 2:00pm";
                    break;
                case "5":
                    userTim = "3:00pm - 4:00pm";
                    break;

            }

            return userTim;

        }



        internal static void UIreserveReminders()
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n\t\t-------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t* REMINDER: PLEASE KEEP THE TRANSACTION ID TO YOURSELF UPON FINISHING THIS FORM.    *");
            Console.WriteLine("\t\t* FOR THIS SERVES AS YOUR RECEIPT FROM THIS ORDERING TRANSACTION.                   *");
            Console.WriteLine("\t\t*                                                                                   *");
            Console.WriteLine("\t\t* UPON FINISHING THE FORM. YOU CAN EITHER LIST YOUR TRANSACTION ID OR ATLEAST \t    *");
            Console.WriteLine("\t\t* TAKE A SCREENSHOT AS A PROOF OF YOUR ORDERING TRANSACTION.                        *");
            Console.WriteLine("\t\t*                                                                                   *");
            Console.WriteLine("\t\t* PRESS ENTER to Continue.                                                          *");
            Console.WriteLine("\t\t-------------------------------------------------------------------------------------");

            Console.Write("\t\t\t\t ");
            Console.ReadKey();

        }


    }
}
