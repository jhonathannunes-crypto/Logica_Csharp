using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace cadastro_livro
{
    internal class Program
    {/* SISTEMA DE GESTÃO DE BIBLIOTECA
      * Cadastrar livro*/

        static void Main(string[] args)
        {
            int opcao =6;
           

            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗  ██████╗░██████╗░██╗███╗░░██╗░█████╗░██╗██████╗░░█████╗░██╗░░░░░
████╗░████║██╔════╝████╗░██║██║░░░██║  ██╔══██╗██╔══██╗██║████╗░██║██╔══██╗██║██╔══██╗██╔══██╗██║░░░░░
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║  ██████╔╝██████╔╝██║██╔██╗██║██║░░╚═╝██║██████╔╝███████║██║░░░░░
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║  ██╔═══╝░██╔══██╗██║██║╚████║██║░░██╗██║██╔═══╝░██╔══██║██║░░░░░
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝  ██║░░░░░██║░░██║██║██║░╚███║╚█████╔╝██║██║░░░░░██║░░██║███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░  ╚═╝░░░░░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚════╝░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Cadastrar Livro ");
                Console.WriteLine("2 - Cadatrar jogo");
                Console.WriteLine("3 - Cadastrar cliente");
                Console.WriteLine("4 - cadastrar fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção :) ");


                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        livros();

                        break;


                    case 2:

                        classe_jogos();

                        break;

                    case 3:

                        Classe_cliente();

                        break;

                    case 4:

                        Classe_Fornecedor();

                        break;

                    case 5:

                        Classe_Emprestimo();

                        break;
                    case 0:

                        Console.Clear();
                        Console.WriteLine(" Saindo do Programa !!! Tchau Tchau !!  :)");

                        break;



                }
            }



        }

        static void livros()
        {

            int id, anoPublicacao, qtdExemplares;
            string genero, ISBN, Autor, titulo;


            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(@"
██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("digite o ID ( Identificador Único) ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da obra: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Digite o nome do Autor: ");
            Autor = Console.ReadLine();

            Console.WriteLine("Digite o codigo ISBN: ");
            ISBN = Console.ReadLine();
            
            Console.WriteLine("Digite o ano da publicaçao: ");
            anoPublicacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a categoria do livro: ");
            genero = Console.ReadLine();
          
            Console.WriteLine("Digite a quantidade de cópias: ");
            qtdExemplares = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCadastro realizado com sucesso!! ");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + titulo); 
            Console.WriteLine("\n" + Autor);
            Console.WriteLine("\n" + ISBN);
            Console.WriteLine("\n" + anoPublicacao);
            Console.WriteLine("\n" + genero);
            Console.WriteLine("\n" + qtdExemplares);

            
            Thread.Sleep(3000);

        }

          
        static void classe_jogos()
        {

            int id, FaixaEtaria, NumMinJogadores, NumMaxJogadores, qtdExemplares;
            string Categoria, Nome;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Digite o ID: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do jogo: ");
            Nome = Console.ReadLine(); 

            Console.WriteLine("Digite a categoria do jogo: ");
            Categoria = Console.ReadLine();

            Console.WriteLine("Digite a faixaetaria minima: ");
            FaixaEtaria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade minima de jogadores: ");
            NumMinJogadores = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a quantidade maxima de jogadores: ");
            NumMaxJogadores = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite a quantidade totoal de exemplares: ");
            qtdExemplares = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com sucesso!!");
            
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + Nome);
            Console.WriteLine("\n" + Categoria);
            Console.WriteLine("\n" + FaixaEtaria);
            Console.WriteLine("\n" + NumMinJogadores);
            Console.WriteLine("\n" + NumMaxJogadores);
            Console.WriteLine("\n" + qtdExemplares);

            Thread.Sleep(3000);



        }

        static void Classe_cliente()
        {


            int id;
            string Nome, CPF, telefone, Email;
            bool temPermisao;



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░██╗░░░░░░█████╗░░██████╗░██████╗███████╗  ░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██╔══██╗██╔════╝██╔════╝██╔════╝  ██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░███████║╚█████╗░╚█████╗░█████╗░░  ██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██╔══██║░╚═══██╗░╚═══██╗██╔══╝░░  ██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║░░██║██████╔╝██████╔╝███████╗  ╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝░░╚═╝╚═════╝░╚═════╝░╚══════╝  ░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Digite o ID do usuario: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF ");
            CPF = Console.ReadLine();

            Console.WriteLine("Digite o número de telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Digite o Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("\nData de nascimento (DD/MM/AAAA): "); // Lê o texto e converte usando o padrão de data do Brasil datanascimento 
            DateTime.Parse(Console.ReadLine());
            new System.Globalization.CultureInfo("pt-BR");

            Console.WriteLine(" digite se esta ativo ou não");
           temPermisao = bool.Parse(Console.ReadLine());


            Console.WriteLine("\nCadastro realizado com sucesso: ");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + Nome);
            Console.WriteLine("\n" + CPF);
            Console.WriteLine("\n" +telefone);
            Console.WriteLine("\n" + Email);
            
            
          

            if (temPermisao == true )
            {
                Console.WriteLine("Ativo!");
            }
            else
            {
                Console.WriteLine("Não ativo!");
            }

            Thread.Sleep(3000);

        }

        static void Classe_Fornecedor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░██╗░░░░░░█████╗░░██████╗░██████╗███████╗
