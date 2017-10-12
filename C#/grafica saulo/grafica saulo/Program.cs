using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtoras_classes_NF
{
    class NotaFiscal
    {
        private string numero;

        public NotaFiscal(string numero)
        {
            this.numero = numero;
            Console.WriteLine("Construtora de NotaFiscal. Nota: " + numero);
        }

        public string getNumero()
        {
            return numero;
        }
    }


    class Impressora
    {
        private int id;
        private string modo; // "pronta", "não-pronta", "desligada" <-- TO BE DONE!

        public Impressora(int identificador)
        {
            id = identificador;
            Console.Out.WriteLine("Criei impressora número: " + this.id);
        }

        public void imprimeNotaFiscal(NotaFiscal nf)
        {
            Console.WriteLine("Impressora número " + this.id);
            Console.WriteLine("Impressa nota número: " + nf.getNumero());
        }

        public override String ToString()
        {
            return this.id + "";
        }

    }


    class LinhaDeImpressao
    {
        private int numero; // número desta linha de impressão
        private Impressora[] impressoras;

        public LinhaDeImpressao(int numero, int numImpressoras, int[] identificadores)
        {
            this.numero = numero;
            this.impressoras = new Impressora[numImpressoras];

            // neste ponto só existem referências nulas no vetor...
            //foreach(Impressora imp in this.impressoras)
            for (int i = 0; i < this.impressoras.Length; i++)
                if (this.impressoras[i] == null)
                    Console.WriteLine("Impressora não inicializada! " + this.impressoras[i]);

            // agora os objetos referenciados pelos elementos do vetor
            // são criados
            for (int i = 0; i < this.impressoras.Length; i++)
            {
                this.impressoras[i] = new Impressora(identificadores[i]);
            }

            Console.WriteLine("\nLinha de impressão número " + this.numero);
            Console.WriteLine("Impressoras:\n");

            // neste ponto os objetos já foram criados...
            // o método ToString é chamado automaticamente...
            // o foreach trabalha sobre o vetor da primeira posição até a última nessa ordem
            foreach (Impressora imp in this.impressoras)
                Console.WriteLine("Impressora: " + imp);

        }
    }

    /**
     * Classe que representa uma gráfica hipotética qualquer.
     * Uma gráfica é composta por um certo número de "linhas de impressão".
     * Cada linha de impressão é composta por um determinado número de impressoras.
     */
    class Grafica
    {

        /**
         * Representa vários conjuntos de impressoras. Cada conjunto é uma linha de impressão.
         */
        private LinhaDeImpressao[] linhas;

        /**
         * Cria uma gráfica com identificadores de impressora sequenciais
         * e com mesmo número de impressoras por linha.
         * 
         * O SEGUINTE COMENTÁRIO SERIA DESNECESSÁRIO SE O NOME DO 
         * PARÂMETRO FOSSE numImpressorasPorLinha, POR EXEMPLO.
         * 
         * O parâmetro numImpressoras indica o número de impressoras
         * em cada linha de impressão, ou seja, é o mesmo para todas as linhas.
         */
        public Grafica(int numLinhasDeImpressao, int numImpressoras)
        {

            // cria os identificadores sequenciais
            int[][] ids = new int[numLinhasDeImpressao][];
            int identificador = 0;  // identificador inicial é 1
            for (int linha = 0; linha < ids.Length; linha++)
            {
                ids[linha] = new int[numImpressoras];
                for (int imp = 0; imp < ids[linha].Length; imp++)
                    ids[linha][imp] = ++identificador;
            }

            // cria as linhas de impressão
            this.linhas = new LinhaDeImpressao[numLinhasDeImpressao];
            for (int linha = 0; linha < this.linhas.Length; linha++)
            {
                Console.WriteLine("\nCriando a linha de impressão " + (linha + 1) + "\n");
                // cria o objeto LinhaDeImpressao
                this.linhas[linha] = new LinhaDeImpressao(linha + 1, numImpressoras, ids[linha]);
            }

        }

        /**
         * Cria uma gráfica com identificadores de impressora sequenciais
         * e com número de impressoras por linha QUE PODE SER DIFERENTE.
         *          * 
         * O parâmetro numImpressoras indica o número de impressoras
         * em cada linha de impressão, ou seja, é o mesmo para todas as linhas.
         */
        public Grafica(int numLinhasDeImpressao, int[] numImpressorasPorLinha)
        {

            // cria os identificadores sequenciais
            int[][] ids = new int[numLinhasDeImpressao][];
            int identificador = 0;  // identificador inicial é 1
            for (int linha = 0; linha < ids.Length; linha++)
            {
                ids[linha] = new int[numImpressorasPorLinha[linha]];
                for (int imp = 0; imp < ids[linha].Length; imp++)
                    ids[linha][imp] = ++identificador;
            }

            // cria as linhas de impressão
            this.linhas = new LinhaDeImpressao[numLinhasDeImpressao];
            for (int linha = 0; linha < this.linhas.Length; linha++)
            {
                Console.WriteLine("\nCriando a linha de impressão " + (linha + 1) + "\n");
                // cria o objeto LinhaDeImpressao
                this.linhas[linha] = new LinhaDeImpressao(linha + 1, numImpressorasPorLinha[linha], ids[linha]);
            }

        }

        /**
         * Cria uma gráfica recebendo os identificadores de impressoras
         * Por que uma matriz irregular?
         */
        public Grafica(int[][] idsImpressoras)
        {
            //                              <-- TO BE DONE
            // DESAFIO: crédito extra!
        }

        /**
         * Faz a gráfica funcionar, ou seja, as impressoras devem ser
         * inicializadas e entrar em modo "pronto" ("ready") para receber os trabalhos
         * a serem impressos.
         */
        public void Funciona()
        {
            //                              <-- TO BE DONE
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Grafica graf1 = new Grafica(2, 3);
            //                              <-- TO BE DONE

            Console.ReadKey();
        }
    }
}