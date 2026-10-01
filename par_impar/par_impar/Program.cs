using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_impar
{
    internal class Program
    {
        //Crie um programa que amrmazene 20 números e separe-os em dois
        // array: um com numeros pares e outro com numeros impares.
        static void Main(string[] args)
        {

            int[] pares = new int[20];
            int[] impares = new int[20];
            int[] numeros = new int[20];
            int p = 0,i = 0;
 
            

            for (int j = 0; j < 20; j++)
            {
                Console.Write($"digite o numeros {j + 1}:");
                numeros[j] = int.Parse(Console.ReadLine());

                if (numeros[j] % 2 == 0) pares[p++] = numeros[j];
                else impares[i++] = numeros[j];

            }
            Console.WriteLine("\nPares:");
            for (int j = 0; j < p; j++) Console.WriteLine(pares[j] + " ");

            Console.WriteLine("\nImpares:");
            for(int j = 0;j < i; j++)Console.WriteLine(impares[j] + " ");


        }
    }
}
