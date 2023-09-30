using SistemadeEntrada.Entitites;
using SistemadeEntrada.Entitites.Exceptions;

namespace SistemadeEntrada.Services
{
    internal class ServicoDeReserva
    {

        public void ExibirAssentos(Palestra palestra)
        {
            char c = 'a';
            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                    c++;
                Console.Write(c + " ");
                for (int j = 0; j < 10; j++)
                {
                    if (palestra.Assentos[i, j] != null)
                    {
                        Console.Write("[X]");
                    }

                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1  2  3  4  5  6  7  8  9  10");
        }

        public void ExibirAssentosPcd(Palestra palestra)
        {
            char c = 'a';
            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                    c++;
                Console.Write(c + " ");
                for (int j = 0; j < 10; j++)
                {
                    if (palestra.Assentos[i, j] != null || i < 2)
                    {
                        Console.Write("[X]");
                    }

                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1  2  3  4  5  6  7  8  9  10");
        }

        public void EscolherAssento(string opt, Palestra palestra, Ingresso ingresso)
        {
            int coluna = opt[0] - 'a';
            int linha = opt[1] - '1';

            Console.WriteLine(linha + " " + coluna);

            try
            {
                if (coluna > 'b' && ingresso.Pessoa.isPcd == false)
                {
                    throw new DomainException("Assento Inválido!");
                }
                else
                {
                    palestra.Assentos[coluna, linha] = new Assento();
                    palestra.Assentos[coluna, linha].Ingresso = ingresso;
                }

            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Thread.Sleep(2000);
            }

        }
    }
}
