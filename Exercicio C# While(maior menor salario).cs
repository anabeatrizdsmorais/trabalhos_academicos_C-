using System;

namespace prog_estruturad
{
    class Exercicio16Revisao
    {
        static void Main(string[] args){
            // Exercicio 16 Revisao

            int idade, maior=0, menor=999, soma=0, i=0;
            string sexo;
            float salario=0, media=0, y=0;

            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());

            while (idade != 0){
                Console.WriteLine("Salario: ");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Gênero (f/m): ");
                sexo = Console.ReadLine();

                i++;
                y += salario;
                media = y/i;

                if(idade > maior){
                    maior = idade;
                } else if(idade < menor){
                    menor = idade;
                }

                if(sexo == "f" && salario <= 1000){
                    soma++;
                }

                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Media de salario:{0} ", media);
            Console.WriteLine("Maior idade:{0} ",maior);
            Console.WriteLine("Menor idade:{0} ",menor);
            Console.WriteLine("Quantidade de mulheres com salario ate 1000:{0} ", soma);
            
        }

    }
}


