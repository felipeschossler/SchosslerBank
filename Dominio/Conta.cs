using System;

namespace SchosslerBank.Dominio
{

    class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public bool Sacar(double valor)
        {
            if (this.Saldo > valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("O valor é maior que o saldo em conta");
                return false;
            }
        }

        public bool Depositar(double valor)
        {
            this.Saldo += valor;
            return true;
        }

        public bool Transferir(Conta contaDestino, double valor)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}