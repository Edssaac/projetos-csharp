using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Aluno
    {
        public string Nome { get; private set; }

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas]; //Inicializando o array;
        }

        public void InserirNotas()
        {
            Console.WriteLine($"{Nome}:");
            for (int nota = 0; nota < _notas.Length; nota++)
            {
                Console.Write($"Nota #{nota+1}: ");
                _notas[nota] = double.Parse(Console.ReadLine());

            }

            Console.WriteLine();
        }

        private double CalcularMedia()
        {
            double total = 0;


            for (int nota = 0; nota < _notas.Length; nota++)
            {
                total += _notas[nota];
            }

            total /= _notas.Length;

            return total;
        }


    }
}
