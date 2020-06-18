using System;

namespace prog_estruturad
{
    class Exercicio3While
    {
        static void Main(string[] args)
        {
            //Exercicio 3 while
            
            int idade, maioridade, menoridade;
            string nome, nomemaior, nomemenor;

            idade = 0;
            maioridade = 0;
            menoridade = 999;
            
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            
            nomemaior = "";
            nomemenor = "";

            while (nome != "sair"){

                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("____________");

                if(idade > maioridade){
                    maioridade = idade;
                    nomemaior = nome;    
                } 
                if(idade < menoridade){
                    menoridade = idade;
                    nomemenor = nome;
                }

                Console.Write("Nome: ");
                nome = Console.ReadLine();
            
            }

            Console.WriteLine("Idade da pessoa mais velha: {0}", maioridade);
            Console.WriteLine("Idade da pessoa mais nova: {0}", menoridade);
            Console.WriteLine("Nome da pessoa mais velha: " + nomemaior);
            Console.WriteLine("Nome da pessoa mais nova: " + nomemenor);
            




            // FIM
        

        }
    }
}
