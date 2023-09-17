using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool isPcd { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            this.isPcd = false;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "/ CPF: " + Cpf + "/ PCD: " + isPcd;
        }
    }
}
