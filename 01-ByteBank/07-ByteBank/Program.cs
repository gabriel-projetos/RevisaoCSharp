using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contaDoGabriel = new ContaCorrente(876,86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contaDAGabriella = new ContaCorrente(876, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
