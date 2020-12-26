using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();

            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.Sacar(50);
            Console.WriteLine(contaDoGabriel.saldo);


            contaDoGabriel.Depositar(100);
            Console.WriteLine(contaDoGabriel.saldo);

            ContaCorrente contaDaGabriella = new ContaCorrente();

            contaDaGabriella.titular = "Gabriella";

            Console.WriteLine(contaDoGabriel.saldo);
            Console.WriteLine(contaDaGabriella.saldo);

            //transferencia
            bool confirmado = contaDoGabriel.Transferir(20, contaDaGabriella);


            Console.WriteLine($"Conta do {contaDoGabriel.titular} - Saldo: " + contaDoGabriel.saldo);
            Console.WriteLine($"Conta do {contaDaGabriella.titular} - Saldo: " + contaDaGabriella.saldo);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
