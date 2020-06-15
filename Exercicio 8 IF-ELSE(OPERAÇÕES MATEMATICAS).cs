using System;

namespace prog_estruturad
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
			//Exercicio 8
        
			int n1, n2, op;
			double result;

			Console.WriteLine("Digite um numero: ");
			n1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite outro numero: ");
			n2 = int.Parse(Console.ReadLine());

			Console.WriteLine("(1) Adição \n ");
			Console.WriteLine("(2) Subtração \n ");
			Console.WriteLine("(3) Divisão \n");
			Console.WriteLine("(4) Multiplicação \n");
			Console.WriteLine("Digite um número: ");
			op = int.Parse(Console.ReadLine());

			if(op == 1){
			  result = n1+n2;
			  Console.WriteLine("Resultado Adição: " + result);
			} else {
			  if(op == 2){
				result = n1-n2;
				Console.WriteLine("Resultado Subtração: " +result);
			  } else {
				if(op == 3){
				  result = n1/n2;
				  Console.WriteLine("Resultado Divisão: " +result);
				} else{
				  if(op == 4){
					result = n1*n2;
					Console.WriteLine("Resultado Multiplicação: " +result);
				  } 
				}
			  }
			}
		  
		}
	}
}