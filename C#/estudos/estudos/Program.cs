using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    class Program
    {
        static void leVetor(int[] v)
        {
            for (int i = 0; i <= v.Length - 1; i++)
            {
                Console.Write("\n Informe quantas horas trabalhadas no " + (i + 1) + "º dia: ");
                v[i] = int.Parse(Console.ReadLine());
            
            }
        }
        
        static void imprimeVetor(int[] v)
        {
            for (int i = 0; i <= v.Length - 1; i++)
            {
                Console.Write(v[i]);
            }
        }

        static double calculaSal(int[] v)
        {
            double salario = 0, horas = 0;

            for (int i = 0; i <= v.Length - 1; i++)
            {
                horas = horas + v[i];
            }

            salario = horas * 40.5;

            return (salario);
        }

        static double media(double sal, int[] v)
        {
            double med = 0;
            med = sal / 20.0;

            return (med);
        }
        static void Main(string[] args)
        {
            int[] vet;
            vet = new int[3];
            double sal, med;

            Console.Write("\n Entre com a horas trabalhadas em cada dia do mês: ");
            leVetor(vet);

            sal = calculaSal(vet);
            med = media(sal, vet);

            Console.Write("\n O salário referente ao mês é: " + med);
            Console.Write("\n A média referente ao salário do mês é:" + med);

            Console.ReadKey();

        }
    }
}
