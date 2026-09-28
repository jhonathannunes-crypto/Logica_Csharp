using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INTERNAÇÃO_HOSPITALAR
{
    internal class Program
    {

        public static class Variaveis
        {
            public static int opcao;

            public static int ID_Paciente;
            public static string Nome_paciente, CPF_paciente, Tiposanguineo, Alergias, cttEmergencia;
            public static DateTime datanascimento;


            public static int ID_medico;
            public static string Nome_medico, CRM_medico, Especialidade, Telefone_medico;



            public static int ID_leito;
            public static string Numquartos, Tipoleito;
            public static bool estaOcupado;


            public static int ID_internacao, Codpaciente, DrResponsavel, leitoID;
            public static string DiagnosticoEntrada, status;
            public static DateTime DataEntrada, DataAlta;

            public static int pacienteID;
            public static string LiberaçãoMedica;




        }

        static void Main(string[] args)
        {

            Variaveis.opcao = 7;
            while (Variaveis.opcao != 0)
            {




                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Cadastrar Leito");
                Console.WriteLine("4 - Registrar Internação(Admissão");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar Pacientes Internados");
                Console.WriteLine("7 - Exibir Relatório Geral do Hospital");
                Console.WriteLine("0 - Sair");


                Variaveis.opcao = int.Parse(Console.ReadLine());

                switch (Variaveis.opcao)
                {

                    case 1:

                        CadastrarPaciente();

                        break;
                    case 2:

                        FunçãoMedico();

                        break;
                    case 3:

                        FunçãoLeito();

                        break;
                    case 4:

                        FunçãoInternacao();

                        break;
                    case 5:

                        AltaHospitalar();

                        break;
                    case 6:


                        Lista_Paciente();
                        Console.Clear();

                        lista_medico();
                        Console.Clear();

                        lista_leito();
                        Console.Clear();

                        lista_internacao();
                        Console.Clear();

                        lista_Alta();


                        break;
                    case 7:

                        ListaGeral();

                        break;
                    case 0:

                        Console.WriteLine("SAINDO");

                        break;

                }

            }

        }
        static void CadastrarPaciente()
        {

            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Digite o ID do paciente:");
            Variaveis.ID_Paciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome completo do paciente:");
            Variaveis.Nome_paciente = Console.ReadLine();

            Console.WriteLine("CPF do paciente:");
            Variaveis.CPF_paciente = Console.ReadLine();

            Console.WriteLine("Data de nascimento:");
            Variaveis.datanascimento = DateTime.Parse(Console.ReadLine());
            new System.Globalization.CultureInfo("pt-BR");

            Console.WriteLine("Tipo sanguineo: ");
            Variaveis.Tiposanguineo = Console.ReadLine();

            Console.WriteLine("O paciente possui alergias?: ");
            Variaveis.Alergias = Console.ReadLine();

            Console.WriteLine("Contato de emergencia: ");
            Variaveis.cttEmergencia = Console.ReadLine();


            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("\n" + Variaveis.ID_Paciente);
            Console.WriteLine("\n" + Variaveis.Nome_paciente);
            Console.WriteLine("\n" + Variaveis.CPF_paciente);
            Console.WriteLine("\n" + Variaveis.datanascimento);
            Console.WriteLine("\n" + Variaveis.Tiposanguineo);
            Console.WriteLine("\n" + Variaveis.Alergias);
            Console.WriteLine("\n" + Variaveis.cttEmergencia);

            Thread.Sleep(5000);

        }
        static void Lista_Paciente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");



            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("\nID do paciente: " + Variaveis.ID_Paciente);
            Console.WriteLine("\nNome: " + Variaveis.Nome_paciente);
            Console.WriteLine("\nCPF:" + Variaveis.CPF_paciente);
            Console.WriteLine("\nNascimento:" + Variaveis.datanascimento);
            Console.WriteLine("\nSangue:" + Variaveis.Tiposanguineo);
            Console.WriteLine("\nAlergia:" + Variaveis.Alergias);
            Console.WriteLine("\nctt Emergencia: " + Variaveis.cttEmergencia);

            Thread.Sleep(5000);

        }


        static void FunçãoMedico()
        {
            


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("ID do médico: ");
            Variaveis.ID_medico = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do profissional");
            Variaveis.Nome_medico = Console.ReadLine();

            Console.WriteLine("CRM do médico");
            Variaveis.CRM_medico = Console.ReadLine();

            Console.WriteLine("Especialidade médica: ");
            Variaveis.Especialidade = Console.ReadLine();

            Console.WriteLine("Tel Do profissional");
            Variaveis.Telefone_medico = Console.ReadLine();


            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("\n" + Variaveis.ID_medico);
            Console.WriteLine("\n" + Variaveis.Nome_medico);
            Console.WriteLine("\n" + Variaveis.CRM_medico);
            Console.WriteLine("\n" + Variaveis.Especialidade);
            Console.WriteLine("\n" + Variaveis.Telefone_medico);

            Thread.Sleep(5000);


        }
        static void lista_medico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("\nid medico:" + Variaveis.ID_medico);
            Console.WriteLine("\nnome:" + Variaveis.Nome_medico);
            Console.WriteLine("\nCRM:" + Variaveis.CRM_medico);
            Console.WriteLine("\nespecialidade:" + Variaveis.Especialidade);
            Console.WriteLine("\nctt:" + Variaveis.Telefone_medico);

            Thread.Sleep(5000);
        }

        static void FunçãoLeito()
        {

           

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██╗░░░░░███████╗██╗████████╗░█████╗░
██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
███████╗███████╗██║░░░██║░░░╚█████╔╝
╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("ID do leito: ");
            Variaveis.ID_leito = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero do quarto: ");
            Variaveis.Numquartos = Console.ReadLine();

            Console.WriteLine("Enfermaria, Apartamento, UTI: ");
            Variaveis.Tipoleito = Console.ReadLine();

            Console.WriteLine("Status de ocupação (true = Ocupado / false = Livre): ");
            Variaveis.estaOcupado = bool.Parse(Console.ReadLine());

            if (Variaveis.estaOcupado == true)
            {
                Console.WriteLine("leito ocupado!");
            }
            else
            {
                Console.WriteLine("Leito livre!");
            }


            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("\n" + Variaveis.ID_leito);
            Console.WriteLine("\n" + Variaveis.Numquartos);
            Console.WriteLine("\n" + Variaveis.Tipoleito);
            Console.WriteLine("\n" + Variaveis.estaOcupado);

            Thread.Sleep(5000);

        }
        static void lista_leito()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

