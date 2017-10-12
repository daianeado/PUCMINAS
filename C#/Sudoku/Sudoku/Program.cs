using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    class Menu
    {
        private int aux;

        public int Opcao()
        {
            Console.Write("\n1 - Inserir jogo\n2 - Resolver Jogo\n 9 - Sair\nOpcao: ");
            aux = int.Parse(Console.ReadLine());
            return aux;
        }
    }

    class SubMenu : Menu
    {

        private int aux;
        public int Escolha()
        {
            Console.Write("\n1 - Inserir Numero\n2 - Mostrar o jogo\n3 - Apagar jogo\n99 - Para voltar\nOpcao: ");
            aux = int.Parse(Console.ReadLine());
            return aux;
        }

    }

    class Matriz
    {
        static void encherMatriz(int[,] M, int x)
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

        static void mostrar(int[,] M)
        {
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    Console.Write(M[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }

        public void apagar(int[,] M1, int[,] M2)
        {
            encherMatriz(M1, 0);
            encherMatriz(M2, 1);
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
        static void copiar(int[,] M1, int[,] M2)
        {
            int i, j;
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    M2[i, j] = M1[i, j];
        }

        static void resolver(int[,] M1, int[,] M2, int[,] M3)
        {
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (M2[i, j] == 1)
                        M1[i, j] = Random () % 9 + 1;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           ArquivoCSV A = new ArquivoCSV;
            A.ArquivoAbrindo(


        }
    }
}