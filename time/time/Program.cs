using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double time;
            Console.WriteLine("digite o tempo de entrega: ");
            time = double.Parse(Console.ReadLine());
            if (time <= 15)
            {
                Console.WriteLine("esntega perfeita! bonus garantido");
            }
            if (time > 15 && time < 30)
            {
                Console.WriteLine("pizza entergue a tempo, sem bonus ");
            }
             if (time >= 30)
            {
                Console.WriteLine("a pizza esfriou! peter foi demitido! ");
            }




















        }
    }
}
