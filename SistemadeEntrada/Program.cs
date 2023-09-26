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

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, cpf);

            Console.Write("É PCD? (S/N): ");
            char c = char.Parse(Console.ReadLine());
            if (c == 's')
            {
                pessoa.isPcd = true;
            }

            Console.WriteLine(pessoa);
            Ingresso ingresso = new Ingresso(pessoa, DateTime.Now);
            Console.WriteLine(ingresso);

            //Seleção de assentos

            servicoDeReserva.ExibirAssentos(palestra);

            Console.WriteLine("Escolha o assento: ");
            string opt = Console.ReadLine();

            servicoDeReserva.EscolherAssento(opt, palestra, ingresso);

            //Visualizar assentos após escolha

            servicoDeReserva.ExibirAssentos(palestra);
            Console.WriteLine("Aperte qualquer tecla pra continuar:");
            Console.ReadLine();




        }
    }
}