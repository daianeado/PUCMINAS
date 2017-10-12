using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3Atv6
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, cand1 = 0, cand2 = 0, cand3 = 0,cand4 = 0, branco = 0, nulo = 0;
            Console.WriteLine("\n**Programa para eleição presidencial**");
            Console.WriteLine("\nDigite seu voto:\n1-CANDIDATO 1\n2-CANDIDATO 2\n3-CANDIDATO 3\n4CANDITADO 4\n0-BRANCO");
            op=int.Parse(Console.ReadLine());
            do
            {
                if(op == 1)
                {
                    cand1++;
                }
                else
                {
                    if(op == 2)
                     { 
                       cand2++;
                     }
                    else 
                     {
                        if(op == 3)
                        {
                         cand3++;
                        } 
                        else
                         {
                            if(op == 4)
                            {
                              cand4++;
                            }
                            else
                            {
                                if(op == 0)
                                {
                                    branco++;
                                }
                                else
                                {
                                    if(op < 0 || op > 4)
                                    {
                                        nulo++;
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("\nDigite seu voto:\n1-CANDIDATO 1\n2-CANDIDATO 2\n3-CANDIDATO 3\n4CANDITADO 4\n0-BRANCO");
                op = int.Parse(Console.ReadLine());
              }while(op!=-1);

                //inicio da condição para saber quem venceu
                if(cand1 > cand2 && cand1 > cand3 && cand1 > cand4)
                {
                    Console.WriteLine("\n\aO candidato 1 venceu!");
                }
                else
                {
                    if(cand2 > cand1 && cand2 > cand3 && cand2 > cand4)
                    {
                      Console.WriteLine("\n\aO candidato 2 venceu!");
                    }
                    else
                    {
                        if(cand3 > cand1 && cand3 > cand2 && cand3 > cand4)
                        {
                          Console.WriteLine("\n\aO candidato 3 venceu!");
                        }
                        else
                        {
                            if(cand4 > cand1 && cand4 > cand2 && cand4 > cand3)
                             {
                                Console.WriteLine("\n\aO candidato 4 venceu!");
                             }
                        }
                    }
                }
            Console.WriteLine("\n\aForam:\n" + cand1 + " votos para o candidato 1 \n" + cand2 + " votos para o candidato 2 \n" + cand3 + " votos para o candidato 3 \n" + cand4 + " votos para o candidato 4\n"+ branco +" votos em branco\n" + nulo + " votos nulos");
            Console.ReadKey();
            }
        }
    }
