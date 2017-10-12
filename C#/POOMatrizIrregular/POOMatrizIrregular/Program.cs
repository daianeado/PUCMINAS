using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOMatrizIrregular
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Mt = new int[4][];
            int aux, aux2;

            Mt[0] = new int[3];
            Mt[1] = new int[1];
            Mt[2] = new int[2];
            Mt[3] = new int[5];

            for (int i = 0; i < Mt.Length; i++)
            {
                for (int j = 0; j < Mt[i].Length; j++)
                {
                    Mt[i][j] = j + 1;
                }
            }

            Console.WriteLine("Antes: ");

            for (int i = 0; i < Mt.Length; i++)
            {
                for (int j = 0; j < Mt[i].Length; j++)
                {
                    Console.Write(Mt[i][j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("informe quantas posicoes deseja mover");
            int p = int.Parse(Console.ReadLine());

            
                aux = Mt[i][Mt[i].Length - 1];
                for (int i = 0; i < Mt.Length; i++)
                {
                    

                    for (int j = 0; j < Mt[i].Length; j++)
                    {
                        aux2 = Mt[i][j];
                        Mt[i][j] = aux;
                        aux = aux2;
                    }
                }
            

            Console.WriteLine("Depois: ");

            for (int i = 0; i < Mt.Length; i++)
            {
                for (int j = 0; j < Mt[i].Length; j++)
                {
                    Console.Write(Mt[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
