using System;

namespace prog_estruturad
{
    class Exercicio20Revisao
    {
        static void Main(string[] args){
            // Exercicio 20 Revisao

            int [] vet = new int[10];
            int [] vet2 = new int [10];

            for (int i = 0; i < 10; i++){
                Console.WriteLine("Numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++){
                if (vet[i] % 2 == 0){
                    vet2[i] = vet[i]*2;
                } else {
                    vet2[i] = vet[i]*3;
                }
            }
            Console.WriteLine("Vetor 2:");
            for (int i = 0; i < 10; i++){
                Console.WriteLine(vet2[i]);
                Console.WriteLine("_________");
            }

            //fim
        }

    }
}


