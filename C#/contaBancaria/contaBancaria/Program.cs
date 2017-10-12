using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class Titular
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private string sexo;

        //construtor 
        public Titular(string nome, string sobrenome, int idade, string sexo)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.sexo = sexo;
        }

        //método que confere se o primeiro digito é valido,  condição informada pelo link que nos foi passado
        public int primeirodigito(int[] CPF)
        {
            double total = 0, result, result1;
            int i, j;
            for (i = 0, j = 10; i <= 8; i++, j--)
            {
                total += CPF[i] * j;
            }

            result = total % 11;

            if (result < 2)
            {
                return 0;
            }
            else
            {
                result1 = 11 - result;
                return (int)result1;
            }
        }

        //método que confere se o segundo digito é valido
        public int segundodigito(int[] CPF)
        {
            double total = 0, result, result1;
            int i, j;
            for (i = 0, j = 11; i <= 10; i++, j--)
            {
                total += CPF[i] * j;
            }

            result = total % 11;

            if (result < 2)
            {
                return 0;
            }
            else
            {
                result1 = 11 - result;
                return (int)result1;

            }
        }
    } //Fim class Titular

    class Conta
    {
        private double saldo;

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public double Saldo(double saldoatual, double depositos, double saques)//metodo que calcula o saldo da pessoa
        {
            double total;
            total = saldoatual + depositos - saques;
            return total;
        }

        public double limite(double saldoatual, double depositos, double saques)//metodo para saber qual o limite de saque da pessoa
        {
            double total, resp;

            total = saldoatual + depositos;
            if (saques < total)
            {
                resp = 1;
            }
            else
            {
                resp = 2;
            }

            return resp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double const limite = 200;// o limite vai receber um valor fixo qu e vai ser somado com meu saldo e comparado com o valor do saque que eu desejo realizar.
            double saldo = 0, depositos = 0, saques = 0, total = 0;
            string nome, sobrenome, sexo, cpf;
            int idade, op = 0;
            int[] cpff = new int[11];
            char op1;

            //inicialização de variáveis
            Console.WriteLine("\n\t\t***Banco de Todos***\n\n");
            Console.WriteLine("\nDigite seu nome\n");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu sobrenome\n");
            sobrenome = Console.ReadLine();
            Console.WriteLine("\nInforme a sua idade\n");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme seu sexo:\nFeminino\nMasculino\n");
            sexo = Console.ReadLine();
            Console.WriteLine("\nDigite seu CPF\n");
            cpf = Console.ReadLine();
            Console.WriteLine("\nInforme seu saldo anterior por favor: ");
            saldo = double.Parse(Console.ReadLine());

            //instanciação class conta
            Conta C = new Conta(saldo);
            do
            {
                //condição que testa a operação desejada
                Console.WriteLine("\nDigite a operação que seja realizada:\n 1 - Deposito \n 2 - Saque");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("\nInforme o valor a ser depositado:\n");
                    depositos = double.Parse(Console.ReadLine());
                }
                if (op == 2)
                {
                    Console.WriteLine("\nInforme o valor para saque:\n");
                    saques = double.Parse(Console.ReadLine());
                    limite = C.limite(saldo, depositos, saques);
                }

                //vetor cpf
                for (int i = 0; i < cpff.Length - 2; i++)
                {
                    cpff[i] = (int)cpf[i] - (int)'0';
                }

                //instanciação class titular
                Titular T = new Titular(nome, sobrenome, idade, sexo);

                cpff[9] = T.primeirodigito(cpff);//mandando como parametro para o metodo primeiro digito
                cpff[10] = T.segundodigito(cpff);

                total = C.Saldo(saldo, depositos, saques);


                Console.Clear();
                //impressao de variáveis
                Console.WriteLine("\n\t***Banco de todos***");
                Console.WriteLine("\n\t***Dados Pessoais***");
                Console.WriteLine("\n\nNome: " + nome + " " + sobrenome + "\nIdade: " + idade + " anos\nSexo: " + sexo);

                //condição para testar se o cpf digitado é valido ou nao
                if ((int)cpf[9] - (int)'0' == cpff[9] && (int)cpf[10] - (int)'0' == cpff[10]) //professor passou essa logica o (int) antes da variavél converte ela de string para inteiro. 
                {
                    Console.Write("CPF: " + cpf + "\nEsse cpf é válido");
                }
                else
                {
                    Console.Write("CPF: " + cpf + "\nO cpf informado é inválido");
                }

                //impressao dados conta
                Console.WriteLine("\n\t***Dados da conta***");

                if (limite == 1)
                {
                    Console.WriteLine("\n\n\nSaque liberado!");
                }
                else
                {
                    if (limite == 2)
                    {
                        Console.WriteLine("\n\n\nSaque não liberado! Limite estourado, faça um depósito em sua conta para voltar a utilizar esse tipo de serviço");
                    }
                }

                Console.WriteLine("\n Seu saldo atual é:" + total);

                Console.WriteLine("\n Deseja realizar outra operação. S-SIM || N- NÂO");
                op1 = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (op1 == 's' || op1 == 'S');
            Console.ReadKey();
        }
    }
}
