﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ContaCorrente : Conta , ITributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.05);
        }
        public override void Deposita(double valorOperacao)
        {
            this.Saldo += (valorOperacao - 0.10);
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }
    }
}
