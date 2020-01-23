using Curso_csharp.Classes;
using Menu;
using System;
using System.Collections.Generic;
using System.IO;

namespace Curso_csharp
{
    class Program
    { 
        static void Main(string[] args)
        {
           // Tela.Criar();

            var clientes = Cliente.LerClientes();
           
            var cliente = new Cliente();
            cliente.Nome = "Alex";
            cliente.Telefone = "95254133";
            cliente.CPF = "95232563363";
            cliente.Gravar();
            
            var cliente2 = new Cliente();
            cliente2.Nome = "Sandro";
            cliente2.Telefone = "343434";
            cliente2.CPF = "34456767";
            cliente2.Gravar();
        }
    }
}
