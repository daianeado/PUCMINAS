using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class calculadora
    {

        public calculadora()
        {
        }

        public double Soma(double num1, double num2) //Metodo
        {
            double soma;
            soma = num1 + num2;
            return soma;
        }

        public double Sub(double num1, double num2) //Metodo
        {
            double sub;
            sub = num1 - num2;
            return sub;
        }

        public double Multi(double num1, double num2) //Metodo
        {
            double mult;
            mult = num1 * num2;
            return mult;
        }

        public double Div(double num1, double num2) //Metodo
        {
            double div;
            div = num1 / num2;
            return div;
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            double num1, num2;
            int op;
            Console.WriteLine("Digite um numero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            num2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a opçao desejada: \n 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão");
            op = int.Parse(Console.ReadLine());

            calculadora c = new calculadora();

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.Write(num1 + " + " + num2 + " = " + c.Soma(num1, num2));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write(num1 + " - " + num2 + " = " + c.Sub(num1, num2));
                    break;
                case 3:
                    Console.Clear();
                    Console.Write(num1 + " x " + num2 + " = " + c.Multi(num1, num2));
                    break;
                case 4:
                    Console.Clear();
                    Console.Write(num1 + " / " + num2 + " = " + c.Div(num1, num2));
                    break;

            }

            Console.ReadKey();

        }
    }
}
//falta fazer a condição de algum numero dividido por 0
