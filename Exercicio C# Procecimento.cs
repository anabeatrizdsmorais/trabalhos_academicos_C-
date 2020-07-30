using System;

namespace prog_estruturad
{
    class Exercicio18Reivsao
    {
        static void Main(string[] args)
        {
            //Exercicio 18 revisao
            int num;

            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            compare(num);

            // FIM
        

        }

        static void compare(int n){
            
            if(n%2 == 0){
                Console.WriteLine("PAR");
            } else{   
                Console.WriteLine("IMPAR");
            }
        }
    }
}
