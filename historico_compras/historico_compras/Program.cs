using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace historico_compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clientes = new int[10];
            string[] nomes = { "Jose", "Claudio", "Murilo", "Emily", "Larissa", "Maria", "Adalto", "fernando", "Felipe", "claudemir" };

            int totalGeral = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{nomes[i]}: ");
               clientes[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nTotal de valores passados$: ");
            for (int i = 0; i < 10; i++)
            {
                int total = clientes[i];
                totalGeral += total;
                Console.WriteLine($"{total}");
            }

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"\nSoma de todos os valores$: {totalGeral}");

            Console.WriteLine("-----------------------------------");

































        }
    }
}
