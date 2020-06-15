using System;

namespace prog_estruturad
{
    class Exercicio4While
    {
        static void Main(string[] args)
        {
            //Exercicio 4 while
            
            int idade, soma1, soma2, soma3, soma4;
            double peso, somap, media_a, media_b, media_c, media_d;

            /*idade = 0;
            soma1 = 0;
            soma2 = 0;
            soma3 = 0;
            soma4 = 0;
            somap = 0;
            media_a = 0;
            media_b = 0;
            media_c = 0;
            media_d = 0;
*/
            Console.WriteLine("Peso: ");
            peso = double.Parse(Console.ReadLine());

            while(peso != 0){
                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("_____________");

                if(idade >= 0 && idade <= 10){
                    soma1 += 1;
                    somap += peso;
                    media_a = somap/soma1;
                } 
                if(idade >= 11 && idade <= 20){
                    soma2 += 1;
                    somap += peso;
                    media_b = somap/soma2;
                } 
                if(idade >= 21 && idade <= 30){
                    soma3 += 1;
                    somap += peso;
                    media_c = somap/soma3;
                } else{
                    soma4 += 1;
                    somap += peso;
                    media_d = somap/soma4;
                }


                Console.WriteLine("Peso: ");
                peso = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Media de peso 0 a 10 anos:{0}", media_a);
            Console.WriteLine("Media de peso 11 a 20 anos:{0}", media_b);
            Console.WriteLine("Media de peso 21 a 30 anos:{0}", media_c);
            Console.WriteLine("Media de peso mais de 30 anos:{0}", media_d);
            

            // FIM
        

        }
    }
}
