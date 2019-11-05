namespace SchosslerBank.Dominio
{
    class Cliente
    {
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public string Rg { get; protected set; }
        public string Endereco { get; protected set; }
        public int Idade { get; protected set; }

        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }

}