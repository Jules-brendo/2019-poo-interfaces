using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        //public double Saldo { get; protected set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public abstract void Deposita(double valorOperacao);

        //public virtual void Deposita(double valorOperacao)
        //{
        //    //this.Saldo += valorOperacao;
        //}

        public abstract void Saca(double valor);

        //public virtual void Saca(double valor)
        //{
        //    this.Saldo -= valor;
        //}
        public virtual void Transfere(Conta contaDestino, double valor)
        {
            if (this.Saldo >= valor)
            {
                // Deposita conta destino
                contaDestino.Deposita(valor);
                // saca conta origem
                this.Saca(valor);
            }
        }
    }
}

