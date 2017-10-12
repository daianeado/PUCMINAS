using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorProva
{
    class Program
    {
        static void inverte(char[] x, char[] y) 
        {
            int aux = x.Length - 1;
            for (int i = 0; i <= x.Length - 1; i++) 
            {
                x[i] = y[aux];
                aux--;
            }
        }

        static void leVetor(int[] v) // Bloco que lê vetor
        {
            int i;
            Console.Clear();

            for (i = 0; i < v.Length; i++)
            {
                Console.Write("\n\nDigitar o " + (i + 1) + "º Inteiro: ");
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        static void imprimeVetor(int[] v) // Bloco que imprime vetor
        {
            int i;
            for (i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            char[] vet;
            vet = new char[5];
            leVetor(vet);
            inverte(vet);

        }
    }
}
