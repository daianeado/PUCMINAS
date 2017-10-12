using System;
using System.Collections.Generic;
using System.Text;

namespace Matrizes
{
    class ExemplificaPrograma1
    {
        //Esse bloco preenche uma matriz com os valores do usuário
        static void Leitura(int[,] M) // Apesar de nao ter o ref ele tem que ser passado por referencia pois matriz e vetor só pode ser passado por referencia
        {
            int Linha, Coluna;


            for (Linha = 0; Linha <= 2; Linha++)
            {
                for (Coluna = 0; Coluna <= 2; Coluna++)
                {
                    Console.Write("\nDigitar o elemento M[" + Linha + "," + Coluna + "]: ");
                    M[Linha, Coluna] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ImprimeMatriz(int[,] M) // Esse bloco imprime uma matriz
        {
            int Linha, Coluna;

            for (Linha = 0; Linha <= 2; Linha++)
            {
                for (Coluna = 0; Coluna <= 2; Coluna++)
                    Console.Write("    " + M[Linha, Coluna] + "      ");
                Console.Write("\n");

            }
        }

        static void SomaMatricial(int[,] x, int[,] y, int[,] z)
        {
            int Linha, Coluna;
            for (Linha = 0; Linha <= 2; Linha++)
            {
                for (Coluna = 0; Coluna <= 2; Coluna++)
                {
                    z[Linha, Coluna] = x[Linha, Coluna] + y[Linha, Coluna];
                }
            }
        }

        static void Main(string[] args)
        {
            //Programa para ler  e imprimir uma matriz de inteiros
            //Variáveis
            int[,] A;
            int[,] B;
            int[,] C;
            A = new int[3, 3];
            B = new int[3, 3];
            C = new int[3, 3];

            Console.WriteLine("Entre com os elementos da matriz A:");
            Leitura(A); // No final da execução desse bloco, A estará preenchida

            Console.Clear();

            Console.WriteLine("Entre com os elementos da matriz B:");
            Leitura(B); // No final da execução desse bloco, B estará preenchida
            SomaMatricial(A, B, C); // No final da execução desse bloco, C estará preenchida

            Console.Clear();

            // chamadas dos blocos que imprime a matriz
            Console.WriteLine("\nMatriz A: \n\n");
            ImprimeMatriz(A);
            Console.WriteLine("\nMatriz B: \n\n");
            ImprimeMatriz(B);
            Console.WriteLine("\nMatriz Soma A + B: \n\n");
            ImprimeMatriz(C);
            Console.Write("\nTecle <ENTER> para terminar");
            Console.ReadKey();
        }
    }//fim da classe
}; // fim do pacote
