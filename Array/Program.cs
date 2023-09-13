using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] alunos = { "Erick", "Renon", "Samuel Conections", "Gustavo", "Lucas", "Richard", "Pedro", "Guilherme", "Rafaela", "Danilo", "Danny", "Edilson", "Monique", "Reryel", "Thiago" };
            string[] professores = { "Paulo", "Vagner", "Ricardo", "Eduardo" };

            float[] idades = { 17, 25, 19, 19, 18, 17, 17, 19, 18, 17, 30, 23, 29, 23, 20 };
            
            Console.WriteLine(idades.Length);
            Console.WriteLine(alunos.Length);
            Console.WriteLine(professores.Length);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nAlunos\n------");
            Console.ResetColor();


            //float media = 0;
            for (int i = 0; i < alunos.Length; i++)
            {

                //media += idades[i];
                Console.WriteLine(alunos[i] + "\n - Idade: " + idades[i] + "\n");

            }

            //Média mais complexa
            /*media /= idades.Length;
            Console.Write("A média das idades são: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(media);
            Console.ResetColor();*/

            //Média de forma mais simples o possível
            Console.Write("\nA média das idades são: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(idades.Sum() / idades.Length);
            Console.ResetColor();


            foreach(var aluno in alunos)
            {
                Console.WriteLine("Estou vindo da variavel ALUNO do foreach: " + aluno);
            }



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nProfessores\n-----------");
            Console.ResetColor();

            for (int i = 0; i < professores.Length; i++)
            {
                Console.WriteLine(professores[i]);
            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
