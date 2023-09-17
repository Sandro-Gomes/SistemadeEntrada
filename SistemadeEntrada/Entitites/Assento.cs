using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    abstract class Assento
    {
        public int Fileira { get; set; }
        public int Coluna { get; set; }

        protected Assento(int fileira, int coluna)
        {
            Fileira = fileira;
            Coluna = coluna;
        }
    }
}
