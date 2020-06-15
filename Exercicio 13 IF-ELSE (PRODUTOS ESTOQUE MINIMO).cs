using System;

namespace prog_estruturad
{
    class Exercicio13
    {
        static void Main(string[] args)
        {
          string y, nome;
          int x=0, i, qtd;

          for (i=0;i < 4;i++)
          {
              
            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de produto: ");
            qtd = int.Parse(Console.ReadLine());

            if(qtd < 30){
                x = x+1;
                y = nome;

            }
                
          }

            Console.WriteLine("Quantidade de Produtos abaixo do estoque: " +x);
            Console.WriteLine(y); // não soube usar.
			Console.WriteLine("Os produtos " + y + " estão abaixo do estoque.")

          /*
          Console.WriteLine("Digite o nome do produto: ");
          nome1 = Console.ReadLine();

          Console.WriteLine("Digite a quantidade de produto: ");
          qtd1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o nome do produto: ");
          nome2 = Console.ReadLine();

          Console.WriteLine("Digite a quantidade de produto: ");
          qtd2 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o nome do produto: ");
          nome3 = Console.ReadLine();

          Console.WriteLine("Digite a quantidade de produto: ");
          qtd3 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o nome do produto: ");
          nome4 = Console.ReadLine();

          Console.WriteLine("Digite a quantidade de produto: ");
          qtd4 = int.Parse(Console.ReadLine());
            */
          

        }
    }
}