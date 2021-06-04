using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp3
{
    class file
    {
        
       /* public static void writeFile(String fileName,String lines)
        {
            StreamWriter sW = new StreamWriter("test.txt");
            sW.Write("#$@omar+1\nkldjs\nljds");
            sW.Close();


        }*/

        public static String readFile(String fileName)
        {
            StreamReader sR = new StreamReader("test.txt");
            return sR.ReadLine() ;
        }
        





    }
}
