﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoSudoku_Ana_e_Daiane;

namespace TrabalhoSudoku_ana_e_daiane
{
    class Matriz
    {
        public void encherMatriz(int[,] M, int x)
        {
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    M[i, j] = x;
                }
            }
        }

        public void inserir(int[,] M1, int[,] M2)
        {
            int lin, col, aux;
            do
            {
                Console.Write("Digite a linha: ");
                lin = int.Parse(Console.ReadLine());
                if (lin < 1 || lin > 9)
                    Console.Write("Valor invalido para a linha\n");
            } while (lin < 1 || lin > 9);

            do
            {
                Console.Write("Digite a coluna: ");
                col = int.Parse(Console.ReadLine());

                if (col < 1 || col > 9)
                {
                    Console.Write("Valor invalido para a coluna\n");
                }
            } while (col < 1 || col > 9);

            do
            {
                Console.Write("Digite o valor: ");
                aux = int.Parse(Console.ReadLine());

                if (aux < 1 || aux > 9)
                    Console.Write("Valor invalido\n");
            } while (aux < 1 || aux > 9);

            M1[lin - 1, col - 1] = aux;
            M2[lin - 1, col - 1] = 0;
        }

        static int verificarLinha(int[,] M, int lin, int col, int teste)
        {
            int j;

            for (j = 0; j < 9; j++)
            {
                if (j != col)
                    if (M[lin, j] == teste)
                        return 0;
            }

            return 1;
        }
        static int verificarColuna(int[,] M, int lin, int col, int teste)
        {
            int i;
            for (i = 0; i < 9; i++)
            {
                if (i != lin)
                    if (M[i, col] == teste)
                        return 0;
            }

            return 1;
        }

        static int verificarBloco(int[,] M, int lin, int col, int teste)
        {
            int i, j;
            for (i = (lin / 3) * 3; i < ((lin / 3) + 1) * 3; i++)
            {
                for (j = (col / 3) * 3; j < ((col / 3) + 1) * 3; j++)
                {
                }
            }
            return 1;
        }

        static int testeLocal(int[,] M, int lin, int col, int teste)
        {
            if (verificarBloco(M, lin, col, teste) == 1 && verificarColuna(M, lin, col, teste) == 1 && verificarLinha(M, lin, col, teste) == 1)
                return 1;
            else
                return 0;
        }

        static int testeTotal(int[,] M)
        {
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (verificarBloco(M, i, j, M[i, j]) == 1 && verificarColuna(M, i, j, M[i, j]) == 1 && verificarLinha(M, i, j, M[i, j]) == 1)
                        return 1;
                }
            }

            return 0;
        }

        public static int[,] SUdokoPronto = new int[9, 9];

        public static void copiar(int[,] M1, int[,] M2)
        {
            int l, c;
            for (l = 0; l < 9; l++)
            {
                for (c = 0; c < 9; c++)
                {
                    M2[l, c] = M1[l, c];
                }
                SUdokoPronto[l, c] = M1[l, c];
            }
        }

        static void resolver(int[,] M1, int[,] M2)
        {
            Random R = new Random();
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (M2[i, j] == 1)
                        M1[i, j] = R.Next(1, 9) % 9 + 1;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
        {
            LendoArquivoCSV  SudokuInicio = new LendoArquivoCSV();
            LendoArquivoCSV sudokupronto = new LendoArquivoCSV();
            Matriz M = new Matriz();
            SudokuInicio.ArquivoAbrindo("Sudoku.csv");
            inserir = M.encherMatriz.InicializarSudoku(); 
            sudokupronto.ArquivoFechando();

            copiar(int[0,0],int[0,0]);
     
            sudokupronto.ArquivoAbrindo("Sudokupronto.csv");
            sudokupronto.SudokuGravacao(SUdokoPronto);
            sudokupronto.ArquivoFechando();
            Console.ReadKey();
        }
        }
    }
}