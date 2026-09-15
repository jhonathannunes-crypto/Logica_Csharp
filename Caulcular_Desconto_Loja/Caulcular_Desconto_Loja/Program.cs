using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caulcular_Desconto_Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calcular desconto
             * um produto com preço acima de 100 reais tem um desconto de 10%.
             * caso contrario, o desconto é de 5%.
             * dado o preço calcule o valor do desconto.
             * entrada: 120
             * Saida esperada: 12 reais de desconto
            */
            double preco, total;


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║╚████║░░░██║░░░██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();


            Console.WriteLine("digite o valor do produto");
            preco = double.Parse(Console.ReadLine());
            if (preco > 100)
            {
                total = preco * 0.10;
                Console.WriteLine(total + " Reais de desconto");
            }
            else if (preco <= 100)
            {
                total = preco * 0.05;
                Console.WriteLine(total + " Reais de desconto");
            }








































        }
    }
}
