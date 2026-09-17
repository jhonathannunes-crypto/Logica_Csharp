using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verdadeiro_falso
{
    internal class Program
    {/*4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.*/
        static void Main(string[] args)
        {
            string v1, v2;
            bool v;
            bool falso;

            Console.WriteLine("digite se é verdadeiro ou falso");
            v1 = Console.ReadLine();
            Console.WriteLine(" digite2 se é verdadeiro ou falso");
            v2 = Console.ReadLine();
            
            if (v1 == v2)
            {
                Console.WriteLine("ambos são verdadeiro");
            }
            else
            {
                Console.WriteLine("não são verdadeiros");
            }











































        }
    }
}
