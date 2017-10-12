using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double altura, pesoIdeal;
            Console.WriteLine("\n\t***Programa para calcular o peso ideal.***");
            Console.WriteLine("\n Informe sua altura e tecle <enter>");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Informe seu sexo:\n F para feminino\n M gtpara masculino e tecle <enter>");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'f' || sexo == 'F') 
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("\nSeu peso ideal é: " + pesoIdeal);
            }else 
              {
                  if (sexo == 'm' || sexo == 'M')
                  {
                      pesoIdeal = (72.7 * altura) - 58;
                      Console.WriteLine("\nSeu peso ideal é: " + pesoIdeal);
                  }
                  else
                  {
                      Console.WriteLine("\n\a\a ERRO!Sexo invalido, reinicie o programa e digite novamente.");
                  }
                    
              }
            Console.ReadKey();
        }
    }
}
