using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fatorial do número: ");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine($"O Fatorial de {f} é {Fatorial(f)}");

            Console.ReadKey(true);
        }


        static int Fatorial(int n)
        {
            if (n <= 0)
                return 1;

            return n * Fatorial(n - 1);
            // 5 * Fatorial(4) vai retornar 120
            // 4 * Fatorial(3) vai retornar 24
            // 3 * Fatorial(2) = vai retornar 6
            // 2 * Fatorial(1) = vai retornar 2
            // 1 * Fatorial(0) = vai retornar 1
            // return 1
        }


    }
}
