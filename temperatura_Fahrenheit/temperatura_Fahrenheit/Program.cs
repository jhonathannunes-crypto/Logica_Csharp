using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura_Fahrenheit
{
    internal class Program
    {/*9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9)
*/
        static void Main(string[] args)
        {
            double Fahrenheit, Celcius, total;


            Console.WriteLine("Digite a temperatura que deseja converter de Fahrenheits para Celscius: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            Celcius = (5 * (Fahrenheit - 32) / 9);

            total = Celcius;
            Console.WriteLine("a temperatura em graus Celscius é " + Celcius);






















        }
    }
}
