using System;

namespace prog_estruturad
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
			// Exercicio 7
			int cru, galo;

			Console.WriteLine("Quantos gols Cruzeiro fez: ");
			cru = int.Parse(Console.ReadLine());

			Console.WriteLine("Quantos gols Atletico Mineiro fez: ");
			galo = int.Parse(Console.ReadLine());

			if(cru > galo){
			  Console.WriteLine("CRUZEIRO CAMPEÃO !!!");
			} else {
			  if(cru == galo){
				Console.WriteLine("EMPATE");
			  } else {
				Console.WriteLine("ATLÉTICO MINEIRO CAMPEÃO !!!");
			  }
			
			}
		}
	}
}