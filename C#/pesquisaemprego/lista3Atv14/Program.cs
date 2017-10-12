using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv14
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade,contF;
            String nome;
            char sexo, expServ;

            Console.WriteLine("\n\n\t***Pesquisa de emprego***");
            Console.WriteLine("\n Digite seu nome");
            nome = Console.ReadLine();
            contF = 0;

            while (nome != "fim") 
            {
                
                Console.WriteLine("\n Digite sua idade");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Digite seu sexo:\n F-Feminino\nM-Masculino");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("\n Tem experiencia no serviço?S/N");
                expServ = char.Parse(Console.ReadLine());
                if (sexo == 'f' || sexo == 'F') 
                {
                    if (expServ == 'n' || expServ == 'N') 
                    {
                        if (idade < 25) 
                        {
                            contF++;
                        }
                    }
                }

                Console.WriteLine("\n Digite seu nome");
                nome = Console.ReadLine();
            }
            Console.WriteLine("\nDe todos os pesquisados " + contF + " são mulheres sem experiencia no serviço e com menos de 25 anos.");
            Console.ReadKey();
        }
    }
}
