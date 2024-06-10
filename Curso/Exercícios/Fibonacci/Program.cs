using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.Write("Quantidade de valores da sequência de Fibonacci: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci com " + valores + " valores:");

            for (int valor = 0; valor < valores; valor++)
            {
                Console.WriteLine(a);

                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadKey(false);
        }
    }
}
