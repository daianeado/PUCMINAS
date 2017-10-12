using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPF
{
    //Inicio Classe Pessoa
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private string sexo;

        //construtor 
        public Pessoa(string nome, string sobrenome, int idade, string sexo)
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
    } //Fim class pessoa
    

    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            Console.Title = "Dados Pessoais";
            string cpf;
            int[] cpff = new int[11];
            string nome, sobrenome, sexo;
            int idade;

            //inicialização de variáveis
            Console.WriteLine("\n\t\t***Dados Pessoais***\n\n");
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

            //instaciação da classe
            Pessoa P = new Pessoa(nome, sobrenome, idade, sexo);
            
            for (int i = 0; i < cpff.Length - 2; i++)
            {
                cpff[i] = (int)cpf[i] - (int)'0';
            }

            cpff[9] = P.primeirodigito(cpff);//mandando como parametro para o metodo primeiro digito
            cpff[10] = P.segundodigito(cpff);

            Console.Clear();

            //impressao de variáveis
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

            Console.ReadKey();
        }
    }
}
