using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t***MENU PRINCIPAL***");
            int op;
            Console.WriteLine("\nEscolha uma opção e tecle ENTER");
            Console.Write("\n  0 – para terminar o programa");
            Console.Write("\n  1 – para executar o programa de Palimetro");
            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
            Console.Write("\n  3 – para executar o programa de Conversão Binária");
            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
            op = int.Parse(Console.ReadLine());

            while (op != 0)
            {
                switch (op)
                {
                    case 0:
                        break;
                    case 1: Console.WriteLine("\n\n\n\t***Programa para verificar se o valor é palimetro.***");
                            int num1, part1, part2;
                            num1 = 1000;
                            while (num1 < 9999)
                            {
                                if (num1 >= 1000 && num1 < 9999)
                                {
                                    part1 = num1 / 100;//Atribuição de valor a variavel 
                                    part2 = num1 % 100;// Atribuição de valor a variavel
                                    if (Math.Pow(part1 + part2, 2) == num1) //Condicional que testa se o número é palimetro
                                    {
                                        Console.WriteLine("\n" + num1 + " É palimetro.");
                                    }
                                }
                                else 
                                { 
                                    Console.WriteLine("Erro! Reinicie o programa por favor.");
                                }
                                num1++;
                            }
                            
                            Console.WriteLine("\n\n\n\nEscolha uma opção e tecle ENTER");
                            Console.Write("\n  0 – para terminar o programa");
                            Console.Write("\n  1 – para executar o programa de Palimetro");
                            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
                            Console.Write("\n  3 – para executar o programa de Conversão Binária");
                            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
                            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
                            op = int.Parse(Console.ReadLine());

                        break;
                    case 2: Console.WriteLine("\n\n\n\t***Programa para descobrir de 100 números quais são perfeitos***");
                            int cont;
                            for (cont = 1; cont <= 100; cont++)//O laço irá pegar os 100 primeiros numeros inteiros positivos
                            {
                                int divisor = 0, x;
                                for (x = 1; x <= cont; x++)//Outro laço que identifica os divisores e os soma
                                {
                                    if (cont % x == 0 && x != cont)//se a divisão for exata e o divisor for diferente do numero informado soma o divisor atual com o novo divisor
                                    {
                                        divisor = divisor + x;
                                    }
                                }

                                if (divisor == cont)// Caso a soma dos divisores forem igual ao numero informado então ele é perfeito
                                {
                                    Console.WriteLine("\tO Numero " + cont + " é um número perfeito!");
                                }
                            }

                            Console.WriteLine("\n\n\n\nEscolha uma opção e tecle ENTER");
                            Console.Write("\n  0 – para terminar o programa");
                            Console.Write("\n  1 – para executar o programa de Palimetro");
                            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
                            Console.Write("\n  3 – para executar o programa de Conversão Binária");
                            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
                            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
                            op = int.Parse(Console.ReadLine());

                        break;
                    case 3: Console.WriteLine("\n\n\n\t\t***Programa para converter para binário***");
                            int numMax, numDigitado;/*nuMax é o valor de 2^17=131072. 
                                     * Não sei qual é o quantidade de algarismos que ele consegue converter,
                                       gira em torno de 5 a 6..
                                     * numDigitado, é o valor que o usuario digitar.
                                     * binario é o número a ser exibido na tela*/
                            string binario;
                            Console.Write("\nDigite o número em decimal: ");
                            numDigitado = int.Parse(Console.ReadLine());
                            numMax = 131072;
                            binario = "";
                            Console.Write("\nO numero:" + numDigitado);
                            while (numDigitado != 0)//se o número for 0 então finaliza a repetição
                            {
                                if (numDigitado - numMax >= 0)//os primeiros digitos do binario sao os que possuem mais valor. Então essa estrutura vai adicionando "1"s caso possa utilizar o valor e '0's caso não
                                {
                                    numDigitado = numDigitado - numMax;
                                    binario = binario + "1";
                                }
                                else
                                {
                                    binario = binario + "0";
     
                                }
                                numMax = numMax / 2;
                            }
                            Console.Write(" em valor em binário é: " + binario);
                       
                            Console.WriteLine("\n\n\nEscolha uma opção e tecle ENTER");
                            Console.Write("\n  0 – para terminar o programa");
                            Console.Write("\n  1 – para executar o programa de Palimetro");
                            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
                            Console.Write("\n  3 – para executar o programa de Conversão Binária");
                            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
                            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
                            op = int.Parse(Console.ReadLine());
                        break;

                    case 4: Console.WriteLine("\n\n\n\t***Programa para descobrir quais números de 0 a 5000 são Capicua***");
                            int i;
                            i = 1;
                            while (i >= 1 && i <= 99 )//O laço ira testar os 99 primeiros numeros 
                            {
                                if ((i / 10) == (i % 10))//Condição para saber se o numero é capicua
                                {
                                    Console.WriteLine("\nO numero " + i + " é Capicua");
                                }
                                i++;
                            }
                            i = 100;
                            while( i >= 100 && i <= 999)//O laço ira testar os numeros de 100 a 999  
                            {
                                if ((i / 100) == (i % 10))//Condição para saber se o numero é capicua
                                {
                                    Console.WriteLine("\nO numero " + i + " é Capicua");
                                }
                                i++;
                            }

                            i = 1000;
                            while (i >= 1000 && i <= 5000)//O laço ira testar os números de 1000 a 5000              
                            {
                                if ((i / 100) == (i % 10) * 10 + (i % 100) / 10) //Condição para saber se o numero é capicua
                                {
                                    Console.WriteLine("\nO número " + i + " é Capicua");
                                }
                                i++;
                            }
                            Console.WriteLine("\n\n\n\nEscolha uma opção e tecle ENTER");
                            Console.Write("\n  0 – para terminar o programa");
                            Console.Write("\n  1 – para executar o programa de Palimetro");
                            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
                            Console.Write("\n  3 – para executar o programa de Conversão Binária");
                            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
                            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
                            op = int.Parse(Console.ReadLine());

                        break;
                    case 5: Console.WriteLine("\n\n\t***Programa para testar a conjectura de Goldbach***");
                            int j, num2, p1 = 0, p2, a;
                            bool sair = false;
                            Console.WriteLine("Digite um numero inteiro e tecle ENTER");
                            num2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (num2 % 2 == 0) //Condição que testa se o numero informado é par, se verdadeira executará o codigo para testar a teoria de Goldbach
                            {
                                p1 = a = num2;
                                while (!sair)
                                {
                                    p1--;
                                    a = p1;
                                    sair = true;

                                    for (j = 2; j < a; j++)
                                    {
                                        if (a % j == 0)
                                        {
                                             a = 0;
                                            sair = false;
                                        }
                                    }
                                }
                            p2 = num2 - p1;
                            Console.WriteLine("\n\n\nO número informado se enquadra na conjectura de Goldbach.\n A soma de " + p1 + " + " + p2 + " = " + num2);
                            }
                            else
                            {
                           
                                Console.WriteLine("O numero informado não se enquadra na conjectura de Goldbach.");
                                sair = true;
                            }
                            Console.WriteLine("\n\n\n\nEscolha uma opção e tecle ENTER");
                            Console.Write("\n  0 – para terminar o programa");
                            Console.Write("\n  1 – para executar o programa de Palimetro");
                            Console.Write("\n  2 – para executar o programa de Números Perfeitos");
                            Console.Write("\n  3 – para executar o programa de Conversão Binária");
                            Console.Write("\n  4 – para executar o programa para Indentificar Números Capicuas");
                            Console.Write("\n  5 – para executar o programa de Conjectura de Goldbach:    ");
                            op = int.Parse(Console.ReadLine());
                        break;
                }
            }



        }
    }
}


