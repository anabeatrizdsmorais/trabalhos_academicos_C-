using System;

namespace prog_estruturad
{
    class Exercicio14
    {
        static void Main(string[] args)
        {
          // Exercicio 14
			 int ndiaria;
          double resultado, diaria;
          string nome;

          diaria = 80;

          Console.WriteLine("Nome do cliente: ");
          nome = Console.ReadLine();
          
          Console.WriteLine("Digite o numero de dias hospedado: ");
          ndiaria = int.Parse(Console.ReadLine());

          if(ndiaria > 10){
            resultado = diaria + (5.50 * ndiaria);
            Console.WriteLine("Resultado: " +resultado);
            Console.WriteLine("O cliente " + nome + " usou " + ndiaria + " diarias, pagará: " + resultado); 
          } else {
            if (ndiaria >=5 && ndiaria <= 10){

              resultado = diaria + (6 * ndiaria);
              Console.WriteLine("Resultado: " +resultado);
              Console.WriteLine("O cliente " + nome + " usou" + ndiaria + " diarias, pagará: " + resultado); 
            } else {
              if(ndiaria < 5){
                resultado = diaria + (8 * ndiaria);
                Console.WriteLine("Resultado: " +resultado);
                Console.WriteLine("O cliente " + nome + "que usou " + ndiaria + " diarias, pagará: " + resultado);
              }
            }

          }


         
        }
    }
}