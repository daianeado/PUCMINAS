using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv15
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome,nomeMaiorB ="",nomeMaiorA ="";
            double altura,alturaMaiorB=0,alturaMaiorA=0;
            int cont;
            for (cont = 0; cont < 5; cont++) 
            {
                Console.WriteLine("digite seu nome");
                nome = Console.ReadLine();
                Console.WriteLine("digite a altura");
                altura = double.Parse(Console.ReadLine());


                if (alturaMaiorA < alturaMaiorB)
                {
                    alturaMaiorA = altura;
                    nomeMaiorA = nome; 
                }
                else
                {
                    if (altura > alturaMaiorB)
                    {
                        alturaMaiorB = altura;
                        nomeMaiorB = nome;
                    }
                }
            }
            Console.WriteLine("\nAs duas maiores alturas com seus respectivos nomes:\n" + nomeMaiorA + "-" + alturaMaiorA + "\n" + nomeMaiorB + "-" + alturaMaiorB);
            Console.ReadKey();

        }
    }
}
