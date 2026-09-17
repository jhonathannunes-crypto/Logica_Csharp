using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste
{
    internal class Program
    {/*Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.*/
        static void Main(string[] args)
        {
            double salario, total;

            Console.WriteLine("Digite o valor do salario a ser reajustado: ");
            salario = double.Parse(Console.ReadLine());
            
            total = salario * 0.05;
            Console.WriteLine(" O reajustado é: " + total);









































        }
    }
}
