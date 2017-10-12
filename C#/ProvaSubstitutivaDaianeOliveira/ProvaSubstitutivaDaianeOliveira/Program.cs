using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSubstitutivaDaianeOliveira
{
    //Os comentarios a seguir sao apenas para que eu nao me perca no codigo. Att, Daiane Oliveira

    class Forma //inicio forma
    {
        private String nomeForma;

        public override string ToString()
        {
            return "forma";
        }

        public String getNome()
        {
            return this.nomeForma;
        }

        public void setNome(String nomeForma)
        {
            this.nomeForma = nomeForma;
        }
    } //Fim forma

    class FormaBidimensional : Forma //inicio forma bi
    {  
        public virtual double CalcularArea() 
        {
            return 0; 
        }

        public virtual double CalcularPerimetro() 
        {
            return 0; 
        }
        
        public override string ToString()
        {
            return base.ToString() + " " + "Forma Bidimensional";
        }
    }//fim forma bi

    class FormaTridimensional : Forma // inicio forma tri
    {
        public virtual double CalcularVolume() 
        {
            return 0; 
        }

        public override string ToString()
        {
            return base.ToString() + " " + "Forma Tridimensional";
        }
    } //fim forma tri

    class Circulo : FormaBidimensional //inicio class circulo
    {
        private double raio;

        public Circulo(double raio, String nome) 
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            double resp;
            resp = Math.PI * Math.Pow(raio, 2);

            return resp;
        }

        public override double CalcularPerimetro()
        {
            double resp;
            resp = 2 * Math.PI * raio;

            return resp;
        }

        public override string ToString()
        {
            String aux;

            aux = base.ToString() + " " + " Classe Circulo\n\nNome:" + getNome() + "\nPerimetro do Circulo:" + CalcularPerimetro().ToString() + "\nArea do Circulo:" + CalcularArea().ToString();

            return aux;
        }
    }//fim class circulo

    class Quadrado : FormaBidimensional//inicio class quadrado
    {
        private double lado;

        public Quadrado(double lado, String nome)
        {
            this.lado = lado;

            base.setNome(nome);
        }

        public override double CalcularArea()
        {
            double resp1 = lado * lado;

            return resp1;
        }

        public override double CalcularPerimetro()
        {
            double resp;
            resp = 4 * lado;

            return resp;
        }

        public override string ToString()
        {
            String aux;

            aux = base.ToString() + " " + " Classe Quadrado\n\nNome:" + getNome() + "\nPerimetro do Quadrado:" + CalcularPerimetro().ToString() + "\nArea do Quadrado:" + CalcularArea().ToString();

            return aux;
        }
    
    }//fim class quadrado

    class Triangulo : FormaBidimensional // inicio class Triangulo
    {
        private double lado1, lado2, lado3,P;

        public Triangulo(double lado1, double lado2, double lado3, String nome)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;

            base.setNome(nome);
        }

        public override double CalcularPerimetro(double P)
        {
             P = lado1 + lado2 + lado3;
             return P;
        }

        public override double CalcularArea(double P)
        {
            P = P / 2;
            double resp;
            resp = P * (P - lado1) * (P - lado2) * (P - lado3);
            return base.CalcularArea(Math.Sqrt(resp));
        }

        public override string ToString()
        {
            String aux;

            aux = base.ToString() + " " + " Classe Triangulo\n\nNome:" + getNome() + "\nPerimetro do Triangulo:" + CalcularPerimetro().ToString() + "\nArea do Triangulo:" + CalcularArea().ToString();
            
            return aux;
        }
    }

    class Esfera : FormaTridimensional 
    {
        private double raio;

        public Esfera(double raio, String nome) 
        {
            this.raio = raio;

        }

        public override string ToString()
        {
            String aux;

            aux = base.ToString() + " " + " Classe Esfera\n\nNome:" + getNome() + "\nVolume da Esfera:" + CalcularVolume().ToString();

            return aux;
        }
        
        public override double CalcularVolume()
        {
            double resp;
            resp = (4 * Math.PI * Math.Pow(raio, 3))/ 3;
            return base.CalcularVolume(resp);
        }

    }

    class Cubo : FormaTridimensional 
    {
        private double Lado;

        public Cubo(double Lado, String nome) 
        {
            this.Lado = Lado;
        }

        public override double CalcularVolume()
        {
            double resp;
            resp = Math.Pow(Lado, 3);
            return base.CalcularVolume(resp);
        }

        public override string ToString()
        {
            String aux;

            aux = base.ToString() + " " + " Classe Cubo\n\nNome:" + getNome() + "\nVolume da Cubo:" + CalcularVolume().ToString();

            return aux;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo C = new Circulo(5, "Circulo");
            Triangulo T = new Triangulo(5, 5, 5, "Triangulo");
            Quadrado Q = new Quadrado(5, "Quadrado");
            Cubo Cub = new Cubo(5, "Cubo");
            Esfera E = new Esfera(5, "Esfera");

            Console.Write(C.ToString() + "\n" + T.ToString() + "\n" + Q.ToString() + "\n" + Cub.ToString() + "\n" + E.ToString());
            Console.ReadKey();
        }
    }


}
