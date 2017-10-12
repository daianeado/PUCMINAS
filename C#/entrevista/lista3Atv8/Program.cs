using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv8
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo, resp;
            int i, contSim, contNao, contF;
            double porc, contM, contM1;
            Console.WriteLine("\n\n\t***Entrevista***");
            contSim = 0;
            contNao = 0;
            contF = 0;
            contM = 0;
            contM1 = 0;
            porc = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe seu sexo:\n F - Feminino\n M - Masculino");
                sexo = char.Parse(Console.ReadLine());
                if (sexo == 'f' || sexo == 'F')
                {
                    Console.WriteLine("Você aprovou esse novo produto:\n S/N");
                    resp = char.Parse(Console.ReadLine());
                    if (resp == 's' || resp == 'S')
                    {
                        contSim++;
                        contF++;
                    }
                    else
                    {
                        if (resp == 'n' || resp == 'N')
                        {
                            contNao++;
                        }
                    }
                }
                else
                {
                    if (sexo == 'm' || sexo == 'M')
                    {
                        contM++;
                        Console.WriteLine("Você aprovou esse novo produto:\n S/N");
                        resp = char.Parse(Console.ReadLine());
                        if (resp == 's' || resp == 'S')
                        {
                            contSim++;
                        }
                        else
                        {
                            if (resp == 'n' || resp == 'N')
                            {
                                contNao++;
                                contM1++;
                            }
                        }
                        porc = contM * contM1 / 100;
                    }
                }
            }
            Console.WriteLine("\n Do total de entrevistados:" + contSim + " responderam sim\n");
            Console.WriteLine(contNao+" responderam não");
            Console.WriteLine(contF + " mulheres responderam sim");
            Console.WriteLine(porc + "% dos homens responderam não");
            Console.ReadKey();
        }
    }
}
