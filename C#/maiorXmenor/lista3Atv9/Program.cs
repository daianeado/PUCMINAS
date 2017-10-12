using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c, maior=0,menor=0;
            char op;
            do
            {
                Console.WriteLine("\n\n\t***Maior x Menor***");
                Console.WriteLine("\nEntre com um valor\n");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEntre com um valor\n");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEntre com um valor\n");
                c = int.Parse(Console.ReadLine());

                //Inicio condição qual é o maior
                if (a > b && a > c)
                {
                    maior = a;
                }
                else
                {
                    if (b > a && b > c)
                    {
                        maior = b;
                    }
                    else
                    {
                        if (c > b && c > a)
                        {
                            maior = c;
                        }

                    }
                }
                //Fim condição qual é o maior
                //Inicio condição qual é o menor
                if (a < b && a < c)
                {
                    menor = a;
                }
                else
                {
                    if (b < a && b < c)
                    {
                        menor = b;
                    }
                    else
                    {
                        if (c < b && c < a)
                        {
                            menor = c;
                        }
                              
                    }
                }
                //Fim condição qual é o menor
                Console.WriteLine("\nDos numeros digitados:\n" + maior + "é o maior\n" + menor + "é o menor");
                Console.WriteLine("Deseja continuar? S/N");
                op = char.Parse(Console.ReadLine());


            } while (op == 's' || op == 'S');
            Console.ReadKey();
        }
    }
}
