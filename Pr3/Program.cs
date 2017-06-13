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

            f = i + k + d - i; 

            Console.WriteLine(f);

            //откуда я должен черпать информацию о том, как конвертировать массив байт в целое число, если этого нет в лекционном материале??? как и работы с объектами, укпаковкой и распаковкой?

            int numVal = -1;
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive).");

                string input = Console.ReadLine();

                // ToInt32 can throw FormatException or OverflowException.
                try
                {
                    numVal = Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (numVal < Int32.MaxValue)
                    {
                        Console.WriteLine("The new value is {0}", numVal + 1);
                    }
                    else
                    {
                        Console.WriteLine("numVal cannot be incremented beyond its current value");
                    }
                }
                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
