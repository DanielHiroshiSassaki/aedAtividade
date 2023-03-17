using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4_AED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo p1 = new triangulo();
            Console.WriteLine("Triangulo");
            Console.WriteLine("Digite o valor de A: ");
            p1.setA(float.Parse(Console.ReadLine()));
            Console.WriteLine("O valor de A é: " + p1.getA());
            Console.WriteLine("\n\nDigite o valor de B: ");
            p1.setB(float.Parse(Console.ReadLine()));
            Console.WriteLine("O valor de B é: " + p1.getB());
            Console.WriteLine("\n\nDigite o valor de C: ");
            p1.setC(float.Parse(Console.ReadLine()));
            Console.WriteLine("O valor de C é: " + p1.getC() + "\n\n");

            p1.imprimirDados();
        }
    }
}
