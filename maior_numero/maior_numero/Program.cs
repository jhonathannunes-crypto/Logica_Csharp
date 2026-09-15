using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;
            Console.WriteLine("digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine(" digite o terceiro numero ");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o quinto numero: ");
            n5 = double.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine("o maior numero é: " + n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine("o maior numero é: " + n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine("o maior numero é: " + n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine("o maior numero é: " + n4);
            }
            else { Console.WriteLine("o maior é:" + n5); }
                































        }
    }
}
