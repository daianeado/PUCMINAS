using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraria
{
    class Curso
    {
        private int alunos;
        private string ImportanciaDoLivro;

        //private double probabilidadecompart;

        public Curso(int alunos, string ImportanciaDoLivro)
        {
            this.alunos = alunos;
            this.ImportanciaDoLivro = ImportanciaDoLivro;
        }
    }

  */3c)*/  class Livro
    {
        private int IdLivro;
        private int quantEstoque;
        private string disponibilidade;
        private int classificacao;
        private int livroUsado;
        private double custo;

        public Livro(int IdLivro, int quantEstoque, string disponibilidade, int classificacao, int livroUsado, double custo)
        {
            this.IdLivro = IdLivro;
            this.quantEstoque = quantEstoque;
            this.disponibilidade = disponibilidade;
            this.classificacao = classificacao;
            this.livroUsado = livroUsado;
            this.custo = custo;

        }

        public string condicaoLivro(string classificacao)
        {

            Console.WriteLine("Indique a classificação do livro:\n 1- Livro-texto adotado para a disciplina \n 2- Livro suplementar recomendado para leitura");
            classificacao = Console.ReadLine();
            if (classificacao == "1")
            {
                classificacao = "Livro-texto adotado para a disciplina";
            }
            else
            {
                if (classificacao == "2")
                {
                    classificacao = "Livro suplementar recomendado para leitura";
                }

            }
            return classificacao;
        }

        public string condicaoLivro(string livroUsado)
        {
            Console.WriteLine("Informe se esse livro esta sendo utilizado a primeira vez esse ano:\n1-Sim\n2-Nao");
            livroUsado = Console.ReadLine();

            if (livroUsado == "1")
            {
                livroUsado = "Esse livro esta sendo usado pela primeira vez esse ano";
            }
            else
            {
                if (livroUsado == "2")
                {
                    livroUsado = "Não é a primeira vez esse ano que este livro esta sendo usado";
                }
            }
            return livroUsado;
        }

        public string dispon(int dispon)
        {
            /*string resp;
            if (dispon == 1)
            {
                resp = "Esta disponivel";
            }
            else
            {
                resp = "Nao esta disponivel";

            }
            return resp;*/

            //colocar o que o metodo vai fazer como comentario isso para todos os metodos
        }

        public int estoque(int qntestoque) 
        {
            int total = 0;
            total += qntestoque;
            return total;
        }

        public double Custo(double Custo) 
        {
            double total = 0;
            total += Custo;
            return total;
        }
    }

    class Livraria
    {
        private int[] LivrosEncomendados;
        private double lucro;

        public Livraria(int[] LivrosEncomendados, double lucro) 
        {
            LivrosEncomendados = new int [20];
            this.lucro = lucro;
        }

        public int[] encomendas(int[] LivrosEncomendados) 
        {
            /*for (int i = 0; i < LivrosEncomendados.Length; i++) 
            {
                Console.
            }
             */

            //falar o que vai fazer 
        }
        public double lucros(double lucro) 
        {
            //falar o que vai fazer
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }



















ushort = numero inteiro sem sinal, positivo, vai de zero ate o num max
7)
class pixel 
{
    private color cor;
    private ushort rotulo;

    public pixel(string cor, int rotulo) 
    {
        this.cor = cor;
        this.rotulo = rotulo;
    }

}

pixel [,] matriz = new pixel [m,n];




4-para cada robo faça


class fabrica
{
    vi
    for (int galp=0;galp <G ;galp++)
    { 
       for(int robo =0; robo<R;robo++)
{
    galpoes[galp]*robos[robo]*montalata();
}
}}

class robo
{
    public void montalata(material(m))
{
    dobrafolha(m);
    encaixabase(m);
    colocatampa(m);
}
}





















5- 
public static void main(string[]as)
{
    int G,R;
    G = int.Parse(Console.ReadLine());
    R = int.Parse(Console.ReadLine());
    fabrica fab = new fabrica (G,R);
fab.funciona();
}
}