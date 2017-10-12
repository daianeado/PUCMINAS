using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    class Program
    {

        static void leVetor(int[] v) // Bloco que lê vetor
        {
            int i;
            Console.Clear();
            Console.WriteLine("\n***** Bloco para ler um vetor de inteiros *****");
            for (i = 0; i <= 9; i++)
            {
                Console.Write("\n\nDigitar o " + (i + 1) + "º Inteiro: ");
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        static void imprimeVetor(int[] v) // Bloco que imprime vetor
        {
            int i;
            Console.Clear();
            Console.WriteLine("\n***** Bloco para imprimir um vetor de inteiros *****\n\nVetor:\n\n ");
            for (i = 0; i <= 9; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            //Programa para ler  e imprimir um vetor de inteiros
            //
            int[] vet;
            vet = new int[10];
            leVetor(vet); //chamada de bloco para leitura do vetor
            imprimeVetor(vet); // chamada de bloco para imprimir
            Console.WriteLine("\n\n\nTecle algo para terminar");
            Console.ReadKey();
        }
    }
}

