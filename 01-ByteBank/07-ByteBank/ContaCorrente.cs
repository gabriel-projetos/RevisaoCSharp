using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    //não é permitido
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo
        {
            get 
            {
                return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //função
        public bool Sacar(double valor) 
        {
            if(this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }


        //metodo
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
    }
}
