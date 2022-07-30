using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Globals;

namespace FBSDataLayer
{
    public class dataReader
    {
        public static List<string> textreadALL()
        {
            List<string> dataContent = new List<string>();

            try
            {
                using (StreamReader read = new StreamReader(Variables._txtFilename))
                {
                    string line = read.ReadLine();

                    while (line != null)
                    {
                        dataContent.Add(line);
                        line = read.ReadLine();
                    }
                    read.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Write($"\t\t\t\tSystem message: {e.Message}\t");
            }
            return dataContent;
        }

        public static List<string> textreadSpecific(string search)
        {

            List<string> dataSearchedOld = textreadALL();

            List<string> dataSearchedNew = new List<string>();


            foreach (var item in dataSearchedOld)
            {
                if (item.Contains(search))
                {
                    dataSearchedNew.Add(item);
                }

            }
            return dataSearchedNew;
        }






    }
}
