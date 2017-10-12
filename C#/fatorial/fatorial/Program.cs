using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    class Program
    {
        static int fat(int x) 
        {
            int result = 1;
            if(x==0||x==1)
            {
                return(result);
            }
            else
            {
                for (int termo = 2; termo <= x; termo++) 
                {
                    result = result * termo;
                }
                return (result);
	
            }


        }
        static void Main(string[] args)
        {//não esta funcionando perfeitamente
            int n, z;
            double p;
            Console.WriteLine("\n\n\t***Fatorial***");
            Console.WriteLine("\nDigite um numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um numero");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFatorial de " + n + "=" + fat(n));
            Console.WriteLine("\nFatorial de " + z + "=" + fat(z));
            p = fat(n)*1.0 / fat(z);
            Console.WriteLine("\nResposta da divisão dos fatoriais" + p);
            Console.ReadKey();

        }
    }
}
