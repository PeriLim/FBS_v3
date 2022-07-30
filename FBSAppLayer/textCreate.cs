using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FBSDataLayer;
using Globals;

namespace FBSAppLayer
{
    public class textCreate
    {
        public static bool createNewFile()
        {
            bool FileExists = dataCreate.newFile();

            if (!FileExists)
            {
                return true;

            }

            return false;
        }


       
    }
}
