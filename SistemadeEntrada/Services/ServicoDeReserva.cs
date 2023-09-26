using SistemadeEntrada.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if (palestra.Assentos[i, j] == null)
                    {
                        Console.Write("[ ]");
                    }

                    else
                    {
                        Console.Write("[X]");
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

            palestra.Assentos[coluna, linha] = new Assento();
            palestra.Assentos[coluna, linha].Ingresso = ingresso;

        }
    }
}
