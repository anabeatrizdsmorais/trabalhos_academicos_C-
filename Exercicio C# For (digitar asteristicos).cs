using System;

namespace prog_estruturad
{
    class Exercicio13Revisao
    {
        static void Main(string[] args)
        {
            //Exercicio escrever asteristicos com numero que usuario digitar
            
            int n;
            //char nome; 

            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){
                Console.Write("*");    
            }

            // FIM
        

        }
    }
}
