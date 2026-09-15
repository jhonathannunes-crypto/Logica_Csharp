using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string nome;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("O nome do aluno é " + nome + " é a meida dele é " +  media);











































        }
    }
}
