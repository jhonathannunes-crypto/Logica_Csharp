using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_frutas
{
    internal class Program
    {// implemente um sistema que armazene as quantidades de 5 tipos de frutas 
     // em 3 cestas e calcule o total de frutas de cada tipo.
        static void Main(string[] args)
        {
            int[,] frutas = new int[5, 3]; // usa , pasa dois vetores 
            string[] tipos = { "maçã", "uva", "abacate", "pera","laranja" };

             for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{tipos[i]}: ");
               for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Cesta {j + 1}: ");
                    frutas[i, j] = int.Parse(Console.ReadLine());
                }

               
            }
            Console.WriteLine("\nTotal de cada fruta: ");
            for (int i = 0; i < 5; i++) 
            {
                int total = frutas[i, 0] + frutas[i, 1] + frutas[i, 2];
                Console.WriteLine($"{tipos[i]}:{total}");

            }



































        }
    }
}
