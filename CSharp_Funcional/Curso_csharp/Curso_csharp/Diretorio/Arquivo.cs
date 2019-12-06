using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\WorkSpace\Curso_csharp\Curso_csharp\arq" + numeroArquivo + ".txt";
            Console.WriteLine("\n======= Lendo arquivo =======\n" + arquivoComCaminho);

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\WorkSpace\Curso_csharp\Curso_csharp\arq" + (numeroArquivo + 1) + ".txt";

            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }

    }
}
