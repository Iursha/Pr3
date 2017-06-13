using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=3;
            bool b = new bool();
            double d = i;
            long l = i++;
            byte by;
            by = 1;

           int k=(int)d;
            bool c = b;
            object f = d;
            long m = i;
            byte t = by; 

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
