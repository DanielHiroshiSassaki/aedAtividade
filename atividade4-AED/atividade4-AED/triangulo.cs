using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4_AED
{
    internal class triangulo
    {
        private float a;
        private float b;
        private float c;


        public triangulo() { }

        public triangulo(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void setA(float a)
        {
            this.a = a;
        }
        public float getA()
        {
            return this.a;
        }

        public void setB(float b)
        {
            this.b = b;
        }
        public float getB()
        {
            return this.b;
        }
        public void setC(float c)
        {
            this.c = c;
        }
        public float getC()
        {
            return this.c;
        }

        public void imprimirDados()
        {
            if (a >= b + c)
            {
                Console.WriteLine("Não forma um triangulo");
            }

            else if (a * a == ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Retaingulo");
            }

            else if (a * a > ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Obtusangulo");
            }
            else if ((a == b) && (b == c))
            {
                Console.WriteLine("Triangulo equilatero");
            }
            else if (a * a < ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Acutangulo");
            }
            else
            {
                Console.WriteLine("Triangulo isosceles");
            }
        }
    }
}
