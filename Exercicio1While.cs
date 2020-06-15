using System;

namespace prog_estruturad
{
    class Exercicio1While
    {
        static void Main(string[] args)
        {
			//Exercicio 1 WHILE
            int voto, soma1, soma2, soma3, soma4, soma5, soma6;

            soma1 = 0;
            soma2 = 0;
            soma3 = 0;
            soma4 = 0;
            soma5 = 0;
            soma6 = 0;

            Console.Write("Digite o seu voto: ");
            voto = int.Parse(Console.ReadLine());

            Console.WriteLine("_______________");

            while (voto != 0){
                Console.WriteLine("Canditado 1: ");
                Console.WriteLine("Canditado 2: ");
                Console.WriteLine("Canditado 3: ");
                Console.WriteLine("Canditado 4: ");
                Console.WriteLine("Voto Nulo (5): ");
                Console.WriteLine("Voto em branco (6): ");
                voto = int.Parse(Console.ReadLine());

                Console.WriteLine("________________");

                if(voto == 1){
                    soma1 = soma1 + 1;
                } else if(voto == 2){
                    soma2 = soma2 + 1;
                } else if (voto == 3){
                    soma3 = soma3 + 1;
                } else if(voto == 4){
                    soma4 = soma4 + 1;
                } else if(voto == 5){
                    soma5 = soma5 + 1;
                } else if(voto == 6){
                    soma6 = soma6 + 1;
                }
                
                
            }

            
                Console.WriteLine("Nº de votos candidato 1:{0}", soma1);
                Console.WriteLine("Nº de votos candidato 2:{0}", soma2);
                Console.WriteLine("Nº de votos candidato 3:{0}", soma3);
                Console.WriteLine("Nº de votos candidato 4:{0}", soma4);
                
                Console.WriteLine("Nº de votos nulo:{0}", soma5);
                Console.WriteLine("Nº de votos em branco:{0}", soma6);
                

             // FIM
        

        }
    }
}
