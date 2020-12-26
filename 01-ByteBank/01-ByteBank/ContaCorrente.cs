using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        //Propriedades tem valores padrões de inicialização
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        //para valores o valor default é 0
        //string é null


    }
}
