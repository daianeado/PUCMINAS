using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoEProcedimentoSoma
{
    class Program
    {
        static int soma(int x, int y) 
        {
            int s;
            s = x + y;
            return (s);
        }

        static void adicao(int x, int y, ref int r) 
        {
            r = x + y;
        }
        static void Main(string[] args)
        {
            int a, b, result, result1 = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = soma(a, b);
            Console.WriteLine(result);
            adicao(a, b, ref result1);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
