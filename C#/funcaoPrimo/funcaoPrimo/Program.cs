using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoPrimo
{
    class Program
    {
        static bool ehprimo(int x) 
        {
            bool ok = true;
            if (x == 1) 
            {
                ok = false;
                return (ok);
            }
            else
            {
                for (int divisor = 2; divisor <= x / 2; divisor++) 
                {
                    if (x % divisor == 0)
                    {
                        ok = false;
                        break;
                    }
                }
        
                return (ok);
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("\n\n\n\t***Numeros primos***");
            Console.WriteLine("\nDigite um numero");
            num = int.Parse(Console.ReadLine());
            if (ehprimo(num)) 
            {
                Console.WriteLine("\nÉ primo");
            }
            else
            {
                Console.WriteLine("\nNão é primo");
            }
            Console.ReadKey();
        }
    }
}
