using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePlacas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Placa de Veículo";
            Console.WriteLine("\n\t*** Gerador de placa de veículo ***");

            // Declaração de variáveis
            char l1, l2, l3;
            int digitos, num1, num2, num3, num4;

            //Inicialização das variáveis
            Console.WriteLine("\n\nInforme a 1ª letra da placa");
            l1 = char.Parse(Console.ReadLine());
            Console.WriteLine("\n\nInforme a 2ª letra da placa");
            l2 = char.Parse(Console.ReadLine());
            Console.WriteLine("\n\nInforme a 3ª letra da placa");
            l3 = char.Parse(Console.ReadLine());
            Console.WriteLine("\n\nInforme os digitos da placa");
            digitos = int.Parse(Console.ReadLine());

            while (digitos < 0 || digitos > 9999)//Condição que testa se o numero informado é valido.
            {
                Console.WriteLine("ERRO! Número invalido informe outro por favor");
                digitos = int.Parse(Console.ReadLine());
            }

            /*Condição para separar os numeros cada variavel ira pegar um numero de cada vez dos quatro numeros informados.
            ex.: do numero 3456, a variavel num1 recebera o numero 3, num2 recebera 4, num3 recebera 5 e num4 receberá 6. 
             É possivel observar que ao aumentar a posição do numero a conta aumenta junto.
             na variavel num1 os digitos informados sao dividos por 1000 pois sao quatro numeros, por exemplo se os digitos forem 9999 quando dividirmos
             esse numero por 1000 iremos pegar a unidade milhar dele, em seguida a centena, a dezena e por ultimo a unidade. Dessa maneira desmenbramos 
             os 4 digitos em unidades separadas*/
            num1 = digitos / 1000;
            num2 = digitos / 100 - num1 * 10;
            num3 = digitos / 10 - num1 * 100 - num2 * 10;
            num4 = digitos / 1 - num1 * 1000 - num2 * 100 - num3 * 10;

            //como estamos mudando os digitos da direita para esquerda o primeiro numero que deve ser alterado é o quarto. 
            num4 = num4 + 1;

            if (num4 == 10) //Quando o ultimo numero for 10  o ultimo algarismo zera e o seguinte acrescenta um  
            {
                num4 = 0;
                num3 = num3 + 1;
            }

            if (num3 == 10)
            {
                num3 = 0;
                num2 = num2 + 1;
            }

            if (num2 == 10)
            {
                num2 = 0;
                num1 = num1 + 1;
            }

            if (num1 == 10) //Quando o ultimo algarismo da direita para esquerda for igual a 10 ele ira zerar e alterar a letra da placa
            {
                num1 = 0;

                if (l3 < 'z' || l3 < 'Z')//se a primeira letra da direita p esquerda for menor que a letra 'z' ela ira aumentar. EX. se for 'j' passara a ser 'K'
                {
                    l3++;
                }
                else
                {
                    if (l3 == 'z' || l3 == 'Z')//ja nessa condição comparamos se a primeira letra da direita para esquerda for igual a 'z' ela passara a ser 'a' 
                    {
                        l3 = 'a';
                        if (l2 < 'z' || l2 < 'Z')
                        {
                            l2++;
                        }
                        else
                        {
                            if (l2 == 'z' || l2 == 'Z')
                            {
                                l2 = 'a';
                                if (l1 < 'z' || l1 < 'Z')
                                {
                                    l1++;
                                }
                            }
                        }
                    }
                }
            }
            if (l1 == 'z' || l1 == 'Z') //quando a ultima letra da direita para esquerda for 'z' entao manda a mensagem de que não existe mais placas
            {
                Console.WriteLine("NAO HA MAIS PLACAS!");
            }

            else
            {
                // se nao se enquadrar na condição acima imprimimos os valores gerados. Imprimi uma variavel de cada vez pq antes tava dando erro.

                Console.WriteLine("\n A nova placa gerada a partir da informada é : \n");
                Console.Write(l1);
                Console.Write(l2);
                Console.Write(l3);
                Console.Write(" - ");
                Console.Write(num1);
                Console.Write(num2);
                Console.Write(num3);
                Console.Write(num4);
            }

            Console.ReadKey();
        }


    }
}

