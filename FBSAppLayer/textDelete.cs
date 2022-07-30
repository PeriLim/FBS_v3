using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using FBSDataLayer;

namespace FBSAppLayer
{
    public class textDelete
    {
        public static bool validateconfirmDelete(string userConfirm)
        {
            while (userConfirm == String.Empty)
            {
                return true;

            }

            return false;
        }

        public static bool deleteSpecific(string toDelete) 
        {
            bool fileExists = dataDelete.textdeleteSpecific(toDelete);

            if (!fileExists) 
            {
                return false;
            }

            return true;
        }

       

        

    }
}
