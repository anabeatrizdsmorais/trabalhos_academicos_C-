using System;

namespace prog_estruturad
{
    class Exercicio15Revisao
    {
        static void Main(string[] args){
            // Exercicio quantidade de votos para candidatos
            int voto=0, s1=0, s2=0, s3=0, s4=0, s5=0,s6=0;

            //Console.WriteLine("Voto: ");
            //voto = int.Parse(Console.ReadLine());
                Console.WriteLine("Candidato 1(1)");
                Console.WriteLine("Candidato 2(2)");
                Console.WriteLine("Candidato 3(3)");
                Console.WriteLine("Candidato 4(4)");
                Console.WriteLine("Voto Nulo(5)");
                Console.WriteLine("Voto em Branco(6)");
                Console.WriteLine("Digite o seu voto: ");
                voto = int.Parse(Console.ReadLine());
                
                Console.WriteLine("_________________");


            while(voto != 0){
                
                if(voto == 1){
                    s1++;
                } else if(voto == 2){
                    s2++;
                } else if(voto == 3){
                    s3++;
                } else if(voto == 4){
                    s4++;
                } else if(voto == 5){
                    s5++;
                } else  if(voto == 6){
                    s6++;
                }

                Console.WriteLine("Candidato 1(1)");
                Console.WriteLine("Candidato 2(2)");
                Console.WriteLine("Candidato 3(3)");
                Console.WriteLine("Candidato 4(4)");
                Console.WriteLine("Voto Nulo(5)");
                Console.WriteLine("Voto em Branco(6)");
                Console.WriteLine("Digite o seu voto: ");
                voto = int.Parse(Console.ReadLine());
                
                Console.WriteLine("_________________");

            }

            Console.WriteLine("Total de votos Candidato 1: {0}", s1);  
            Console.WriteLine("Total de votos Candidato 2: {0}", s2);
            Console.WriteLine("Total de votos Candidato 3: {0}", s3);
            Console.WriteLine("Total de votos Candidato 4: {0}", s4);
            Console.WriteLine("Total de votos nulos 5: {0}", s5);
            Console.WriteLine("Total de votos em branco 6: {0}", s6);


        }

    }
}


