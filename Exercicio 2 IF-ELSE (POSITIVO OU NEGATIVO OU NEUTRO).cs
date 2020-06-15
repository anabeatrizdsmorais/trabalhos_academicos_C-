using System;

namespace prog_estruturad
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
			// Exercicio 2 

          int n;

          Console.WriteLine("Digite um numero: ");
          n = int.Parse(Console.ReadLine());

          if (n > 0 ){
            Console.WriteLine("NUMERO POSITIVO !!");
          }
          else{
            if(n < 0) {
              Console.WriteLine("NUMERO NEGATIVO !!");
            }
            else{
              Console.WriteLine("ZERO !!");
            }
          }
		
		
		}
	}
}
