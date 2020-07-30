using System;

namespace prog_estruturad
{
    class Exercicio14Revisao
    {
        static void Main(string[] args)
        {
            //Exercicio descobrir mes atraves de um num
            int mes;

            Console.Write("Digite o numero de um mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes){
                
                case 1:
                    Console.Write("JANEIRO");
                    break;
                case 2:
                    Console.Write("FEVEREIRO");
                    break;
                case 3:
                    Console.Write("MARÇO");
                    break;
                case 4: 
                    Console.Write("ABRIL");
                    break;
                case 5:
                    Console.Write("MAIO");
                    break;
                case 6:
                    Console.Write("JUNHO");
                    break;
                case 7: 
                    Console.Write("JULHO");
                    break;
                case 8: 
                    Console.Write("AGOSTO");
                    break;
                case 9:
                    Console.Write("SETEMBRO");
                    break;
                case 10:
                    Console.Write("OUTUBRO");
                    break;
                case 11:
                    Console.Write("NOVEMBRO");
                    break;
                case 12:
                    Console.Write("DEZEMBRO");
                    break;
                default:
                    Console.WriteLine("Numero invalido.");
                    break;
           }   


            // FIM
        

        }
    }
}