██╔══██╗██║░░░░░██╔══██╗██╔════╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░███████║╚█████╗░╚█████╗░█████╗░░
██║░░██╗██║░░░░░██╔══██║░╚═══██╗░╚═══██╗██╔══╝░░
╚█████╔╝███████╗██║░░██║██████╔╝██████╔╝███████╗
░╚════╝░╚══════╝╚═╝░░╚═╝╚═════╝░╚═════╝░╚══════╝

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;




            int id;
            string RazaoSocial, CNPJ, Telefone, Email, endereco;

            Console.WriteLine("Digite o id do fornecedor: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Razão Social da empresa / editora: ");
            RazaoSocial = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ: ");
            CNPJ = Console.ReadLine();

            Console.WriteLine("Digite o número de telefone: ");
            Telefone = Console.ReadLine();

            Console.WriteLine("Digite o Email:");
            Email = Console.ReadLine();

            Console.WriteLine("Digite o endereço ( logadouro e cidade)");
            endereco = Console.ReadLine();



            Console.WriteLine("\nCadastro realizado com sucesso: ");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + RazaoSocial);
            Console.WriteLine("\n" + CNPJ);
            Console.WriteLine("\n" + Telefone);
            Console.WriteLine("\n" + Email);
            Console.WriteLine("\n" + endereco);

            Thread.Sleep(3000);


        }


        static void Classe_Emprestimo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░██╗░░░░░░█████╗░░██████╗░██████╗███████╗
██╔══██╗██║░░░░░██╔══██╗██╔════╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░███████║╚█████╗░╚█████╗░█████╗░░
██║░░██╗██║░░░░░██╔══██║░╚═══██╗░╚═══██╗██╔══╝░░
╚█████╔╝███████╗██║░░██║██████╔╝██████╔╝███████╗
░╚════╝░╚══════╝╚═╝░░╚═╝╚═════╝░╚═════╝░╚══════╝

███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;



            int id, cliente, ItemID, quantidade = 0;
            string TipoItem;
            DateTime data_retirada, data_entrega;
            bool devolvido;

            Console.WriteLine("Quantos emprestimos deseja fazer?: ");
            quantidade =int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {


                Console.WriteLine("digite o ID");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do cliente associado: ");
                cliente = int.Parse(Console.ReadLine());

                Console.WriteLine("O item requisitado é livro ou jogo?: ");
                TipoItem = Console.ReadLine();

                Console.WriteLine("Digite o codigo do jogo ou livro: ");
                ItemID = int.Parse(Console.ReadLine());

                Console.WriteLine("\nData de retirada (DD/MM/AAAA): ");
                data_retirada = DateTime.Parse(Console.ReadLine());
                new System.Globalization.CultureInfo("pt-BR");

                Console.WriteLine("\nData de entrega (DD/MM/AAAA): ");
                data_entrega = DateTime.Parse(Console.ReadLine());
                new System.Globalization.CultureInfo("pt-BR");

                Console.WriteLine(" digite se esta ativo ou não");
                devolvido = bool.Parse(Console.ReadLine());



                if (devolvido == true)
                {
                    Console.WriteLine("Devolvido no praso");
                }
                else
                {
                    Console.WriteLine("Em atraso");
                }


                Thread.Sleep(3000);


            }
        }


















    }
}
