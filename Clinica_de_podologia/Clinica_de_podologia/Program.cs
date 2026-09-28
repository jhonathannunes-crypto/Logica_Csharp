using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clinica_de_podologia
{
    internal class Program
    {


        public static class VariaveisGlobais
        {

            public static  int opcao;

            public static int ID_cliente;
            public static string Nome_cliente, CPF_cliente, Telefone_cliente, ObservaçõesAnamnese;
            public static DateTime data_nascimento;
            public static bool Possui_Diabetes;

            public static int ID_podologo;
            public static string Nome_podologo, RegistroProficional, Especialidade, Telefone_podologo;



            public static int ID_procedimento, DuracaoMinutos;

            public static string Nome_procedimento;
            public static decimal valor;



            public static int ID_agendamento, Cliented_agendamento, Pologold_agendamento, Procedimentold_agendamento;

            public static string Status_agendamento;

            public static DateTime DataHora_agendamento;






        }




        static void Main(string[] args)
        {
            VariaveisGlobais.opcao= 6;
            while (VariaveisGlobais.opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███╗░░██╗██╗░█████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██║░░░░░██║████╗░██║██║██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝██║░░░░░██║██╔██╗██║██║██║░░╚═╝███████║  ██║░░██║█████╗░░
██║░░██╗██║░░░░░██║██║╚████║██║██║░░██╗██╔══██║  ██║░░██║██╔══╝░░
╚█████╔╝███████╗██║██║░╚███║██║╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚════╝░╚══════╝╚═╝╚═╝░░╚══╝╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░██╗░█████╗░  
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██║██╔══██╗  
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║███████║  
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║██╔══██║  
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝██║██║░░██║  
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═╝╚═╝░░╚═╝  

░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗██╔════╝
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║╚█████╗░
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║░╚═══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░╚═════╝░");

                Console.ResetColor();

                Console.WriteLine("1 - Cadastrar Cliente (Ficha Rápida");
                Console.WriteLine("2 - Cadastrar Podólogo");
                Console.WriteLine("3 - Cadastrar Procedimento / Serviço");
                Console.WriteLine("4 - Agendar Consulta");
                Console.WriteLine("5 - Listar Agendamentos");
                Console.WriteLine("6 - Exibir todos os cadastros");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção: ");

                VariaveisGlobais.opcao = int.Parse(Console.ReadLine());

                switch (VariaveisGlobais.opcao)
                {

                    case 1:

                        CadastrarClient();

                        break;
                    case 2:

                        CadastrarPodólogo();

                        break;
                    case 3:

                        CadastrarProcedimento();

                        break;
                    case 4:

                        AgendarConsulta();

                        break;
                    case 5:

                        
        


                            break;
                    case 6:


                        break;
                    case 0:


                        break;





                }








            }


        }

        static void CadastrarClient()
        {

          


            Console.Clear() ;
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");

            Console.ResetColor();
            
            
            
            Console.WriteLine("Digite o ID: ");
            VariaveisGlobais.ID_cliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome completo do paciente: ");
            VariaveisGlobais.Nome_cliente = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            VariaveisGlobais.CPF_cliente = Console.ReadLine();

            Console.WriteLine("DIgite o telefone: ");
            VariaveisGlobais.Telefone_cliente = Console.ReadLine();

            Console.WriteLine("\nData de nascimento (DD/MM/AAAA): ");
            VariaveisGlobais.data_nascimento = DateTime.Parse(Console.ReadLine());

            new System.Globalization.CultureInfo("pt-BR");

            Console.WriteLine("O cliente possui Diabetes: ");
            VariaveisGlobais.Possui_Diabetes = bool.Parse(Console.ReadLine());

            if (VariaveisGlobais.Possui_Diabetes == true)
            {
                Console.WriteLine("livre para o procedimento! ");
            }
            else
            {
                Console.WriteLine("Alto ridco no procedimento!!");
            }

            Console.WriteLine("O paciente possui alergias ou doenças?: ");
            VariaveisGlobais.ObservaçõesAnamnese = Console.ReadLine();
           
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║░░██║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║░░██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░░╚════╝░");

            Console.ResetColor();

            Console.WriteLine("\nCadastro realizado com sucesso!! ");
            Console.WriteLine("\n" + VariaveisGlobais.ID_cliente);
            Console.WriteLine("\n" + VariaveisGlobais.Nome_cliente);
            Console.WriteLine("\n" + VariaveisGlobais.CPF_cliente);
            Console.WriteLine("\n" + VariaveisGlobais.Telefone_cliente);
            Console.WriteLine("\n" + VariaveisGlobais.data_nascimento);
            Console.WriteLine("\n" + VariaveisGlobais.Possui_Diabetes);
            Console.WriteLine("\n" +VariaveisGlobais.ObservaçõesAnamnese);

            Thread.Sleep(5000);

        }

        static void CadastrarPodólogo()
        {
            

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║░░██║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║░░██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░░╚════╝░

░░██╗██████╗░██████╗░░█████╗░███████╗██╗░██████╗░██████╗██╗░█████╗░███╗░░██╗░█████╗░██╗░░░░░██╗░░
░██╔╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██║██╔════╝██╔════╝██║██╔══██╗████╗░██║██╔══██╗██║░░░░░╚██╗░
██╔╝░██████╔╝██████╔╝██║░░██║█████╗░░██║╚█████╗░╚█████╗░██║██║░░██║██╔██╗██║███████║██║░░░░░░╚██╗
╚██╗░██╔═══╝░██╔══██╗██║░░██║██╔══╝░░██║░╚═══██╗░╚═══██╗██║██║░░██║██║╚████║██╔══██║██║░░░░░░██╔╝
░╚██╗██║░░░░░██║░░██║╚█████╔╝██║░░░░░██║██████╔╝██████╔╝██║╚█████╔╝██║░╚███║██║░░██║███████╗██╔╝░
░░╚═╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝░░");

            Console.ResetColor();

            Console.WriteLine("Digite o ID do proficional:");
            VariaveisGlobais.ID_podologo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do especialista:");
            VariaveisGlobais.Nome_podologo = Console.ReadLine();
            Console.WriteLine("Digite o numero do conselho/ registro técnico");
            VariaveisGlobais.RegistroProficional = Console.ReadLine();
            Console.WriteLine(" Podopediatria, Pé Diabético, Esportiva:");
            VariaveisGlobais.Especialidade = Console.ReadLine();
            Console.WriteLine("DIgite o Numero de telefone:");
            VariaveisGlobais.Telefone_podologo = Console.ReadLine();


            Console.WriteLine("\nCadastro realizado com sucesso!! ");
            Console.WriteLine("\n" + VariaveisGlobais.ID_podologo);
            Console.WriteLine("\n" + VariaveisGlobais.Nome_podologo);
            Console.WriteLine("\n" + VariaveisGlobais.RegistroProficional);
            Console.WriteLine("\n" + VariaveisGlobais.Especialidade);
            Console.WriteLine("\n" + VariaveisGlobais.Telefone_podologo);
           

            Thread.Sleep(5000);


        }


        static void CadastrarProcedimento()
        {

            {

               

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░██████╗░░█████╗░░█████╗░███████╗██████╗░██╗███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░░░░░██╗░██████╗███████╗██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗██║████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗░░░██╔╝██╔════╝██╔════╝██╔══██╗
██████╔╝██████╔╝██║░░██║██║░░╚═╝█████╗░░██║░░██║██║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║░░██╔╝░╚█████╗░█████╗░░██████╔╝
██╔═══╝░██╔══██╗██║░░██║██║░░██╗██╔══╝░░██║░░██║██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║░██╔╝░░░╚═══██╗██╔══╝░░██╔══██╗
██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗██████╔╝██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝██╔╝░░░██████╔╝███████╗██║░░██║
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═════╝░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░╚═╝░░░░╚═════╝░╚══════╝╚═╝░░╚═╝");
                Console.ResetColor();



                Console.WriteLine("Digite o ID do cliente: ");

                VariaveisGlobais.ID_procedimento = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome do cliente: ");

                VariaveisGlobais.Nome_procedimento = Console.ReadLine();

                Console.WriteLine("Digite o Tempo de Duração da consulta: ");

                VariaveisGlobais.DuracaoMinutos = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Valor da cunsulta: ");

                VariaveisGlobais.valor = decimal.Parse(Console.ReadLine());


                Console.WriteLine("Consulta Agendada com sucesso :) ");

                Console.WriteLine("\n" + VariaveisGlobais.ID_procedimento);

                Console.WriteLine("\n" + VariaveisGlobais.Nome_procedimento);

                Console.WriteLine("\n" + VariaveisGlobais.DuracaoMinutos);

                Console.WriteLine("\n" + VariaveisGlobais.valor);


                Thread.Sleep(10000);




            }


        }


        static void AgendarConsulta()

        {




            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██████╔╝
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██╔══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░░██║
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░░█████╗░███╗░░██╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║
██║░░██╗██║░░██║██║╚████║░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║
╚█████╔╝╚█████╔╝██║░╚███║██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║
░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝");

            Console.ResetColor();


            Console.WriteLine("Digite o ID do agendamento: ");

            VariaveisGlobais.ID_agendamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo do paciente cadastrado: ");

            VariaveisGlobais.Cliented_agendamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo do profissional responsavel: ");

            VariaveisGlobais.Pologold_agendamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo do procedimento a ser realizado: ");

            VariaveisGlobais.Procedimentold_agendamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Horario da consulta (XX:XX): ");

            VariaveisGlobais.DataHora_agendamento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Status do Agendamento ('Agendado' 'Concluido' 'Cancelado')");

            VariaveisGlobais.Status_agendamento = Console.ReadLine();



            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██████╔╝
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██╔══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░░██║
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░░█████╗░███╗░░██╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║
██║░░██╗██║░░██║██║╚████║░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║
╚█████╔╝╚█████╔╝██║░╚███║██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║
░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝");

            Console.ResetColor();


            if (VariaveisGlobais.Status_agendamento == "Agendado")

            {

                Console.WriteLine("\n Consulta agendada com sucesso :)");

            }

            if (VariaveisGlobais.Status_agendamento == "Agendamento")
            {

                Console.WriteLine("\n Consulta Concluida");

            }

            if (VariaveisGlobais.Status_agendamento == "Cancelada")

            {

                Console.WriteLine("\n consulta Cancelada");

            }





            Console.WriteLine("\n" + VariaveisGlobais.ID_procedimento);

            Console.WriteLine("\n" + VariaveisGlobais.Cliented_agendamento);

            Console.WriteLine("\n" + VariaveisGlobais.Pologold_agendamento);

            Console.WriteLine("\n" + VariaveisGlobais.Procedimentold_agendamento);

            Console.WriteLine("\n" + VariaveisGlobais.DataHora_agendamento);

            Console.WriteLine("\n" + VariaveisGlobais.Status_agendamento);






            Thread.Sleep(10000);

        }

       




































    }   

}
