using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, primo;
            Console.WriteLine("\n\n\t***Programa para saber se o numero é primo***");
            Console.WriteLine("\n\nInforme um número inteiro e positivo e tecle <enter>");
            num = int.Parse(Console.ReadLine());
            primo = 0;
            for(i = 1; i <= num; i++) 
            { 
                if (num%i == 0) 
                { 
                    primo = primo + 1; 
                } 
            } 
            if ((primo == 2)||(primo == 1)) 
            { 
                Console.WriteLine("\n\nO numero informado é primo\n"); 
            } 
            else 
            {
                Console.WriteLine("\n\nO numero informado não é primo\n\n"); 
            } 
            Console.ReadKey();
            }
        }
    }

