using System;

namespace prog_estruturad
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
			// Exercicio 10 decrescente
			
			int n1, n2, n3;

          Console.WriteLine("Digite 1º numero: ");
          n1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite 2º numero: ");
          n2 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite 3º numero: ");
          n3 = int.Parse(Console.ReadLine());

          if(n1 < n2 && n1 < n3){
            if(n2 < n3){
              Console.WriteLine(n3 + " " + n2 + " " + n1);
            } else {
              Console.WriteLine(n2 + " " + n3 + " " + n1);
            }
          } else {
            if (n2 < n1 && n2 < n3){
              if(n3 < n1) {
                Console.WriteLine(n1 + " " + n3 + " " + n2);
              } else {
                Console.WriteLine(n3 + " " + n1 + " " + n2);
              }
            }
          }
          if (n3 < n1 && n3 < n2){
            if(n2 < n1){
              Console.WriteLine(n1 + " " + n2 + " " + n3);
            } else {
              Console.WriteLine(n2 + " " + n1 + " " + n3);
            }
          }
          

		}
	}
}