using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProj
{
    internal class Automovelpai
    {
        public string marca { get; set; }
        public double valor { get; set; }
        public string modelo { get; set; }
  
        public virtual double Desconto()
        {
            return valor - 1000;
        }
    }
}
