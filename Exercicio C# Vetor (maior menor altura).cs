using System;

namespace prog_estruturad
{
    class Exercicio21Revisao
    {
        static void Main(string[] args){
            // Exercicio 21 Revisao

            double[] vet = new double[10];
            double media=0.0, maior=0.0, menor=999999, soma=0.0, somaMedia=0.0;

            for (int i = 0; i < 10; i++){
                Console.WriteLine("Digite um numero de alturas: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if(vet[i] > maior){
                    maior = vet[i];
                } else if(vet[i] < menor){
                    menor = vet[i];
                }

                soma ++;
                somaMedia = somaMedia + vet[i];
                media = somaMedia/soma;
            }

            Console.WriteLine("Maior numero do vetor:{0}", maior);
            Console.WriteLine("Menor numero do vetor:{0}", menor);
            Console.WriteLine("Media numero do vetor:{0}", media);
            
        }

    }
}


