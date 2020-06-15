using System;

namespace prog_estruturad
{
    class Exercicio15
    {
        static void Main(string[] args)
        {
          //Exercicio 15
          
          int nlados, medida, perim;

          Console.WriteLine("Digite quantos lados tem o polígono: ");
          nlados = int.Parse(Console.ReadLine());

          Console.WriteLine("Digte a medida dos lados: ");
          medida = int.Parse(Console.ReadLine());

          if (nlados == 3){
            perim = medida * 3; // perimetro do triangulo
            Console.WriteLine("TRIANGULO e a medida dos lados é: " +perim);
          } else if(nlados == 4) { // perimetro do quadrado
            perim = medida * medida ;
            Console.WriteLine("QUADRADO e a medida da area é: " +perim);
          } else if(nlados == 5) {
            Console.WriteLine("PENTÁGONO");
          }
          


        }
    }
}
