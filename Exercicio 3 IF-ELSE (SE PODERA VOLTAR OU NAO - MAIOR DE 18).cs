using System;

namespace prog_estruturad
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
			// Exercicio 3
            int ano;

            Console.WriteLine("Digite o ano que você nasceu: ");
            ano = int.Parse(Console.ReadLine());

            if (ano <= 2002){
              Console.WriteLine("PODERÁ VOTAR ESSE ANO.");
            }
            else{
              Console.WriteLine("NÃO PODERÁ VOTAR ESSE ANO.");
            }

		}
	}
}