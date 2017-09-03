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
            string a = "XO";
            string b = "OX";
            for (int rowCount = 0; rowCount < 8; rowCount++)
            {
                if ((rowCount + 2) % 2 != 0 )
                {
                    for (int bCount = 0; bCount < 4; bCount++)
                    {
                        Console.Write(b);
                    }
                    Console.WriteLine("");
                }
                else
                {
                    for (int aCount = 0; aCount < 4; aCount++)
                    {
                        Console.Write(a);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
