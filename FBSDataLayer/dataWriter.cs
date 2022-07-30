using System;
using System.Collections.Generic;
using System.IO;

using Globals;

namespace FBSDataLayer
{
    public class dataWriter
    {
       
        public static bool textAppend(string transID, string userID, string userName, string userDestination, string userTime)
        {
            DateTime currentDateTime = DateTime.Now;
            


            if (File.Exists(Variables._txtFilename))
            {
                using (StreamWriter append = File.AppendText(Variables._txtFilename))
                {
                    append.Write($"{currentDateTime}/{transID}/{userID}/{userName}/{userDestination}/{userTime}/".ToUpper());


                    append.Close();

                    return true;
                }

            }
                return false;
        }








    }
}
