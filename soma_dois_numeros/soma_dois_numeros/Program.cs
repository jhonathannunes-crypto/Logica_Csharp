using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_dois_numeros
{
    internal class Program
    {/*1-	Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
imprimir seu valor na tela.*/
        static void Main(string[] args)
        {
            int a, b,  soma, multiplicacao;

            Console.WriteLine("Digite o primerio número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b= int.Parse(Console.ReadLine());

            if (a == b)
            {
                soma = a + b;
                Console.WriteLine("o reesultado é " + soma);
            }
            else 
            {
                multiplicacao = a * b;
            Console.WriteLine("o total da multiplicação é " + multiplicacao);
            }

            





































        }
    }
}
