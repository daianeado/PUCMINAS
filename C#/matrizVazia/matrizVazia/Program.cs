using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_Att11
{
    class Program
    {
        static void imprimeMatriz(char[, ,] m)
        {
            for (int t = 0; t <= m.GetLength(2) - 1; t++)
            {
                Console.Write("\n\n");
                for (int i = 0; i <= m.GetLength(0) - 1; i++)
                {
                    Console.Write("\n|");
                    for (int j = 0; j <= m.GetLength(1) - 1; j++)
                    {
                        Console.Write(m[1, j, t] + " | ");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            char[, ,] matriz;
            matriz = new char[3, 3, 2];
            imprimeMatriz(matriz);
            Console.ReadKey();
        }
    }
}

