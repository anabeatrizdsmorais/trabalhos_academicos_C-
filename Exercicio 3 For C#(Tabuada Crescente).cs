using System;

namespace prog_estruturad
{
    class Exercicio3For
    {
        static void Main(string[] args)
        {
            int i, n;
            double r;
            
            n = 0;
            r = 0;

            Console.Write("Digite um numero para a tabuada: ");
            n = int.Parse(Console.ReadLine());
                
            Console.WriteLine("**SOMA**\n");
            for(i=0; i<11; i++){
                
                //i = i + 1; 
                //s = s + 1;
                r = n + i;

                Console.Write(" " +n+ " + " +i+ " = ");
                //Console.Write("{0} + ", n);
                //Console.Write("{0} = ", i);
                Console.WriteLine("{0}", r);
                
            }
            Console.WriteLine("_________________");
            Console.WriteLine("**MULTIPLICAÇÃO**\n\n");
            for(i=0;i<11;i++){
                 r = n * i;
                Console.Write(" " +n+ " * " +i+ " = ");
                //Console.Write("{0} * ", n);
                //Console.Write("{0} = ", i);
                Console.WriteLine("{0}", r);
                
            }
            Console.WriteLine("_________________");
            Console.WriteLine("**DIVISÃO**\n\n");
            
            for(i=1;i<11;i++){
                r = n / i;
                
                Console.Write(" " +n+ " / " +i+ " = ");
                //Console.Write("{0} / ", n);
                //Console.Write("{0} = ", i);
                Console.WriteLine("{0}", r);
            }
            
            Console.WriteLine("_________________");
            Console.WriteLine("**SUBTRAÇÃO**\n\n");
            
            for(i=0;i<11;i++){
                r = n - i;

                Console.Write(" " +n+ " - " +i+ " = ");
                //Console.Write("{0} - ", n);
                //Console.Write("{0} = ", i);
                Console.WriteLine("{0}", r);

            }

        }
    }
}
