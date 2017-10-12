using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String nome;
            char sexo, expServ;
            double media, idade, contM;

            Console.WriteLine("\n\n\t***Pesquisa de emprego***");
            Console.WriteLine("\n Digite seu nome");
            nome = Console.ReadLine();
            contM = 0;
            media = 0;
            while (nome != "fim")
            {

                Console.WriteLine("\n Digite sua idade");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Digite seu sexo:\n F-Feminino\nM-Masculino");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("\n Tem experiencia no serviço?S/N");
                expServ = char.Parse(Console.ReadLine());
                if (sexo == 'm' || sexo == 'M')
                {
                    contM++;
                    if (expServ == 's' || expServ == 'S')
                    {
                        media = media + idade / contM;
                    }
                }

                Console.WriteLine("\n Digite seu nome");
                nome = Console.ReadLine();
            }
            Console.WriteLine("\nDe todos os pesquisados a media da idade dos homens com experiencia é " + media);
            Console.ReadKey();
        }
    }
}
