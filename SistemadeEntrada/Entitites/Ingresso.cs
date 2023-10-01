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
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public string Assento { get; set; }

        public Ingresso(Pessoa pessoa, DateTime date)
        {
            Pessoa = pessoa;
            Date = date;
        }

        public Ingresso(Pessoa pessoa, DateTime date, int id)
        {
            Pessoa = pessoa;
            Date = date;
            Id = id;
        }

        public override string ToString()
        {
            return "Ingresso: " 
                + Pessoa.ToString();
        }
    }
}
