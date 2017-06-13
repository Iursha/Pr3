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

            byte[] bytes = { 0, 0, 0, 25 };

            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            int g = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine("int: {0}", i);
            // Output: int: 25

            Console.WriteLine("Введите входное значение  ");
                string h = Console.ReadLine();
                int vhod_znach = Convert.ToInt32(h);
                Console.Write(vhod_znach);
                Console.Read();

           /* Console.WriteLine("Введите входное значение  ");
            string s = Console.ReadLine();
            int vhod = Convert.ToInt16(s);
            Console.Write(vhod_znach);
            Console.Read();*/

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
