using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDeDinheiro
{
    internal class Pilha
    {
        public Money Topo { get; set; }

        public Pilha()
        {
            this.Topo = null;
        }

        public bool VerificarVazio()
        {
            if (this.Topo == null)
            {
                Console.WriteLine("Pilha vazia. Inserindo o primeiro.");
                return true;
            }
            else
            {
                Console.WriteLine("Pilha ja iniciada. Inserindo no topo.");
                return false;
            }
        }

        public void Inserir(Money dinheiro)
        {
            if (VerificarVazio())
            {

                this.Topo = dinheiro;
                dinheiro.Anterior = null;
            }
            else
            {
                dinheiro.Anterior = this.Topo;
                this.Topo = dinheiro;
            }
        }

        public void Remover()
        {
            if (VerificarVazio())
                Console.WriteLine("Pilha vazia. Impossivel remover.");
            else
            {
                this.Topo = Topo.Anterior;
                Console.WriteLine("objeto removido do topo com sucesso");
            }
        }

        public void Imprimir()
        {
            if (VerificarVazio())
                Console.WriteLine("Pilha vazia!");
            else
            {
                Money auxiliar = this.Topo;
                do
                {
                    Console.WriteLine(auxiliar.ToString());
                    auxiliar = auxiliar.Anterior;
                } while (auxiliar != null);
            }
        }
    }
}
