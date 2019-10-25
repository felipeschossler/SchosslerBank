using System;
using SchosslerBank.Dominio;

namespace SchosslerBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            Conta d = new Conta();

            c.saldo = 100;
            d.saldo = 150;

            c.Tranferir(d, 50);

            Console.WriteLine($"Valor de c = {c.saldo}");
            Console.WriteLine($"Valor de d = {d.saldo}");
        }
    }
}
