using System;

namespace prog_estruturad
{
    class Exercicio2For
    {
        static void Main(string[] args)
        {
            int i, idade, opini, soma_r, soma_o;
            float media, porc, soma, soma2;

            soma_o = 0;
            soma_r = 0;
            soma = 0;
            soma2 = 0;
            media = 0;
            porc = 0;

            for (i=0; i<15; i++){
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Sua opinião sobre o filme >> (3)OTIMO/(2)BOM/(1)REGULAR: ");
                opini = int.Parse(Console.ReadLine());

                switch(opini){
                    case 3:
                        Console.WriteLine("RESPONDEU [OTIMO]");
                        soma_o = soma_o + 1; // quantas pessoas votaram 3 otimo
                        soma = soma + idade;
                        media = soma/soma_o;
                        break;
                    case 2:
                        Console.WriteLine("RESPONDEU [BOM]");
                        soma2 = soma2 + 1;
                        porc = (100*soma2)/15; // porcentagem
                        break;
                    case 1:
                        Console.WriteLine("RESPONDEU [REGULAR]");
                        soma_r = soma_r + 1; // quantas pessoas votaram 1
                        break;
                    default:
                        Console.WriteLine("INVALIDO.");
                        break;

                }
            }
                Console.WriteLine("______________________");
                Console.WriteLine("Media das pessoas que responderam otimo(3):{0}", media);
                Console.WriteLine("Quantidade de pessoas que respondeu regular(1):{0} ", soma_r);
                Console.WriteLine("Porcentagem de pessoas que respondeu bom(2):{0} ", porc);
             // FIM
        

        
        }
    }
}
