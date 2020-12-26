using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = 10;

            conta.Titular = new Cliente()
            {
                Nome = "Gabriel",
                CPF = "441",
                Profissao = "Analista"
            };



            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
