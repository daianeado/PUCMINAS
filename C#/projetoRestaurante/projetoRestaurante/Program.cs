using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRestaurante
{
    class Program
    {
        static void Pratos()
        {
            Console.WriteLine("\n\n\n\t\t\t***Prato do dia***\n\n");
            Console.WriteLine("CÓDIGO	PRATO	                  CONTEÚDO	                      PREÇO");
            Console.WriteLine("01	    COCÓ	    Arroz, Frango Frito, Feijão, Batata Sotê	R$ 4,00");
            Console.WriteLine("02	    MUMU	    Filé grelhado, Arroz à Grega, Salada Mista	R$ 5,00");
            Console.WriteLine("03	    QUAQUÁ	    Pato com Laranja, Arroz, Maionese	        R$ 6,50");
            Console.WriteLine("04	    SUPERCOCÓ	Strogonoff, Arroz, Fritas, Maionese	        R$ 6,00");

        }

        static void Bebidas() 
        {
            Console.WriteLine("\n\n\n\t\t\t***Bebidas***\n\n");
            Console.WriteLine("CÓDIGO	BEBIDA	            PREÇO");
            Console.WriteLine("11	Refrigerante em lata	R$ 1,20");
            Console.WriteLine("12	Sucos Naturais	        R$ 1,50");
            Console.WriteLine("13	Água Mineral – Garrafa	R$ 0,80");
            Console.WriteLine("14	Cerveja - Garrafa	    R$ 1,80");

        }

        static void Sobremesas() 
        {
            Console.WriteLine("\n\n\n\t\t\t***Sobremesa***\n\n");
            Console.WriteLine("CÓDIGO	TIPO	        PREÇO");
            Console.WriteLine("21	 Salada de Frutas	R$ 1,00");
            Console.WriteLine("22	 Doces	            R$ 0,70");
            Console.WriteLine("23	 Sorvete – bola	    R$ 0,80");
            Console.WriteLine("24	 Mousse	            R$ 1,20");
        }


        static double pedidoPrato(int cod, int quant)
        {
            
            double x=0;
            if (cod == 01)
            {
                x = x + quant * 4.00;
            }
            else 
            {
                if (cod == 02)
                {
                    x = x + quant * 5.00;
                }
                else 
                {
                    if (cod == 03)
                    {
                        x = x + quant * 6.50;
                    }
                    else 
                    {
                        if (cod == 04)
                        {
                            x = x + quant * 6.00;
                        }
                    }
                }
            }
            return (x);
        }


        static double pedidoBebida(int cod, int quant)
        {
            
            double x = 0;
            if (cod == 11)
            {
                x = x + quant * 1.20;
            }
            
                if (cod == 12)
                {
                    x = x + quant * 1.50;
                }
                    if (cod == 13)
                    {
                        x = x + quant * 0.80;
                    }
                        if (cod == 14)
                        {
                            x = x + quant * 1.80;
                        }
            return (x);
        }
        
        
        static double pedidoSobremesa(int cod,int quant)
        {
            
            double x = 0;
            if (cod == 21)
            {
                x = x + quant * 1.00;
            }
            else
            {
                if (cod == 22)
                {
                    x = x + quant * 0.70;
                }
                else
                {
                    if (cod == 23)
                    {
                        x = x + quant * 0.80;
                    }
                    else
                    {
                        if (cod == 24)
                        {
                            x = x + quant * 1.20;
                        }
                    }
                }
            } return (x);
        }

        static double TotalDoPedido(double totalP, double totalB, double totalS)
        {
            double totalPedidos;
            totalPedidos = totalP + totalB + totalS;
            return (totalPedidos);
        }

        static double media(double totalP, double totalB, double TotalS, double contQP, double contQB, double contQS)
        {
            double somaT, somaQuant, media;
            somaQuant = contQP + contQB + contQS;
            somaT = totalP + totalB + TotalS;
            media = somaT / somaQuant;
            return (media);
        }
        static void Main(string[] args)
        {
            char resp;
            int quant = 0, codproduto, op, cont1 = 0, cont2 = 0, cont3 = 0; //cod1 = 0, cod2 = 0, cod3 = 0, cod4 = 0, cod11 = 0, cod12 = 0, cod13 = 0, cod14 = 0,cod21 = 0, cod22 = 0, cod23 = 0, cod24 = 0,  maiorP = 0, maiorB = 0, maiorS = 0, maiorT = 0;
            double totalPrato = 0, totalBebida = 0, totalSobremesa = 0, totalTudo = 0,mediaCliente;
            
            Console.WriteLine("\n\n\n\t\t\t***Menu***");
            
            Console.WriteLine("\n\nInforme a opção desejada:\n");
            Console.WriteLine("\n\n1.	Ler e calcular valor do pedido.\n");
            Console.WriteLine("\n\n2.	Imprimir valor discriminando.\n");
            Console.WriteLine("\n\n3.	Apresente item mais pedido\n");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
               
                do
                {
                    Pratos();
                    Console.WriteLine("\n\n\nInforme o codigo do prato desejado");
                    codproduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\nDigite a quantidade a ser calculada");
                    quant = int.Parse(Console.ReadLine());
                    cont1 = cont1 + quant;
                    totalPrato = totalPrato + pedidoPrato(codproduto, quant);
                    Console.WriteLine("\n\nDeseja inserir mais algum prato.S-N");
                    resp = char.Parse(Console.ReadLine());

                } while (resp == 's' || resp == 'S');

               
                
                do
                {
                    Bebidas();
                    Console.WriteLine("\n\n\nDigite o codigo do bebida desejada");
                    codproduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\nInforme a quantidade a ser calculada");
                    quant = int.Parse(Console.ReadLine());
                    cont2 = cont2 + quant;
                    totalBebida = totalBebida + pedidoBebida(codproduto, quant);
                    Console.WriteLine("\n\nDeseja informar mais alguma bebida.S-N");
                    resp = char.Parse(Console.ReadLine());

                } while (resp == 's' || resp == 'S');

               

                do
                {
                    Sobremesas();
                    Console.WriteLine("\n\n\nDigite o código da sobremesa desejada");
                    codproduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\nInforme a quantidade a ser calculada");
                    quant = int.Parse(Console.ReadLine());
                    cont3 = cont3 + quant;
                    totalSobremesa = totalSobremesa + pedidoSobremesa(codproduto, quant);
                    Console.WriteLine("\n\nDeseja informar mais alguma sobremesa.S-N");
                    resp = char.Parse(Console.ReadLine());

                } while (resp == 's' || resp == 'S');

                totalTudo = TotalDoPedido(totalPrato, totalBebida, totalSobremesa);
                mediaCliente = media(totalPrato, totalBebida, totalSobremesa, cont1, cont2, cont3);

                Console.Clear();
                
                Console.WriteLine("\n O total do pedido da mesa|cliente foi de R$:" + totalTudo);
                Console.WriteLine("\n O total dos pedidos referentes aos pratos foi de: R$" + totalPrato);
                Console.WriteLine("\n O total dos pedidos referentes as bebidas foi de: R$" + totalBebida);
                Console.WriteLine("\n O total dos pedidos referentes as sobremesas foi de: R$" + totalSobremesa);
                Console.WriteLine("\n A média dos pedidos realizados por mesa|cliente foi de: R$" + mediaCliente);
                Console.ReadKey();


            }
            else 
            {
                if (op == 2) 
                {

                }
            }
            Console.ReadKey();

        }
    }
}
