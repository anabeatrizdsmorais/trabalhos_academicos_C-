using System;

namespace prog_estruturad
{
    class Exercicio5While
    {
        static void Main(string[] args)
        {
            //Exercicio 5 while

            int somasim, somanao,respostasim, soma1, soma2;
            string sexo, resposta;
            float homemnao;

            respostasim = 0;     
            homemnao = 0;
            somasim = 0;
            somanao = 0;
            soma1 = 0;
            soma2 = 0;

            Console.Write("Opinião sobre produto (S-SIM/N-NÃO): ");
            resposta = Console.ReadLine();

            while (resposta != "sair")
            {
                Console.Write("Gênero (F/M): ");
                sexo = Console.ReadLine();
                

                Console.WriteLine("_____________");
        
                if(resposta == "s"){
                    somasim += 1;
                } 
                
                if(resposta == "n"){
                    somanao += 1;

                }  
                if(sexo == "f" && resposta == "s"){
                    soma1 = soma1 + 1;
                    respostasim = soma1;
                } 
                if(sexo == "m" && resposta == "n"){
                    soma2 = soma2 + 1;
                    homemnao = (100*soma2)/soma2;
                }

                Console.Write("Opinião sobre produto (S-SIM/N-NÃO): ");
                resposta = Console.ReadLine();

            }

            Console.WriteLine("Nº de pessoas que votaram sim:{0}", somasim);
            Console.WriteLine("Nº de pessoas que votaram nao:{0}", somanao);
            Console.WriteLine("Nº de mulheres que votaram sim:{0}", respostasim);
            Console.WriteLine("Porcentagem de homens que votaram nao:{0}", homemnao);

            // FIM
        

        }
    }
}
