using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    internal class Ingresso
    {
        public Pessoa Pessoa { get; set; }
        public DateTime date { get; set; }
        public Assento Assento { get; set; }

        public Ingresso(Pessoa pessoa, DateTime date, Assento assento)
        {
            Pessoa = pessoa;
            this.date = date;
            Assento = assento;
        }
    }
}
