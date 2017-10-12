using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,cont;
            double  porc4, porc5, porc7, porc12;
            Console.WriteLine("\n\n\t***Pesquisa de canal de TV***");
            Console.WriteLine("\nInforme qual canal de TV você gosta de assistir:\n4\n5\n7\n12\n\n");
            num = int.Parse(Console.ReadLine());
            porc4 = 1;
            porc5 = 1;
            porc7 = 1;
            porc12 = 1;

            for (cont = 1;num != 0;cont++) 
            {
                if (num == 4)
                {
                    porc4 = porc4 * cont / 100;
                }
                else
                {
                    if (num == 5)
                    {
                        porc5 = porc5 * cont / 100;
                    }
                    else
                    {
                        if (num == 7)
                        {
                            porc7 = porc7 * cont / 100;
                        }
                        else
                        {
                            if (num == 12)
                            {
                                porc12 = porc12 * cont / 100;
                            }
                        }
                    }
                }
                Console.WriteLine("\nInforme qual canal de TV você gosta de assistir:\n4\n5\n7\n12\n\n");
                num = int.Parse(Console.ReadLine());     
            }
            Console.WriteLine("Dos entrevistados:\n" + porc4 + "% assistem ao canal 4\n" + porc5 + "% assistem ao canal 5\n" + porc7 + "% assistem ao canal 7\n" + porc12 + "% assistem ao canal 12\n");
            Console.ReadKey();
        }
    }
}
