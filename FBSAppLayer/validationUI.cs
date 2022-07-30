using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSAppLayer
{
    public class validationUI
    {
        public static bool validateMainUI(int choice, bool isTrue = true)
        {
            
            while (choice < 1 || choice > 3)
            {

                
                isTrue = false;
                break;

            }
            return isTrue;
        }

        public static bool validateFileExist() 
        {
            bool fileExist = textRead.fileExistence();

            if (fileExist) 
            {
                return true;
            }


            return false;
        }
    }
}
