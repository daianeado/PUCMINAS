using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4Atv10
{
    class Program
    {
        static int maiorA(int a, int b, int c) 
        {
            int x=0;
            if (a > b && a > c)
            {
                x = a;
            }
            else 
            {
                if (b > a && b > c)
                {
                    x = b;
                }
                else 
                {
                    if (c > b && c > a)
                    {
                        x = c;
                    }
                }
            }
            return (x);
        }

        static int menorA(int a, int b, int c)
        {
            int x = 0;
            if (a < b && a < c)
            {
                x = a;
            }
            else
            {
                if (b < a && b < c)
                {
                    x = b;
                }
                else
                {
                    if (c < b && c < a)
                    {
                        x = c;
                    }
                }
            }
            return (x);
        }

        static double mediaA(int a, int b, int c) 
        {
            double media;
            media = ((a + b + c) / 3.0);
            return (media);
        }
        static void Main(string[] args)
        {
            int a, b, c,menor,maior;
            double media;
            Console.WriteLine("digite um numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um numero");
            c = int.Parse(Console.ReadLine());
            maior = maiorA(a, b, c);
            menor = menorA(a, b, c);
            media = mediaA(a, b, c);
            Console.WriteLine("Maior:" + maior + "Menor:" + menor + "media" + media);
            Console.ReadKey();
        }
    }
}
