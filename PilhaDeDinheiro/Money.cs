using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDeDinheiro
{
    internal class Money
    {
        public int Valor { get; set; }
        public Money Anterior { get; set; }

        public Money(int valorNota)
        {
            this.Valor = valorNota;
            Anterior = null;
        }

        public override string ToString()
        {
            return "Valor: \n" + this.Valor;
        }
    }
}
