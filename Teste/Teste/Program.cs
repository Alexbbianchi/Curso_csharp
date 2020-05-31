using System;
using Teste.Aulla001;

namespace Teste
{
    class Program 
    {
        static void Main(string[] args)
        {
            /*Caneta c1 = new Caneta();
            c1.Id = new Guid();
            c1.cor = "Azul";
            c1.ponta = 0.5f;
            c1.destampar();
            c1.status();
            c1.rabiscar();

            Console.WriteLine("----------------------");

            Caneta c2 = new Caneta();
            c2.Id = new Guid();
            c2.modelo = "Hostnet";
            c2.cor = "Preta";
            c2.ponta = 0.9f;
            c2.tampar();
            c2.status();
            c2.rabiscar();*/

            // teste
            /*
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();

            Console.WriteLine("Efetua a leitura dos dados três pessoas");
            //Pessoa 1
            Console.WriteLine("Dados da 1 pessoa");
            Console.WriteLine("Informe o seu nome: ");

            string entrada = Console.ReadLine();
            pessoa1.setNome(entrada);

            Console.WriteLine("Informe sua altura ");
            entrada = Console.ReadLine();
            pessoa1.setAltura(Convert.ToDouble(entrada));
            pessoa1.faleSobreVoce();

           */
            Teste1 teste = new Teste1(5);
            Console.WriteLine(teste.a);
        }
    }
}
