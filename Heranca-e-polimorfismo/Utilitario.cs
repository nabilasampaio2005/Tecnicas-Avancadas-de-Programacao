using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProj
{
    internal class Utilitario:Automovelpai
    {
        public string cor { get; set; }
        public double quantidadelugares { get; set; }
        public virtual double Desconto()
        {
            return valor - 1000;
        }
    }
}
