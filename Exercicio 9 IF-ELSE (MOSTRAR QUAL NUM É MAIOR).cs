using System;

namespace prog_estruturad
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
			// Exercicio 9
		  
		  int n1, n2, n3;

		  Console.WriteLine("Numero: ");
		  n1 = int.Parse(Console.ReadLine());

		  Console.WriteLine("Numero: ");
		  n2 = int.Parse(Console.ReadLine());

		  Console.WriteLine("Numero: ");
		  n3 = int.Parse(Console.ReadLine());

		  if (n1 > n2 && n1 > n3) {
			Console.WriteLine(" " +n1);
		  } else {
			if(n2 > n1 && n2 > n3){
			  Console.WriteLine(" " +n2);
			} else {
			  if (n3 > n1 && n3 > n2){
				Console.WriteLine(" " +n3);
			  }
			}        
		  }

      

		}
	}
}