using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_assessment_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "XOXOXOXO";
            string b = "OXOXOXOX";
            for (int rowCount = 0; rowCount < 8; rowCount++)
            {
                //string b = for (int XOCount = 0; XOCount < 4; XOCount ++) { Console.Write(a); };
                if ((rowCount + 2) % 2 != 0 )
                {
                    Console.WriteLine(b);
                    //    //for (int XOCount = 0; XOCount < 4; XOCount++)
                    //    //{
                    //    Console.WriteLine(a);
                    //    //}
                    //}

                    //Console.WriteLine(for (int letterCount = 0; letterCount < 4; letterCount++)
                    //        {Console.Write(a);});   
                    ////}
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
