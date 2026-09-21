using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagamento
{
    internal class Program
    {/*6-	Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
 pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
 
 Tabela de Código de Condições de Pagamento
 
 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
 2 - À Vista no cartão de crédito, recebe 10% de desconto
 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
*/
        static void Main(string[] args)
        {
            double valor, total;
            string pagamento;

            Console.WriteLine("digite o valor do produto");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a forma de pagamento: \nf1:Pix / f2: Credito / f3: Credito 2x / f4: Credito 3x");
            pagamento=Console.ReadLine();

            if (pagamento == "f1")
            {
                total= valor - (valor * 0.15);
                Console.WriteLine(" o valor do produto final é " + total);
            }

            if (pagamento == "f2")
            {
                total = valor - (valor * 0.10);
                Console.WriteLine(" o valor do produto final é " + total);
            }

            if (pagamento == "f3")
            {
                total = valor;
                Console.WriteLine(" o valor do produto final é " + total);
            }

            if (pagamento == "f4")
            {
                total = valor + (valor * 0.10);
                Console.WriteLine(" o valor do produto final é " + total);
            }







































        }
    }
}
