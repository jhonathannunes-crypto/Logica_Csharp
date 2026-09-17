using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_peças
{
    internal class Program
    {/*  Uma fábrica tem uma linha de produção capaz de produzir 
          *  40 peças por dia . Um funcionario controla a qualidade ,
          *  cadastrando o numero da peça e o seu estado (aprovado ou reprovado).
          *  Criar um porgrama para cdastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas 
          *  no final do dia. */
        static void Main(string[] args)
        {
            int contador = 1, apro = 0, repro = 0;
            string pecas;

            while (contador <= 40)
            {

                Console.WriteLine(contador + " - Digite se a peça está aporvada ( a )ou reprovada (r).");
                pecas = Console.ReadLine();

                if (pecas == "a")
                {
                    apro++;
                }
                if (pecas == "r")
                {
                    repro++;
                }
                contador++;
            }
                Console.Clear();
                
               Console.WriteLine("o total de peças apro é " + apro + " \ne o total repro é: " + repro);
                   
               
            
              
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

          





















        }
    }
}
