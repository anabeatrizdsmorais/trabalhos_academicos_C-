using System;

namespace prog_estruturad
{
    class Exercicio22Revisao
    {
        static void Main(string[] args){
            // Exercicio buscar nome no vetor

            string [] nomes = new string [10];
            string nome;
            bool buscar = false;

            for (int i = 0; i < 10; i++){
                Console.WriteLine("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome para buscar: ");
            nome = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if(nomes[i] == nome){
                    buscar = true;
                }
            }

            if(buscar == true){
                Console.WriteLine("ACHEI");
            } else 
                Console.WriteLine("Não achei.");
            //fim
        }

    }
}


