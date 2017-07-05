using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Reqem sayi: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Azaltma miqdari: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Reqem: ");
            int c = Convert.ToInt32(Console.ReadLine());
            while (a >= b)
            {
                Console.WriteLine();
                for (int j = 0; j < a; j++)
                {
                    Console.Write(c);
                }
                a--;
            }
            Console.WriteLine();
        }
    }
}
