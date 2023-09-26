using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    internal class Assento
    {
        public Ingresso Ingresso { get; set; }

        public Assento()
        {
            Ingresso = null;
        }

        public Assento(Ingresso ingresso)
        {
            Ingresso = ingresso;
        }
    }

}
