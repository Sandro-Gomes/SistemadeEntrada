using SistemadeEntrada.Entitites;
using SistemadeEntrada.Services;

namespace SistemadeEntrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicoDeCadastro servicoDeCadastro = new ServicoDeCadastro();

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

        }
    }
}