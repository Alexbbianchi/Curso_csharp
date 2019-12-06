using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("=================== Calculo da média ===================");
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();

            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;

            Console.Clear();
            Console.WriteLine("A média do aluno " + nome + " é: " + media);
            Console.WriteLine("Suas notas são: ");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }

            Console.WriteLine("========================================================");
        }

    }
}
