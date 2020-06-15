using System;

namespace prog_estruturad
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
			// Exercicio 5
          
           
          int n1, n2, n3;

          Console.WriteLine("Digite 1? numero: ");
          n1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite 2? numero: ");
          n2 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite 3? numero: ");
          n3 = int.Parse(Console.ReadLine());

          if(n1 > n2 && n1 > n3){
            if(n2 > n3){
              Console.WriteLine(n1 + " " + n2 + " " + n3);
            } else {
              Console.WriteLine(n1 + " " + n3 + " " + n2);
            }
          } else {
            if (n2 > n1 && n2 > n3){
              if(n3 > n1) {
                Console.WriteLine(n2 + " " + n3 + " " + n1);
              } else {
                Console.WriteLine(n2 + " " + n1 + " " + n3);
              }
            }
          }
          if (n3 > n1 && n3 > n2){
            if(n2 > n1){
              Console.WriteLine(n3 + " " + n2 + " " + n1);
            } else {
              Console.WriteLine(n3 + " " + n1 + " " + n2);
            }
          }
         
            
		}
	}
}