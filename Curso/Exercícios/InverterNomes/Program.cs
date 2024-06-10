using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            string nomeInvertido=null, nome = Console.ReadLine();

            for ( int i=nome.Length-1; i>=0; i-- )
            {
                nomeInvertido = nomeInvertido+nome[i];
            }

            Console.WriteLine(nomeInvertido);

            Console.ReadKey(true);
        }
    }
}
