using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teste
            //Aluno Joao = new Aluno("João Henrique da Luz", 5);

            //Joao.InserirNotas();

            //Console.WriteLine("\nNome do Aluno: " + Joao.Nome);
            //Console.WriteLine("Média: " + Joao.Media);
            #endregion

            int nAlunos;

            Console.Title = "Média Geral dos Alunos";

            Console.Write("Número de Alunos: ");
            nAlunos = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int aluno = 0; aluno < nAlunos; aluno++)
            {
                Console.Clear();

                Console.Write($"Nome do Aluno #{aluno + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Número de Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[aluno] = new Aluno(nome, provas);

                Console.WriteLine();
            }

            for (int aluno = 0; aluno < alunos.Length; aluno++)
            {
                alunos[aluno].InserirNotas();
            }

            Console.Clear();

            Console.WriteLine("Médias\n");
            double mediaGeral = 0;

            for (int aluno = 0; aluno < alunos.Length; aluno++)
            {
                Console.WriteLine($"{alunos[aluno].Nome}: {alunos[aluno].Media:N2}");
                mediaGeral += alunos[aluno].Media;
            }

            /*foreach (Aluno aluno in alunos)
            {
                mediaGeral += aluno.Media;
            } */

            mediaGeral /= alunos.Length;

            Console.WriteLine("\nMédia Geral dos Alunos: " + mediaGeral.ToString("N2"));

            Console.ReadKey();
        }
    }
}
