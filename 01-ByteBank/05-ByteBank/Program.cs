using System;

//O namespace faz parte do nome completo de uma classe.
namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;

            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
