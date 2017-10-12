using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /**
     * Classe base ou superclasse das classes Gerente, Executivo e Tecnico.
     */
    class Funcionario
    {
        private String nome;
        private double salario;

        /**
         * Estes quatro métodos são a lista de serviços da classe, 
         * também chamados, coletivamente, de interface da classe.
         */
        public Funcionario(String umNome) { nome = umNome; }

        /** métodos de acesso aos membros de dados.
           */
        public virtual double getSalario() { return salario; }
        public void setSalario(double umSalario) { this.salario = umSalario; }
        public String getNome() { return nome; }



        public void imprime(Funcionario f)
        {


            {
                Console.WriteLine("\nEste funcionário é um " +f.GetType().Name);
                Console.WriteLine("Nome: " + f.getNome());
                Console.WriteLine("Salário: " + f.getSalario());
                if (f is Gerente)
                    Console.WriteLine("Bonus: " + ((Gerente)f).getBonus());

                if (f is Tecnico)
                {
                    Console.WriteLine(((Tecnico)f).getAreaAtuacao());
                }

                if (f is Executivo)
                {
                    string[] linguas = ((Executivo)f).getIdiomas();

                    for (int j = 0; j < linguas.Length; j++)
                    {
                        Console.WriteLine(linguas[j]);
                    }
                }
            }
        }

        /**
         * Classe herdeira de Funcionario.
         * Todo gerente É UM funcionário com algo a mais. Neste caso,
         * o "algo a mais" é o membro de dados bonus e os métodos de
         * acesso a ele.
         */
        class Gerente : Funcionario
        {
            private double bonus;

            /**
             * this, aqui, é utilizado para chamar outra construtora da
             * classe Gerente.
             */
            public Gerente(String nome)
                : this(nome, 1000.0)
            {

            }

            /**
             * base, aqui, é utilizada para chamar a construtora da superclasse.
             */
            public Gerente(String nome, double bonus)
                : base(nome)
            {
                this.bonus = bonus;
            }

            /**
             * new, neste contexto, indica que o método é uma redefinição de
             * método homônimo (de mesmo nome) da classe Funcionario.
             * base.getSalario() chama o método herdado de Funcionario, a classe base de Gerente.
             */
            override public double getSalario() { Console.WriteLine("getsalario de Gerente!!!!"); return base.getSalario() + bonus; }
            public void setBonus(double bonus) { }
            public double getBonus() { return bonus; }
        }

        /**
         * Todo executivo é um gerente que deve dominar um conjunto de idiomas...
         */
        class Executivo : Gerente
        {
            private String[] idiomas;

            public Executivo(String umNome) : base(umNome) { }
            public void setIdiomas(String[] idiomas) { this.idiomas = idiomas; }
            public String[] getIdiomas() { return idiomas; }
        }

        /**
         * Todo técnico é um funcionário com área de atuação específica...
         */
        class Tecnico : Funcionario
        {
            private String areaAtuacao;

            public Tecnico(String nome) : base(nome) { }
            public void setAreaAtuacao(string areaAtuacao) { this.areaAtuacao = areaAtuacao; }
            public String getAreaAtuacao() { return areaAtuacao; }
        }



        class Program
        {

            /**
             * Método que cria uma lista de funcionários aleatoriamente...
             */
            static Funcionario[] criaFuncionários(int quantos)
            {
                Funcionario[] funcs = new Funcionario[quantos];
                Random gerador = new Random();

                for (int i = 0; i < funcs.Length; i++)
                {
                    int qual = gerador.Next(5);

                    switch (qual)
                    {
                        case 0:
                        case 1:
                        case 2: Tecnico t = new Tecnico("Técnico " + (i + 1));
                            t.setAreaAtuacao("Area " + (i + 1));
                            t.setSalario(1000.0 * (i + 1));
                            funcs[i] = t;
                            break;
                        case 3: Gerente g = new Gerente("Gerente " + (i + 1));
                            g.setSalario(1000.0 * (i + 1));
                            funcs[i] = g;
                            g.setBonus(2000.0);
                            break;
                        case 4: Executivo e = new Executivo("Executivo " + (i + 1));
                            e.setSalario(1000.0 * (i + 1));
                            e.setBonus(4000.0);
                            string[] linguas = { "Espanhol", "Ingles" };
                            e.setIdiomas(linguas);
                            funcs[i] = e;
                            break;
                    }  // switch
                }  // for

                return funcs;
            }

            static void Main(string[] args)
            {

                int NumFuncs = 8;
                Funcionario[] funcionarios = criaFuncionários(NumFuncs);




                Funcionario maria = new Executivo("Maria");
                maria.setSalario(2000);
                maria.imprime(maria);







                /**
                 * Esta chamada é válida, pois o TIPO ESTÁTICO (tipo declarado) de f1 é Funcio-nario e
                 * o método getNome foi declarado em Funcionario.
                 */


                /**
                 * Chamar f1.setAreaAtuacao("Suporte") é um erro, pois o 
                 * TIPO DINÂMICO (tipo do objeto referenciado) de f1 é Tecnico,
                 * mas o tipo estático é Funcionário e setAreaAtuacao NÃO existe em Funcionario.
                 * Assim, é preciso "forçar a barra" fazendo a "coerção" ou "type casting" ou "casting".
                 */
                // Casting para o tipo Tecnico, que é o tipo dinâmico referenciado por f1...


                Console.ReadKey();
            }
        }

    }
}


