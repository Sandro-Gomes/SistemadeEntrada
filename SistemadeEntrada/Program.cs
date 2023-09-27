using SistemadeEntrada.Entitites;
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


            //Cadastro

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
                    servicoDeCadastro.CadastrarPessoa(servicoDeReserva, palestra);
                    break;
                case 2:
                    servicoDeReserva.ExibirAssentos(palestra);
                    break;
                default:
                    break;
            }

            //Seleção de assentos

            

            //Visualizar assentos após escolha

            servicoDeReserva.ExibirAssentos(palestra);
            Console.WriteLine("Aperte qualquer tecla pra continuar:");
            Console.ReadLine();




        }
    }
}