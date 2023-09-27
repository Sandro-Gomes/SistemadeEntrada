using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites
{
    internal class Palestra
    {
        public Assento[,] Assentos; 
        public HashSet<Ingresso> Ingressos = new HashSet<Ingresso>();
        public Palestra()
        {
            Assentos = new Assento[5, 10];
        }
        public void adicionarIngresso(Ingresso ingresso)
        {
            Ingressos.Add(ingresso);
        }
    }
}
