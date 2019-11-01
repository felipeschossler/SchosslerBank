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
            
            c.Depositar(100);
            d.Depositar(150);

            c.Transferir(d, 50);

            Console.WriteLine($"Valor de c = {c.Saldo}");
            Console.WriteLine($"Valor de d = {d.Saldo}");
        }
    }
}
