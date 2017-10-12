using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizPreenche
{
    class Program
    {
        static void preenche(int[, ,] M) 
        {
            int Pagina, Linha, Coluna, Aux=0;
            for (Pagina = 0; Pagina <= 1; Pagina++)
            {
                for (Linha = 0; Linha <= 3; Linha++)
                {
                    for (Coluna = 0; Coluna <= 3; Coluna++)
                    {
                        if (Linha == Coluna)
                        {
                            M[Linha, Coluna, Pagina] = Aux;
                            Aux++;
                        }
                        else
                            M[Linha, Coluna, Pagina] = 1;
                    }
                }
            }
        }

        static void ImprimeMatriz(int[, ,] M) // Esse bloco imprime uma matriz
        {
            int Linha, Coluna, Pagina;

            
            for (Pagina = 0; Pagina <= 1; Pagina++)
            {
                for (Linha = 0; Linha <= 3; Linha++)
                {
                    for (Coluna = 0; Coluna <= 3; Coluna++)
                    {
                    
                        Console.Write("    " + M[Linha, Coluna,Pagina] + "      ");
                        
                    }
                    Console.Write("\n");
                }
                Console.Write("\n\n\n");            
            }
            
        }
        static void Main(string[] args)
        {
            int[, ,] a;
            a = new int[4, 4, 2];
            preenche(a);
            ImprimeMatriz(a);
            Console.ReadKey();
        }
    }
}
