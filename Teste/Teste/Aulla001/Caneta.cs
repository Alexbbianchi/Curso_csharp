using System;

namespace Teste.Aulla001
{
	public class Caneta
	{

		public Guid Id { get; set; }
		public string modelo { get; set; }
		public string cor { get; set; }
		public float ponta { get; set; }
		public int carga { get; set; }
		public Boolean tampada { get; set; }

		public void status()
		{
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Modelo: " + this.modelo);
			Console.WriteLine("Uma caneta: " + this.cor);
			Console.WriteLine("Ponta: " + this.ponta);
			Console.WriteLine("Carga: " + this.carga);
			Console.WriteLine("Está tampada: " + this.tampada);
		}

		public void rabiscar()
		{
			if(this.tampada == true)
			{
				Console.WriteLine("ERRO! Não posso rabiscar");
			} else
			{
				Console.WriteLine("Estou Rabiscando");
			}
		}

		public void tampar()
		{
			this.tampada = true;
		}
		
		public void destampar()
		{
			this.tampada = false;
		}
	}
}