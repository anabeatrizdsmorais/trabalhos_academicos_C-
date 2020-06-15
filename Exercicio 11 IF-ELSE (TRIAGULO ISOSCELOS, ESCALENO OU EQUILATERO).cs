using System;

namespace prog_estruturad
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
			
        // Exercicio 11
                int lado1, lado2, lado3;

        Console.WriteLine("Digite a 1º de um triangulo: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2º de um triangulo: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 3º de um triangulo: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3){
          Console.WriteLine("[TRIANGULO EQUILATERO] "); //3 IGUAIS 
        } else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3){
          Console.WriteLine("[TRIANGULO ISOSCELES]"); // 2 LADOS IGUAIS
        } else if(lado1 != lado2 && lado2 != lado3 && lado1 != lado3){
          Console.WriteLine("[TRIANGULO ESCALENO]"); // 3 LADOS DIFERENTES
        }


        

		}
	}
}