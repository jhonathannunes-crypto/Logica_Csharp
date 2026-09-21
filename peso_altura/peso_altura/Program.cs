using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace peso_altura
{
    internal class Program
    {/*5-	Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição 
de acordo com a tabela abaixo:
Fórmula do IMC = peso / (altura) ²
Tabela Condições IMC
         Abaixo de 18,5   | Abaixo do peso          
 Entre 18,6 e 24,9 | Peso ideal (parabéns)  
 Entre 25,0 e 29,9 | Levemente acima do peso
 Entre 30,0 e 34,9 | Obesidade grau I 
 Entre 35,0 e 39,9 | Obesidade grau II (severa)
 Maior ou igual a 40 | Obesidade grau III (mórbida)
*/

        static void Main(string[] args)
        {
            double peso, altura, total;

            Console.WriteLine("digite o peso da pessoa");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura da pessoa");
            altura = double.Parse(Console.ReadLine());

            total = (peso /  (altura * 2)  );

            if (total < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }


            if (total > 18.6 && total < 24.9)
            {
                Console.WriteLine("Peso ideal (parabéns)");
            }

            if (total > 25.0 && total < 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }

            if (total > 30.0 && total < 34.9)
            {
                Console.WriteLine("Obesidade grau I ");
            }

            if (total > 35.0 && total < 39.9)
            {
                Console.WriteLine(" Obesidade grau II (severa)");
            }

            if (total > 40)
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }
            







        }
    }
}
