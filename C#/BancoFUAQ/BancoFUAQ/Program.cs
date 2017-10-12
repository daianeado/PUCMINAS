using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFUAQ
{
    class Program
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
            double saldoanterior;
            
            //Construtor
            public Conta(double saldoanterior)
            {
                this.saldoanterior = saldoanterior;
            }

            //Metodo que atualiza o saldo quando a opção deposito é escolhida no main
            public double Deposito(double deposito, double saldoanterior) 
            {
                double saldoatualizado = 0;
                saldoatualizado += saldoanterior + deposito;
                return saldoatualizado;
            }

            //Metodo que atualiza o saldo quando a opção saque é escolhida no main
            public double Saque(double saldoanterior, double saque)
            {
                double saldoatualizado = 0;
                saldoatualizado += saldoanterior - saque;
                return saldoatualizado;
            }
            
            //Metodo que atualiza o saldo quando o programa é rodado mais de uma vez atraves do comando do|while
            public double Saldo(double deposito, double saque, double saldo) 
            {
                double saldoatualizado = 0;
                saldoatualizado += saldoanterior + deposito -saque;
                return saldoatualizado;
            }
        }
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double saldo = 0, depositos = 0, saques = 0, total = 0, resp, tot = 0;
            const double limite = 200;//Variavel constante, seu valor nao sera alterado em hipotese alguma
            string nome, sobrenome, sexo, cpf;
            int idade, op;
            char op1;
            int[] cpff = new int[11];

            //inicialização de variáveis
            Console.WriteLine("\n\t\t***Banco FUAQ***\n\n");
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
                Console.WriteLine("\nDigite a operação que seja realizada:\n 1 - Deposito \n 2 - Saque \n 3 - Dados do Titular \n 0 - Sair");
                op = int.Parse(Console.ReadLine());

                saldo = C.Saldo(depositos, saques, saldo); /*A variavel saldo passa a ter o valor atualizado atraves do metodo Saldo da class Conta,assim quando o loop passar por 
                                                            aqui o valor da variável nao sera o que ela leu e sim o que ela passou a ter apos a realização de alguma operação, 
                                                            Saque/Deposito */

                switch (op)
                {
                    case 0:
                        
                        break;

                    case 1:
                        
                        Console.WriteLine("\nInforme o valor a ser depositado:\n");
                        depositos = double.Parse(Console.ReadLine());

                        total = C.Deposito(depositos, saldo);//Chamada metodo Deposito da class Conta a variavel total recebe ela mesma porque quando o programa voltar nessa opção o que foi guardado nela nao é perdido
                        Console.WriteLine("\n Seu saldo atual é:" + total);
                        
                        break;

                    case 2:

                        Console.WriteLine("\nInforme o valor para saque:\n");
                        saques = double.Parse(Console.ReadLine());

                        resp = saldo + limite;//soma do saldo anterior mais o limite nos gera o saldo que a pessoa pode sacar
                        if (saques <= resp)//condição para o saque ser liberado, o valor inserido pelo usuario deve ser menor ou igual ao seu saldo que foi atualizado na linha anterior
                        {

                            tot = C.Saque(saldo, saques);//Chamada metodo Saque da class Conta a variavel total recebe ela mesma porque quando o programa voltar nessa opção o que foi guardado nela nao é perdido
                            Console.WriteLine("\n SAQUE LIBERADO!!! Seu saldo atual é de R$" + tot);
                        }
                        else
                        {
                            Console.WriteLine("\nSAQUE NÂO LIBERADO!! Você estourou seu limite de R$" + resp + "Faça um novo deposito para poder voltar a utilizar esse serviço!!");
                        }
                        
                        break;

                    case 3:
                    //vetor cpf
                    for (int i = 0; i < cpff.Length - 2; i++)
                    {
                        cpff[i] = (int)cpf[i] - (int)'0';
                    }

                    //instanciação class titular
                    Titular T = new Titular(nome, sobrenome, idade, sexo);

                    cpff[9] = T.primeirodigito(cpff);//mandando como parametro para o metodo primeiro digito
                    cpff[10] = T.segundodigito(cpff);
                        
                    Console.WriteLine("\n\t***Dados do Titular***");
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

                    break;
                }

                Console.WriteLine("\n Deseja realizar outra operação. S-SIM || N- NÂO");
                op1 = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (op1 == 's' || op1 == 'S');

            Console.ReadKey();
        }
    }
}
