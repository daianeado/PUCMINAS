using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv11
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            int num, situacao, cont, contF, contM;
            contM = 0;
            contF = 0;

            Console.WriteLine("\n\n\t***Lista de quem faltou à prova***");
            Console.WriteLine("\nInforme quantos alunos a turma possui ao todo");
            num = int.Parse(Console.ReadLine());

            for (cont = 1; cont <= num; cont++) 
            {
                Console.WriteLine("\nInforme o sexo do aluno:\nF-Feminino\nM-Masculino");
                sexo = char.Parse(Console.ReadLine());
                if (sexo == 'f' || sexo == 'F') 
                {
                    Console.WriteLine("\nDigite a situação do aluno na prova:\n0-ausente\n1-presente\n");
                        situacao=int.Parse(Console.ReadLine());
                    if(situacao==0)
                    {
                        contF++;
                    }
                }
                else
                {
                       if (sexo == 'm' || sexo == 'M') 
                        {
                            Console.WriteLine("\nDigite a situação do aluno na prova:\n0-ausente\n1-presente\n");
                            situacao = int.Parse(Console.ReadLine());
                            if(situacao == 0)
                             {
                                contM++;
                             }
                        }
                }
            }
            Console.Write(contF + " mulheres estiveram ausentes durante a prova\n" + contM + " homens estiveram ausentes durante a prova");
            Console.ReadKey();
        }
    }
}
