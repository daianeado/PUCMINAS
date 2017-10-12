using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daianeAparecidaDeOliveira
{
    class Program
    {
        static void Main(string[] args)
        {//Programa somatorio. Daiane A.Oliveira
            double x, s;
            char op;
            int  expo, n,den,cont;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t***Programa somatório***");
                Console.WriteLine("Informe valor do numerador");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o numero de termos");
                n = int.Parse(Console.ReadLine());
                Console.Write("\n S = 100 ");
                for (s = 100, expo = 3, den = 2, cont = 2; cont <= n; expo++, den = den * den, cont++)
                {
                    if (expo % 2 == 0)
                    {
                        s = s - Math.Pow(x, expo) / den;
                        Console.Write(" - ");
                    }
                    else
                    {
                        s = s + Math.Pow(x, expo) / den;
                        Console.Write(" + ");
                    }
                    Console.Write(x + "^" + expo + "/" + den);
                }
                Console.Write(" = " + s);
                Console.WriteLine("\n\n Deseja repetir? S/N");
                op = char.Parse(Console.ReadLine());
            } while (op == 's' || op == 'S');
            Console.WriteLine("Obrigada por utilizar nossos produtos.!");
            Console.ReadKey();

        }
    }
}
