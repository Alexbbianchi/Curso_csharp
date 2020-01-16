using System;
using Teste.Aulla001;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneta c1 = new Caneta();
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
            c2.rabiscar();
        }
    }
}
