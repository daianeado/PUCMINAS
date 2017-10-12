using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoCpn
{
    class Program
    {
        static int fatorial(int x) 
        {
            int result;
            result = 1;

            if (x == 0)
            {
                return(result);
            }
            else
            {
                for (int termo = 1; termo <= x; termo++)
                {
                    result = result * termo;
                } 
                return (result);
            }
            
        }
        static void Main(string[] args)
        {
            int n, p,cpn;
            Console.WriteLine("\n\n\t***CPN***");
            Console.WriteLine("\nInforme o tamanho do grupo");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o tamanho do agrupamento");
            p = int.Parse(Console.ReadLine());
            while (p > n) 
            {
                Console.WriteLine("ERRO! DIGITE NOVAMENTE!Informe o tamanho do agrupamento");
                p = int.Parse(Console.ReadLine());
            }
            cpn = fatorial(n) / (fatorial(p) * fatorial(n-p));
            Console.Write("\n CPN: " + cpn);
            Console.ReadKey();
        }
    }
}
