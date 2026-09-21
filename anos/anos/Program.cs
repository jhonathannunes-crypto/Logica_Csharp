using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anos
{
    internal class Program
    {/*8 -  Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em */
        static void Main(string[] args)
        {
            int anoincial;
            int anofinal = DateTime.Today.Year;

            Console.WriteLine("digite o ano que voçê nasceu: ");
            anoincial = int.Parse(Console.ReadLine());

            for (int ano = anoincial; ano <= anofinal; ano++)
            {
                Console.WriteLine(" a idade é: " + ano);
            }

















































        }
    }
}
