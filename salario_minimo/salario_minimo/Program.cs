using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_minimo
{
    internal class Program
    {/*2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).
*/
        static void Main(string[] args)
        {
            double salario, total;

            Console.WriteLine("Digite o valor do salaio: ");
            salario =double.Parse(Console.ReadLine());

            total = salario / 1518;
            total= Math.Round(total , 2);
            Console.WriteLine("A quantidade de slarios minimos é "+ total);
            
            



















        }
    }
}
