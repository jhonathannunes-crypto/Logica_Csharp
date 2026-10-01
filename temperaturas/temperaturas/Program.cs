using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace temperaturas
{
    internal class Program
    {//Crie um algoritimo que armazene as temperatura diárias de uma cidade durante as 
        // semana e informe o dia masi quente e o mais frio!
        static void Main(string[] args)
        {
            int[] temperatura = new int[7];
            string[] dias = { "segunda", "terca", " quarta", "quaimta", "sexta", " sabado", "domingo" };

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine($"\n{dias[i]}: ");
                for(int j = 0; j < 1; j++)
                {
                    Console.Write($"Digite a temperatura de {dias[i]}: ");
                    temperatura[i] = int.Parse(Console.ReadLine());
                }

            }
            int maiorTemp = temperatura[0];
            int menorTemp = temperatura[0];
            string diaMaisQuente = dias[0];
            string diaMaisFrio = dias[0];

            
            for (int i = 1; i < 7; i++)
            {
                if (temperatura[i] > maiorTemp)
                {
                    maiorTemp = temperatura[i];
                    diaMaisQuente = dias[i];
                }

                if (temperatura[i] < menorTemp)
                {
                    menorTemp = temperatura[i];
                    diaMaisFrio = dias[i];
                }
            }

           
            Console.WriteLine($"\nO dia mais quente foi {diaMaisQuente} com {maiorTemp}°C.");
            Console.WriteLine($"O dia mais frio foi {diaMaisFrio} com {menorTemp}°C.");
        



































        }
    }
}
