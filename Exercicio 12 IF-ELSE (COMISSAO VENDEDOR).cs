using System;

namespace prog_estruturad
{
    class Exercicio12
    {
        static void Main(string[] args)
        {

            // EXERCICIO 12

            double vlr_total, resultado;

            Console.WriteLine("Digite o valor total da venda: ");
            vlr_total = float.Parse(Console.ReadLine());

            if (vlr_total > 20000){
              resultado = vlr_total*10/100; 
              Console.WriteLine("O funcionario fez mais que 20.000, entao receberá: " +resultado);
            } else {
              resultado = vlr_total *7.5/100;
              Console.WriteLine("O funcionario fez menos de 20.000, entao receberá: " +resultado); 
            }
    
  
        }
    }
}