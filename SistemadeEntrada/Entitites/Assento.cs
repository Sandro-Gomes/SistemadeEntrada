using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    internal class Assento
    {
        public string Id { get; set; }
        public Ingresso Ingresso { get; set; }

        public Assento(string opt)
        {
            Ingresso = null;
            Id = opt;
        }

        public Assento(Ingresso ingresso)
        {
            Ingresso = ingresso;
        }
    }

}
