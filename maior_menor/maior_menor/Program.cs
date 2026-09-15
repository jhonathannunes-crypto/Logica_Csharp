using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, menor, maior;
            Console.WriteLine("escolha um numero: ");
            num1 = double.Parse(Console.ReadLine());

            maior = num1 + 1;
            menor = num1 - 1;

            Console.WriteLine("o antessesor é " + menor);
            Console.WriteLine("o sucessor é " + maior);


































        }
    }
}
