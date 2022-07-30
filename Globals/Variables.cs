using System;
using System.Collections.Generic;

namespace Globals
{
    public class Variables
    {
        private static string GenerateFileName()
        {
            string day = DateTime.Today.Date.Day.ToString();
            string month = DateTime.Today.Date.Month.ToString();
            string year = DateTime.Today.Date.Year.ToString();


            return $"D:\\{month}_{day}_{year}-data.txt";
        }


        public static string _txtFilename { get { return GenerateFileName(); }}


    }

}

