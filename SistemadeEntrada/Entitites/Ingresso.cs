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

        public Ingresso(Pessoa pessoa, DateTime date)
        {
            Pessoa = pessoa;
            this.date = date;
        }

        public override string ToString()
        {
            return "Ingresso: " 
                + Pessoa.ToString();
        }
    }
}
