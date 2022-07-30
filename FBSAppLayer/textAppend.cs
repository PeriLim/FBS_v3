using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FBSDataLayer;

namespace FBSAppLayer
{
    public class textAppend
    {
        public static bool validateVISA2(string visa, bool isEmpty = false)
        {
            if (visa == String.Empty)
            {
                isEmpty = true;

               
            }

            return isEmpty;
        }

        public static bool validateVISA(string visa, bool isEmpty = false)
        {
            while (!ValidateStudentNumber(visa))
            {
                isEmpty = true;

                Console.Write("\n\t\t|\t\tINVALID VISA Number!\t\t\t\t\t\t     |");
                Console.Write("\n\t\t|\t\tNOTE: *Proper VISA number Format*\t\t\t\t     |");
                Console.WriteLine("\n\t\t|\t\t\t20xx-xxxxx-PH\t\t\t\t\t\t     |");
                Console.Write("\n\t\t\t\t: ");
                visa = Console.ReadLine().ToUpper();
            }

            return isEmpty;
        }

        public static bool validateInput(string userConfirm, string userID, string userName, string userDestination, string userTime, bool isEmpty = false)
        {
            if (userConfirm == String.Empty || userID == String.Empty || userName == String.Empty || userDestination == String.Empty || userTime == String.Empty)
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        public static bool confirmReserve(string transID, string userID, string userName, string userDestination, string userTime)
        {

            bool isdataEmpty = dataWriter.textAppend(transID, userID, userName, userDestination, userTime);

            if (isdataEmpty)
            {
                return true;
            }

            return false;
        }

        static internal bool ValidateStudentNumber(string data)
        {
            return data.Length == 13 && data.StartsWith("20") && data.EndsWith("PH");
        }


        //Random String Number Generator

        private static Random random = new Random();
        public static int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);


            char offset = lowerCase ? 'a' : 'A';

            const int lettersOffset = 12; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var chariz = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(chariz);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public static string TransID()
        {
            var cusnum = new StringBuilder();

            // Generates a both string and number.  

            cusnum.Append(RandomString(2));
            cusnum.Append(RandomNumber(1000, 9999));
            cusnum.Append(RandomString(3, true));


            return cusnum.ToString();
        }







    }
}
