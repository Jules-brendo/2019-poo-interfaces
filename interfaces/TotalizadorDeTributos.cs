using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ContaPoupanca cp)
        {
            Total += cp.CalculaTributo();
        }

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }

        // public void Acumula(Conta c)
        //{
        //  Total += c.CalculaTributo();
        //}

    }
}
