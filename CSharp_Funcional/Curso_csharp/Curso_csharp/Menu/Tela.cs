using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Tela
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa" +
                    "\nUtilizando programação funcional" +
                    "\n\nDigite uma das opções abaixo:" +
                    "\n0 - Sair do programa" +
                    "\n1 - Para ler arquivos" +
                    "\n2 - Para executar a tabuada" +
                    "\n3 - Calcular média de alunos";
                Console.WriteLine("\n========================================================\n");

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());


                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.Clear();
                    Console.WriteLine("==========================Opção Ler Arquivos==============================");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.Clear();
                    Console.WriteLine("============================Opcao Tabuada================================");
                    Console.WriteLine("Digite um número para a tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.Clear();
                    Console.WriteLine("============================Opcao média================================");

                    Media.Aluno();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                }
            }
        }
    }
}
