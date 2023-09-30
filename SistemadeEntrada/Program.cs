using SistemadeEntrada.Entitites;
using SistemadeEntrada.Entitites.Exceptions;
using SistemadeEntrada.Services;

namespace SistemadeEntrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicoDeCadastro servicoDeCadastro = new ServicoDeCadastro();
            ServicoDeReserva servicoDeReserva = new ServicoDeReserva();
            Palestra palestra = new Palestra();
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    //Menu
                    Console.Clear();
                    Console.WriteLine("Bem vindo ao sistema de cadastro:");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("[1] Cadastrar nova pessoa");
                    Console.WriteLine("[2] Ver Assentos");
                    Console.WriteLine("[3] Sair");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Escolha a opção desejada: ");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            servicoDeCadastro.CadastrarPessoa(servicoDeReserva, palestra);
                            break;
                        case 2:
                            Console.Clear();
                            servicoDeReserva.ExibirAssentos(palestra);
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Sistema encerrando...");
                            Thread.Sleep(2500);
                            System.Environment.Exit(0);
                            break;
                        default:
                            throw new ArgumentException("Opção inválida!");
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
            }

        }
    }
}