using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como 
             * dados de entrada tipos de vinho, sendo : "t" para tinto e "B" para branco. com a quantidade de vinhos é desconhecida, utilize 
             * "f" para finalizar. Após finazir o programa deve mostrar a quantidade de cada vinho na adega.
             * */
            int contador, quantidadeBranco = 0 , quantidadeTinto = 0 ;
            string vinhos;

            Console.ForegroundColor = ConsoleColor.DarkBlue; // comando para cor

            Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░  
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░"); // @""
            Console.ResetColor();// para a cor
            for (contador = 1; contador > 0; contador++ )
            {
                Console.WriteLine("digite qual tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para tinto e 'b ' para vinho branco):");
                vinhos = Console.ReadLine();

                if (vinhos == "b")
                {
                    quantidadeBranco++;
                }
                if (vinhos == "t")
                {
                    quantidadeTinto++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine(" o total de vinhos brancos em estoque são: " + quantidadeBranco + "\n o de vinhos tintos são: " + quantidadeTinto);
                    break;
                }








            
            }

        }
    }
}
