using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurtion
{
    class Program
    {
        static void Main(string[] args)
        {
            WithForLoop();
            PrintToTenWithRecurion(1);
        }

         static void PrintToTenWithRecurion(int i)
        {
            Console.WriteLine(i);
            i++;
            if (i <= 10)
            {
                PrintToTenWithRecurion(i);
                Console.WriteLine("Jag är färdig " + i);
            }
        }

        private static void WithForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
