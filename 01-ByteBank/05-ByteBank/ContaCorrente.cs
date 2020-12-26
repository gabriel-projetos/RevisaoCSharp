using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; } = 100;

        //função
        public bool Sacar(double valor) 
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }


        //metodo
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
