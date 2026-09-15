using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritimo para cadastro de produto : Código, fabricante, categoria, preço, estoque, valor total em estoque.
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;    //real inteiro/real
            Console.WriteLine("Digite o codigo: "); // escreva
            codigo = int.Parse(Console.ReadLine()); // leia numero
            Console.WriteLine("Digite o fabricante: ");
            fabricante = Console.ReadLine();// leia texto
            Console.WriteLine("Digite a ctegoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            preco = double.Parse(Console.ReadLine()); // leia numero/ quabrado
            Console.WriteLine("Digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;  // matematica 
            Console.WriteLine(" O valor total em  estoque é " + total);  // resumo










































        }
    }
}
