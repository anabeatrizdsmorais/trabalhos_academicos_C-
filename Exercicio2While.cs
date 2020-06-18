using System;

namespace prog_estruturad
{
    class Exercicio2While
    {
        static void Main(string[] args)
        {
            //Exercicio 2 while
            
            int idade, maioridade, menoridade, x;
            string sexo;
            float salario, mulher, media, soma;

            maioridade = 0;
            menoridade = 9999;
            soma = 0;
            x = 0;
            media = 0;
            mulher = 0;
            

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            while (idade != 0){
                
                Console.WriteLine("Digite o genero (F/M): ");
                sexo = Console.ReadLine();

                Console.WriteLine("Digite o salario: ");
                salario = int.Parse(Console.ReadLine());
                
                Console.WriteLine("_______________");

                x += 1; //media salario
                soma = soma + salario;
                media = soma / x;

                if(idade > maioridade){
                    maioridade = idade;
                } else if(idade < menoridade){
                    menoridade = idade;
                } else if(salario <= 1000 && sexo == "f"){
                    mulher = mulher + 1;
                }

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine("A media de salario do grupo:{0}", media);
            Console.WriteLine("Maior idade do grupo:{0}", maioridade);
            Console.WriteLine("Menor idade do grupo:{0}", menoridade);
            Console.WriteLine("Quantidade de mulheres com salario até 1.000:{0}", mulher);
            
            // FIM
        

        }
    }
}
