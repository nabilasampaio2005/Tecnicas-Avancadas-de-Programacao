using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProj
{
    internal class Trabalho:Automovelpai
    {
        public double capacidadepeso { get; set; }
        public int quantidadeeixos { get; set; }
        public virtual double Desconto()
        {
            return valor - 5000;
        }
    }
}
