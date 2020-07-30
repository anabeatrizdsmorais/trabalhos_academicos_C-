using System;

namespace prog_estruturad
{
    class Exercicio19Revisao
    {
        static void Main(string[] args){
            // Exercicio 19 Revisao
            
            float n1, n2;
            string op;

            Console.WriteLine("Digite um numero: ");
            n1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha (+, -, *, /): ");
            op = Console.ReadLine();

            Console.WriteLine(calc(n1,n2,op));
            //fim
        }

        static float calc(float a, float b, string operador){
            
            switch (operador)
            {
                case "+":
                    return a + b;
                    //break;
                case "-":
                    return a - b;
                    //break;
                case "*":
                    return a * b;
                    //break;
                case "/":
                    if (a == 0){
                        return 0;
                    } else {
                        return a / b;
                    }
                    //break;
                default: 
                    return 0;
                    //break;
            }

        }

    }
}


