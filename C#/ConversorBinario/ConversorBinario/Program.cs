using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            
                       
                        Console.WriteLine("\n Conversor de numero na base 10 para base 2\n");
 
                        string binario;
                       
                        int nMaxi, numD;
 
                            Console.Write("\nDigite o número em decimal: ");
 
                            numD = int.Parse(Console.ReadLine());
                            binario = "";
                            nMaxi = 131072;
 
                            Console.Write("\n O numero na base decimal, " + numD);
                            do
                            {
                                if (numD - nMaxi >= 0)
                                {
                                    numD = numD - nMaxi;
                                    binario = binario + "1";
                                }
                                else
                                {
                                    binario = binario + "0";

                                }
                                nMaxi = nMaxi / 2;
                            } while (numD != 0);
                            Console.Write(", para a base binária, é:\n " + binario +"\n");
                       
                        Console.WriteLine("\n Press <ENTER> para continuar...\n");
                        Console.ReadKey();
                        
        }
    }
}
