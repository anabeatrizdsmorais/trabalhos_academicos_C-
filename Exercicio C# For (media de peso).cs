using System;

namespace prog_estruturad
{
    class Exercicio17Revisao
    {
        static void Main(string[] args){
            // Exercicio 17 Revisao

            int idade, x=0, x1=0, x2=0, x3=0;
            float peso, mediaA=0, mediaB=0, mediaC=0, mediaD=0, 
            y=0, y1=0, y2=0, y3=0;

            for (int i = 0; i < 1000; i++){
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Peso: ");
                peso = float.Parse(Console.ReadLine());
                
                if(idade >= 1 && idade <= 10){
                    x++;
                    y += peso;
                    mediaA = y/x;
                } else if(idade >= 11 && idade <=20){
                    x1++;
                    y1 += peso;
                    mediaB = y1/x1;
                } else if(idade >= 21 && idade <=30){
                    x2++;
                    y2 += peso;
                    mediaC = y2/x2;
                } else if(idade > 30){
                    x3++;
                    y3 += peso;
                    mediaD = y3/x3;
                }

            }


                Console.WriteLine("Media do peso de idade entre 1 a 10: {0}", mediaA);
                Console.WriteLine("Media do peso de idade entre 11 a 20: {0}", mediaB);
                Console.WriteLine("Media do peso de idade entre 21 a 30: {0}", mediaC);
                Console.WriteLine("Media do peso de idade maior que 30: {0}", mediaD);
        }

    }
}


