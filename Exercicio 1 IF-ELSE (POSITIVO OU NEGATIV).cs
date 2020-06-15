using System;

namespace prog_estruturad
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
          
          // Exercicio 1 (IF-ELSE)

          int n;

          Console.WriteLine("Digite um numero: ");
          n = int.Parse(Console.ReadLine());

          if (n >= 0){
            Console.WriteLine("NUMERO POSITIVO !!");
          }
          else{
            Console.WriteLine("NUMERO NEGATIVO !!");
          }
          
		}
	}
}