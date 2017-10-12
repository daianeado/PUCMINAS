using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploDeProcedimeto
{
    class Program
    {
        static void troca(ref int x,  int y) 
        {
            int aux;
            aux = x;
            x = y;
            y = aux;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("A = " + a + "\nB = " + b);
            troca(ref a, b);
            Console.WriteLine("A = " + a + "\nB = " + b);
            Console.ReadKey();
        }
    }
}
