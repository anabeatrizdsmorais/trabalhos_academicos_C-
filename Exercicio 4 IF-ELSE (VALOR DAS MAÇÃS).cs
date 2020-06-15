using System;

namespace prog_estruturad
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
			// Exercicio 4
          
          int nfruta;
          double valor;

          Console.WriteLine("Digite um numero de frutas: ");
          nfruta = int.Parse(Console.ReadLine());

          if(nfruta >=12){
            valor = nfruta*0.25;
            Console.WriteLine("O valor das maçãs é: " + valor);
          }
          else{
            valor = nfruta * 0.30;
            Console.WriteLine("o valor das maçãs é: " + valor);
          }
          
		}
	}
}