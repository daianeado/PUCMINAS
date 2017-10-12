using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colocarOsNumerosEmOrdemLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double a, b, c;
            Console.WriteLine("\n\t***Programa para colocar os números em ordem.***");
            Console.WriteLine("Digite um número inteiro e positivo e tecle <enter>");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um valor real e tecle <enter>");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um valor real e tecle <enter>");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um valor real e tecle <enter>");
            c = double.Parse(Console.ReadLine());
            //Inicio condição ordem crescente
            if (i == 1)
            {
                if (a < b && a < c && b < c)
                {
                    Console.WriteLine("\n Os valores digitados em ordem crescente é:" + a + "," + b + "," + c);
                }
                else
                {
                    if (a < b && a < c && c < b)
                    {
                        Console.WriteLine("\n Os valores digitados em ordem crescente é:" + a + "," + c + "," + b);
                    }
                    else
                    {
                        if (b < a && b < c && a < c)
                        {
                            Console.WriteLine("\n Os valores digitados em ordem crescente é:" + b + "," + a + "," + c);
                        }
                        else
                        {
                            if (b < a && b < c && c < a)
                            {
                                Console.WriteLine("\n Os valores digitados em ordem crescente é:" + b + "," + c + "," + a);
                            }
                            else
                            {
                                if (c < b && c < a && a < b)
                                {
                                    Console.WriteLine("\n Os valores digitados em ordem crescente é:" + c + "," + a + "," + b);
                                }
                                else
                                {
                                    if (c < b && c < a && b < a)
                                    {
                                        Console.WriteLine("\n Os valores digitados em ordem crescente é:" + c + "," + b + "," + a);
                                    }
                                }
                            }

                        }
                    }
                }
            }//Fim da condição de ordem crescente
            else//Começo da condição de ordem decrescente
            {
                if (i == 2)
                {
                    if (a > b && a > c && b > c)
                    {
                        Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + a + "," + b + "," + c);
                    }
                    else
                    {
                        if (a > b && a > c && c > b)
                        {
                            Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + a + "," + c + "," + b);
                        }
                        else
                        {
                            if (b > a && b > c && a > c)
                            {
                                Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + b + "," + a + "," + c);
                            }
                            else
                            {
                                if (b > a && b > c && c > a)
                                {
                                    Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + b + "," + c + "," + a);
                                }
                                else
                                {
                                    if (c > b && c > a && a > b)
                                    {
                                        Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + c + "," + a + "," + b);
                                    }
                                    else
                                    {
                                        if (c > b && c > a && b > a)
                                        {
                                            Console.WriteLine("\n Os valores digitados em ordem decrescente é:" + c + "," + b + "," + a);
                                        }
                                    }
                                }

                            }
                        }
                    }
                } //Fim da condição de ordem decrescente
                else
                {
                    if (i == 3) 
                    {
                        if (a > b && a > c)
                        {
                            Console.WriteLine("\n" + c + "," + a + "," + b);
                        }
                        else 
                        {
                            if (b > a && b > c)
                            {
                                Console.WriteLine("\n" + c + "," + b + "," + a);
                            }
                            else 
                            {
                                if (c > a && c > b) 
                                {
                                    Console.WriteLine("\n" + a + "," + c + "," + b);

                                }
                            }
                        }
                    }
                }
                
            }
            Console.ReadKey();
        }
     }
}
