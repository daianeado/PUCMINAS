using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4Atv6
{
    class Program
    {
        static  void triangulo(double cat1,double cat2, ref double hip) 
        {
            double aux;
            hip = ((cat1 * cat1) + (cat2 * cat2));
            
            
        }

        static void cabecalho() 
        {
            Console.WriteLine("Programa para calcular hipotenusa");
        }

        static void Main(string[] args)
        {
            
            double hip =0;
            double cat1, cat2;
            cabecalho();
            Console.WriteLine("Digite o valor do primeiro cateto");
            cat1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo cateto");
            cat2 = double.Parse(Console.ReadLine());
            triangulo(cat1, cat2, ref hip);
            Console.WriteLine("hipotenusa: " + hip);
            Console.ReadKey();
        }
    }
}