██╗░░░░░███████╗██╗████████╗░█████╗░
██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
███████╗███████╗██║░░░██║░░░╚█████╔╝
╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nidleito:" + Variaveis.ID_leito);
            Console.WriteLine("\nquarto:" + Variaveis.Numquartos);
            Console.WriteLine("\ntipo:" + Variaveis.Tipoleito);
            Console.WriteLine("\nstatus:" + Variaveis.estaOcupado);
            if (Variaveis.estaOcupado == true)
            {
                Console.WriteLine("leito ocupado!");
            }
            else
            {
                Console.WriteLine("Leito livre!");
            }

            Thread.Sleep(5000);

        }

            static void FunçãoInternacao()
        {

           

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("ID internção: ");
            Variaveis.ID_internacao = int.Parse(Console.ReadLine());

            Console.WriteLine("ID paciente: ");
            Variaveis.Codpaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Código do médico responsável: ");
            Variaveis.DrResponsavel = int.Parse(Console.ReadLine());

            Console.WriteLine("Códogo do leito alocado: ");
            Variaveis.leitoID = int.Parse(Console.ReadLine());

            Console.WriteLine("Data e hora da admissão: ");
            Variaveis.DataEntrada = DateTime.Parse(Console.ReadLine());

            new System.Globalization.CultureInfo("pt-BR");
            Console.WriteLine("Data e hora da Alta: ");

            Variaveis.DataAlta = DateTime.Parse(Console.ReadLine());
            new System.Globalization.CultureInfo("pt-BR");

            Console.WriteLine("Motivo/quadro na admissão: ");
            Variaveis.DiagnosticoEntrada = Console.ReadLine();

            Console.WriteLine("Status: internação / alta / transferido ");
            Variaveis.status = Console.ReadLine();


            Console.WriteLine("\nCadastro realizado com sucesso!");
            Console.WriteLine("\n" + Variaveis.ID_internacao);
            Console.WriteLine("\n" + Variaveis.Codpaciente);
            Console.WriteLine("\n" + Variaveis.DrResponsavel);
            Console.WriteLine("\n" + Variaveis.leitoID);
            Console.WriteLine("\n" + Variaveis.DataEntrada);
            Console.WriteLine("\n" + Variaveis.DataAlta);
            Console.WriteLine("\n" + Variaveis.DiagnosticoEntrada);
            Console.WriteLine("\n" + Variaveis.status);

            Thread.Sleep(5000);


        }

        static void lista_internacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;



            Console.WriteLine("\nid: " + Variaveis.ID_internacao);
            Console.WriteLine("\nid paciente:" + Variaveis.Codpaciente);
            Console.WriteLine("\nd.r:" + Variaveis.DrResponsavel);
            Console.WriteLine("\nleito:" + Variaveis.leitoID);
            Console.WriteLine("\nentrada:" + Variaveis.DataEntrada);
            Console.WriteLine("\nalta:" + Variaveis.DataAlta);
            Console.WriteLine("\ndiagnostoco:" + Variaveis.DiagnosticoEntrada);
            Console.WriteLine("\nstatus:" + Variaveis.status);

            Thread.Sleep(5000);
        }

            static void AltaHospitalar()
        {
            

            Console.WriteLine("ID do paciente:");
            Variaveis.pacienteID = int.Parse(Console.ReadLine());
            Console.WriteLine("Alta medica libereada?");
            Variaveis.LiberaçãoMedica = Console.ReadLine();

            Console.WriteLine("\n" + Variaveis.pacienteID);
            Console.WriteLine("\n" + Variaveis.LiberaçãoMedica);


        }
        static void lista_Alta()


        {


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

░█████╗░██╗░░░░░████████╗░█████╗░
██╔══██╗██║░░░░░╚══██╔══╝██╔══██╗
███████║██║░░░░░░░░██║░░░███████║
██╔══██║██║░░░░░░░░██║░░░██╔══██║
██║░░██║███████╗░░░██║░░░██║░░██║
╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\nid paciente:" + Variaveis.pacienteID);
            Console.WriteLine("\nliberação:" + Variaveis.LiberaçãoMedica);

            Thread.Sleep(5000);
        }


        static void ListaGeral()
        {
            int pacientesUnd, DrUnd, emfermeirasUnd;


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║
███████╗██║██████╔╝░░░██║░░░██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝

░██████╗░███████╗██████╗░░█████╗░██╗░░░░░
██╔════╝░██╔════╝██╔══██╗██╔══██╗██║░░░░░
██║░░██╗░█████╗░░██████╔╝███████║██║░░░░░
██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░░░░
╚██████╔╝███████╗██║░░██║██║░░██║███████╗
░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Quantos pacientes tem no hospital:");
            pacientesUnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos medicos na unidade:");
            DrUnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas enfermeiras na unidade: ");
            emfermeirasUnd = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQtd pacientes: " + pacientesUnd);
            Console.WriteLine("\nQtd médicos: " + DrUnd);
            Console.WriteLine("\nQtd enfermeiras:" + emfermeirasUnd);

            Thread.Sleep(5000);


        }


































    }

}
