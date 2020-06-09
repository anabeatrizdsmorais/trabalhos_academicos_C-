using System;

namespace prog_estruturad
{
    class Exercicio1For
    {
        static void Main(string[] args)
        {
            int i, soma_a, soma_r; 
            float media, nota1, nota2, nota3, nota4, nota5, nota6;

            soma_r = 0;
            soma_a = 0;
            media = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite a 1ª nota: ");
                nota1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 2ª nota: ");
                nota2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 3ª nota: ");
                nota3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 4ª nota: ");
                nota4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 5ª nota: ");
                nota5 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 6ª nota: ");
                nota6 = int.Parse(Console.ReadLine());

                media = (nota1+nota2+nota3+nota4+nota5+nota6)/6;   
                
                if(media >= 0 && media <= 5.0){
                    Console.WriteLine("REPROVADISSIMO !!!");
                    Console.WriteLine("Media do aluno reprovado:{0} ", media);
                    soma_r = soma_r + 1;
                } else if(media >= 5.1 && media <= 6.9){
                    Console.WriteLine("RECUPERAÇÃO !!!");
                    Console.WriteLine("Media do aluno em recuperação:{0} ", media);
                } else if(media >= 7 && media <= 10) {
                    Console.WriteLine("APROVADISSIMO !!!");
                    Console.WriteLine("Media do aluno aprovado:{0} ", media);
                    soma_a = soma_a + 1;
                }

                Console.WriteLine("_______________________________");
            }

            //Console.WriteLine("Media da nota dos alunos: ", +media);
            Console.WriteLine("Total de alunos aprovados:{0} ", soma_a);
            Console.WriteLine("Total de alunos reprovados:{0} ", soma_r);
        
        }
    }
}
