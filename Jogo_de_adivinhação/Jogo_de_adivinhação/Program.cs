using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_adivinhação
{
    internal class Program
    {/* Simular o jogo de adivinhação: o jogar 1 escolhe um numero entre 1 e 10; o jogar 2 insere o número escolhido pelo jogador 1. quanto ele
      * acertar , o algoritimo deve informar que ele acertou o numero( escolhido pelo jogador 1) em x tentativas ( quantidade de tentativas do jogador 2). */
        static void Main(string[] args)
        {
            int num, contador = 1, jog1;
            Console.WriteLine("Jogadoe 1: Digite o numero para ser adivinahdo.");
            jog1 = int.Parse(Console.ReadLine());
            Console.Clear();
                
            while (contador <= 10)
            {
                Console.WriteLine(contador + " - Jogador2: Adivinhe o número");
                num = int.Parse(Console.ReadLine());
                if (num == jog1)
                {
                    Console.WriteLine("Parabens você acertou!\nVocê acertou em: " + contador + " tentativas");
                    break;
                }
                else { Console.WriteLine("tente novamente."); }
                contador++;

            }
            






















































        }
    }
}
