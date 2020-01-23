using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Curso_csharp.Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor da Classe   
        /// </summary>
        /// <param name="_name"></param>
        public Cliente(string _name)
        {
            this.Nome = _name;
        }

        public Cliente() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {

        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;

                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 0) continue;
                        var clienteArquivo = linha.Split(';');
                        var cliente = new Cliente();
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.CPF = clienteArquivo[2];

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
    }
}
