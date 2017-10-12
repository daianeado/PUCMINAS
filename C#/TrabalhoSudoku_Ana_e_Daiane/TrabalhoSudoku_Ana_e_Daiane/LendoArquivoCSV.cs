using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace TrabalhoSudoku_Ana_e_Daiane
{
    class LendoArquivoCSV
    {
        static StreamReader ArquivoLeitura;
        static FileStream ArquivoStream;
        static StreamWriter ArquivoGravacao;

        public void ArquivoAbrindo(string nomeArq)
        {
            ArquivoStream = new FileStream(nomeArq, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            ArquivoLeitura = new StreamReader(ArquivoStream);
            ArquivoGravacao = new StreamWriter(ArquivoStream);

        }

        public int[,] SudokuInicio()
        {
            int[,] M = new int[9, 9];
            string LinhaSudoku;
            string[] X;
            int linha = 0;
            while (!ArquivoLeitura.EndOfStream)
            {
                LinhaSudoku = ArquivoLeitura.ReadLine();
                X = LinhaSudoku.Split(';');
                for (int i = 0; i < 9; i++) { M[linha, i] = int.Parse(X[i]); }
                linha++;
            }


            return M;
        }


        public void ArquivoFechando()
        {
            ArquivoLeitura.Close();
            ArquivoStream.Close();
            ArquivoGravacao.Close();
        }


        public void SudokuGravacao(int[,] Matriz)
        {
            for (int linha = 0; linha < 9; linha++)
            {
                for (int coluna = 0; coluna < 9; coluna++)
                {
                    ArquivoGravacao.Write("\n");
                    ArquivoGravacao.WriteLine(";" + Matriz[linha, coluna]);
                }
            }
        }
    }
}

