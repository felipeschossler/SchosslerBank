using System;

namespace SchosslerBank.Dominio
{

    class Conta
    {
        public int numero;
        public Cliente titular;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo > valor)
            {
                this.saldo -= valor;
                return true;
            }
            Console.WriteLine("O valor é maior que o saldo em conta");
            return false;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Tranferir(Conta contaDestino, double valor)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }
    }
}