using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBSDataLayer;

namespace FBSAppLayer
{
    public class textRead
    {
        public static bool fileExistence() 
        {
            List<string> dataContent = dataReader.textreadALL();

            if (dataContent.Count > 0)
            {

               


                return true;
            }
            return false;
        }


        public static bool readAll()
        {

            List<string> dataContent = dataReader.textreadALL();

            if (dataContent.Count > 0)
            {

                foreach (var lines in dataContent)
                {
                    Console.Write($"\t\t\t    {lines.ToUpper()}\t\t\t\n\n");
                }


                return true;
            }
            return false;

        }


        public static bool readSpecific(string search)
        {

            List<string> dataSearched = dataReader.textreadSpecific(search);

            if (dataSearched.Count > 0)
            {

                foreach (var lines in dataSearched)
                {
                    Console.WriteLine($"\n\t\t\t {lines.ToUpper()}\t\t\t");
                }


                return true;
            }
            return false;

        }


        public static bool validatespecificSearch(string input)
        {
            if (input == String.Empty)
            {
                return true;
            }

            return false;
        }




    }
}
