using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Globals;

namespace FBSDataLayer
{
    public class dataDelete
    {
        public static bool textdeleteSpecific(string toDelete)
        {
            //if true, there will be no catch message
            List<string> existingLine = dataReader.textreadALL();

            List<string> tempLine = new List<string>();

            if (existingLine.Count > 0) 
            {
                foreach (var item in existingLine)
                {
                    if (!item.Contains(toDelete))
                    {
                        tempLine.Add(item);
                        
                    }

                }

                File.Delete(Variables._txtFilename);
                dataCreate.createupdatedFile(tempLine);

                return true;
            }




            return false;
        }

    }
}
