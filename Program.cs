using System;
using SchosslerBank.Dominio;

namespace SchosslerBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente felipe = new Cliente("Felipe", "845884620981");
            Cliente jose = new Cliente("Jose", "8569894641");
            Conta c = new Conta(12321, felipe);
            Conta d = new Conta(6666345, jose);
            
            Console.WriteLine("Nome conta c: " + felipe.Nome);
            Console.WriteLine("CPF conta c: " + felipe.Cpf);
            Console.WriteLine("Nome conta d: " + jose.Nome);
            Console.WriteLine("CPF conta d: " + jose.Cpf);
            c.Depositar(100);
            d.Depositar(150);

            c.Transferir(d, 50);

            Console.WriteLine($"Valor de c = {c.Saldo}");
            Console.WriteLine($"Valor de d = {d.Saldo}");
        }
    }
}
