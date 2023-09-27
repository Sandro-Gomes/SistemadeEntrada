using SistemadeEntrada.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Services
{
    internal class ServicoDeCadastro
    {
        public ServicoDeCadastro()
        {
        }

        public void CadastrarPessoa(ServicoDeReserva servicoDeReserva, Palestra palestra)
        {
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
            Ingresso ingresso = new Ingresso(pessoa, DateTime.Now);

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
        }
    }
}
