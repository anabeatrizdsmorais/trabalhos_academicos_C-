using System;

namespace prog_estruturad
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
			// exercicio 6
			
			int n;
			double h, peso;

			Console.WriteLine("Digite (1) Feminino / (2) Masculino: ");
			n = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a altura: ");
			h = double.Parse(Console.ReadLine());

			if ( n == 1){
			  peso = (62.1 * h) - 44.7;
			  Console.WriteLine("Peso ideal feminino é: " + peso);
			} 
			else {
			  peso = (72.7 * h) - 58;
			  Console.WriteLine("Peso ideal masculino é: " + peso);
			}
        	
		}
	}
}