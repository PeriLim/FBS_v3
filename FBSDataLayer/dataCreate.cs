using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Globals;

namespace FBSDataLayer
{
    public class dataCreate
    {

        public static bool newFile()
        {
            if (!File.Exists(Variables._txtFilename))
            {
                using (StreamWriter file = File.CreateText(Variables._txtFilename))
                {
                    file.WriteLine($"TransID: / VISA ID: / Name: / Flight Path: / Flight Time: /");
                }

                return true;

            }

            return false;
        }

        public static void createupdatedFile(List<string> tempFile)
        {

            using (StreamWriter file = File.CreateText(Variables._txtFilename))
            {
                foreach (var data in tempFile)
                {
                    file.WriteLine(data);
                }

            }




        }


    }
}
