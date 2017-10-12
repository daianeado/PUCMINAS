using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoDivisores
{
    class Program
    {
        static int divisores(int x) 
        {
            int cont=2;
            for(int divisor = 1; divisor <= x/2; divisor++)
            {
                if(x % divisor == 0)
                {
                    cont++;
                }
            }
            return (cont);
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite um numero");

        }
    }
}
