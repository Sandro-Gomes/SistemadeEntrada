using SistemadeEntrada.Entitites;
using SistemadeEntrada.Entitites.Exceptions;
using System.Threading.Channels;

namespace SistemadeEntrada.Services
{
    internal class ServicoDeCadastro
    {
        public ServicoDeCadastro()
        {
        }

        public void CadastrarPessoa(ServicoDeReserva servicoDeReserva, Palestra palestra)
        {
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o CPF: ");
                    string cpf = Console.ReadLine();

                    Pessoa pessoa = new Pessoa(nome, cpf);

                    Console.Write("É PCD? (S/N): ");
                    char c = char.Parse(Console.ReadLine().ToLower());
                    if (c == 's')
                    {
                        pessoa.isPcd = true;
                    }
                    else if (c == 'n')
                    {
                        pessoa.isPcd = false;
                    }
                    else
                    {
                        throw new DomainException("Opção inválida!");
                    }
                    Ingresso ingresso = new Ingresso(pessoa, DateTime.Now, palestra.Ingressos.Count() + 1);

                    if (pessoa.isPcd == false)
                    {
                        servicoDeReserva.ExibirAssentosPcd(palestra);
                    }
                    else
                    {
                        servicoDeReserva.ExibirAssentos(palestra);
                    }
                    Console.WriteLine("Escolha o assento: ");
                    string opt = Console.ReadLine();
                    servicoDeReserva.EscolherAssento(opt, palestra, ingresso);
                    isRunning = false;
                }
                catch (DomainException e)
                {
                    Console.Clear();
                    Console.WriteLine("Erro: " + e.Message);
                    Thread.Sleep(2000);
                }
            }
        }

        public void ExibirIngresso(Palestra palestra, Ingresso ingresso)
        {
            Console.Clear();
            Console.Write("Ingresso #" + ingresso.Id.ToString("000") + " / PCD: ");
            if (ingresso.Pessoa.isPcd)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Não");
            Console.WriteLine("Nome: " + ingresso.Pessoa.Nome + " / Assento: " + ingresso.Assento);
            Thread.Sleep(3000);
        }
    }
}
