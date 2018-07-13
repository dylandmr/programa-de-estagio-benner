﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCaixaEletronico
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente titular) : base(titular)
        {
            this.Titular = titular;
        }

        public override bool Saca(double valor)
        {
            if (valor <= this.Saldo && valor > 0)
            {
                if (!Titular.MaiordeIdade && valor > 200.0) this.Saldo -= 200.0;
                else this.Saldo -= valor;
                return true;
            }
            else return false;
        }
    }
}
