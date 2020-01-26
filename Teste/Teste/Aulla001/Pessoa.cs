using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Aulla001
{
    public class Pessoa 
    {
        private string nome;
        private double altura;

        public void setNome(String _nome)
        {
            this.nome = _nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        
        public void setAltura(Double _altura)
        {
            this.altura = _altura;
        }
        public double getAltura()
        {
            return this.altura;
        }

        public void faleSobreVoce()
        {
            Console.WriteLine(
                "Meu nome é " 
                + nome + 
                " e minha altura é de "
                + altura
            );
        }

        
    }
}
