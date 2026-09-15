using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Ano Bissexto
          * Determine se um ano é Bissexto. Um ano Bissexto se for divisivel por 4, mas nao por 100, a não ser que divisivle por 400.
          * entrada:  2024
          * saida esperda : Ano bissexto
          * */
            int ano ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();

            Console.WriteLine("digite o ano que deseja saber: ");
            ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Ano Bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine("Ano Bissexto");
            }
            else
            {
                Console.WriteLine("Não bissexto");
            }



        }
    }
}
