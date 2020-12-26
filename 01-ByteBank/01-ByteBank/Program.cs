using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.Numero = 863452;
            contaDaGabriela.Saldo = 100;

            Console.WriteLine(contaDaGabriela.Titular);
            Console.WriteLine("Agência: " + contaDaGabriela.Agencia);
            Console.WriteLine("Número: " + contaDaGabriela.Numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.Saldo);

            contaDaGabriela.Saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.Saldo);
            Console.WriteLine("Hello World!");
        }
    }
}
