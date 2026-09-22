using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cadastro_de_bandas
{
    internal class Program
    {
        /*
         se  / enquanto  / para  / caso  
         if     while       for     switch 
         
         Crie um sistema de cadastro  de Albuns de um artista / banda em que sera possivel cadastrar
        um numero x de musicas informadas pelo usuario. Crie um menu de opções para isso.
         
         
         */
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4) { 




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
                Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("1 - Cadastrar Album da Banada");
            Console.WriteLine("2 - Cadastrar Album do Artista ");// ano, Nome artista , qtd album , qtd vendas
            Console.WriteLine("3 - Cadastrar Músicas "); // digitar a quantidade de musicas( nome musica, duração, premiação
            Console.WriteLine("4 - sair do programa");
            Console.WriteLine(" ------>");
            Console.ResetColor();

            opcao = int .Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Cadastro_bandas();


                        break;
                    case 2:


                        Cadastro_Album();


                        break;

                    case 3:

                        Cadastrar_Musicas();

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Saindo do Programa !!! Tchau Tchau !!  :)");
                        break;

                }

                       

            }


        }

        static void Cadastro_bandas()
        {
            string nomeBanda, nomeAlbum;
            int qtdMusicas;

            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
        
        Console.ResetColor ();

            Console.WriteLine(" Digite o nome da banda: ");
            nomeBanda = Console.ReadLine();

            Console.WriteLine(" Digite o nome do Album: ");
            nomeAlbum = Console.ReadLine();

            Console.WriteLine(" Digite o numero de musicas: ");
            qtdMusicas = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCadastro realizado com sucesso: ");
            Console.WriteLine("\n" +nomeBanda);
            Console.WriteLine ("\n" + nomeAlbum);
            Console.WriteLine("\n" + qtdMusicas);

            Thread.Sleep(3000);

        }

        static void Cadastro_Album()
        {
            string NomeArtista;
            double qtdVendas, ano, qtdAlbum;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");

            Console.ResetColor();

            Console.WriteLine("Qual o ano do Album: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("qual o nome do Artista ");
            NomeArtista = Console.ReadLine();

            Console.WriteLine("Qual a quantidade de Album: ");
            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto esse Album vendeu: ");
            qtdVendas = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCadastro realizado com sucesso: ");
            Console.WriteLine("\n" + ano);
            Console.WriteLine("\n" + NomeArtista);
            Console.WriteLine("\n" + qtdAlbum);
            Console.WriteLine("\n" + qtdVendas);
           
            
            Thread.Sleep(3000);

        }

        static void Cadastrar_Musicas()
        {
            double  duracao, premiacao;
            string nomeMusica;

            int qtdmusicas = 0, qtdmusicasdigitada = 0;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░░██████╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║╚█████╗░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║░╚═══██╗
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("Digite quantas musicas deseja adicionar ");
            qtdmusicasdigitada = int.Parse(Console.ReadLine());

            while (qtdmusicasdigitada != qtdmusicas) 
            {

                Console.WriteLine("Qual o Nome da Musica: ");
                nomeMusica = Console.ReadLine();

                

                Console.WriteLine("Qual a duração das musicas: ");
                duracao = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantas premiações a musica recebeu: ");
                premiacao = double.Parse(Console.ReadLine());

                Console.WriteLine("\nCadastro realizado com sucesso: ");
                Console.WriteLine("\n" + nomeMusica);
                Console.WriteLine("\n" + duracao);
                Console.WriteLine("\n" + premiacao);


                Thread.Sleep(3000);
                qtdmusicas++;
            }


























        }











    }
}
