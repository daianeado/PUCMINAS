using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplexos
{
    //inicio class complexa
    class Complexa
    {
        //declaração de variáveis privadas
        private double a;
        private double b;
        private double c;
        private double d;
        private double i;

        //construtor
        public Complexa(double a, double b, double c, double d, double i)
        {
            this.a = a;
            this.b = a;
            this.c = c;
            this.d = d;
            this.i = i;
        }

        //metodo para somar os numeros complexos
        public double SomaComplexa(double a, double b, double c, double d, double i)
        {
            double soma;
            soma = (a + b * i) + (c + d * i);//formula matematica (a + bi) + (c + di)
            return soma;
        }

        //metodo para subtrair os numeros complexos
        public double SubtracaoComplexa(double a, double b, double c, double d, double i)
        {
            double sub;
            sub = (a + b * i) - (c - d * i); // formula matemática (a + bi) - (c + di)
            return sub;
        }

        //metodo para calcular a multiplicação dos numeros complexos
        public double MultiplicacaoComplexa(double a, double b, double c, double d, double i)
        {
            double mult;
            mult = ((a * c + b * d) + (a * d + b * c)) * i; //formula matematica (ac + bd) + (ad + bc) * i
            return mult;
        }

        //metotod para calcular a divisao dos numeros complexos
        public double DivisaoComplexa(double a, double b, double c, double d, double i)
        {
            double divi, z1, z2;
            z1 = (a * c + b * d + (c * b - a * d)) * i;//formula matematica z1= ac + bd + (cb - ad)
            z2 = c * c + d * d;//formula matematica z2 = cc + dd
            divi = z1 / z2;
            return divi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeros Complexos";

            //declaração de variaveis
            Console.WriteLine("\n ****Operações com números complexos****");
            double a, b, c, d, i, resp;
            int op;

            //leitura das variaves
            Console.WriteLine("\nInforme um numero real");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme outro numero real");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme outro numero real");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme outro numero real");
            d = double.Parse(Console.ReadLine());

            i = Math.Sqrt(-1);//comando para saber qual a raiz quadrada de -1

            Complexa comp = new Complexa(a, b, c, d, i);//instanciação da class complexa

            //menu de opções para o usuario
            Console.WriteLine("\n O que deseja fazer: \n 1 - Soma \n 2- Subtração \n 3- Multiplicação \n 4- Divisão");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                resp = comp.SomaComplexa(a, b, c, d, i);//chamada do metodo dentro da class
                Console.WriteLine("\nSoma é " + resp);
            }
            else
            {
                if (op == 2)
                {
                    resp = comp.SubtracaoComplexa(a, b, c, d, i);
                    Console.WriteLine("\nSubtração complexa é :" + resp);
                }
                else
                {
                    if (op == 3)
                    {
                        resp = comp.MultiplicacaoComplexa(a, b, c, d, i);
                        Console.WriteLine("\nMultiplicação complexa é :" + resp);
                    }
                    else
                    {
                        if (op == 4)
                        {
                            resp = comp.DivisaoComplexa(a, b, c, d, i);
                            Console.WriteLine("\nDivisão complexa é:" + resp);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}