using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            
            
            Console.WriteLine(conta.Saldo);
            Console.Read();
        }
    }
}
