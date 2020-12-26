using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;


            //Comparação de tipo por referencia, tipos em lugares diferentes na memoria, tipos complexos são por referencia.
            //false
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            Console.ReadLine();

            //Comparação de tipo de valor, guarda valores
            //true
            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine(idade == idadeMaisUmaVez);


            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);

            //Como os dois objetos apontam para o mesmo lugar, se um altera reflete no outro
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine();

        }
    }
}
