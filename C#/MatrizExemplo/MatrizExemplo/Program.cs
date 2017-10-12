using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExemplo
{
    class Program
    {
        static void LeMatriz(int[,] Mat)
        {
            int Linha, Coluna;
            for (Linha = 0; Linha < Mat.GetLength(0); Linha++) 
            {
                for (Coluna = 0; Coluna < Mat.GetLength(1); Coluna++) 
                {
                    Console.Write("\nM["+Linha+Coluna+"]:");
                    Mat[Linha, Coluna] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void CalculaVetor(int[,] Mat, int[] vet) 
        {
            int Linha, Coluna;
            for (Linha = 0; Linha <= Mat.GetLength(0)-1; Linha++)
            {
                for (Coluna = 0; Coluna <= Mat.GetLength(1)-1; Coluna++)
                {
                    vet[Linha] += Mat[Linha, Coluna];
                }
            }
        }

        static void IniciaVetor(int[] v) 
        {
            for (int i = 0; i <= v.Length - 1; i++) 
            {
                v[i] = 0;
            }
        }

        static void imprimeVetor(int[] v) // Bloco que imprime vetor
        {
            int i;
            for (i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            int[]  vet;
            a = new int[5, 5];
            vet = new int [5];

            LeMatriz(a);
            CalculaVetor(a, vet);

            
            imprimeVetor(vet);
            Console.ReadKey();
        }

    }
}
