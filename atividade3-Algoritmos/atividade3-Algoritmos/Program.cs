using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3_Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            banco p1 = new banco();
            Console.WriteLine("Digite o Nome: ");
            p1.setNome(Console.ReadLine());
            Console.WriteLine("Digite o Salario: ");
            p1.setSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o total das vendas");
            p1.setVendas(double.Parse(Console.ReadLine()));

            Console.WriteLine("Nome: " + p1.getNome());
            Console.WriteLine("Salario: " + p1.getSalario());
            Console.WriteLine("Vendas: " + p1.getVendas());
            Console.WriteLine("Total: " + p1.getSalario() + (p1.getVendas() * 0.15));
        }
    }
}
