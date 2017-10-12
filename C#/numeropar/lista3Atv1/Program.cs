using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, cont1 = 0;
            double val;
            Console.WriteLine("\n\t***Programa para descobrir se o número é par.***");
            while (cont >= 0 && cont <5) {
                Console.WriteLine("Informe um valor e tecle <enter>");
                val = double.Parse(Console.ReadLine());
                if (val % 2 == 0)
                {
                    cont1++;
                    cont++;
                }
                else
                    cont++;
            }
            Console.WriteLine("\nDos numeros informados, " + cont1 + " são pares.");
            Console.ReadKey();
        }
    }
}
