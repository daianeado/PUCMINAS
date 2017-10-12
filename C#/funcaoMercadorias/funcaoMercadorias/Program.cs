using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoMercadorias
{
    class Program
    {
        static  double preço5358962452987542986752193757692749879845y(int x)
        {
            double aux;
            aux =( x * 0.20)+ x;
            return (aux);
        }

        static void preço37y(ref double x)
        {
            double aux;
            aux = (x * 0.20) + x;
            x = aux;

        }
        static void Main(string[] args)
        {
            int a,b;
            a = int.Parse(Console.ReadLine());

            Console.Write("{0}", preço5358962452987542986752193757692749879845y(a));
            
            Console.ReadKey();
            
        }
    }
}
