using System;

namespace ClienteApp.Domain.Entities
{
    /// <summary>
    /// Representa a entidade Cliente.
    /// </summary>
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente(string nome, string email, string cpf, DateTime dataNascimento)
        {
            Validar(nome, email, cpf, dataNascimento);

            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public void Atualizar(string nome, string email, string cpf, DateTime dataNascimento)
        {
            Validar(nome, email, cpf, dataNascimento);

            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        private void Validar(string nome, string email, string cpf, DateTime dataNascimento)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email é obrigatório.");

            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("CPF é obrigatório.");

            if (dataNascimento >= DateTime.Now)
                throw new ArgumentException("Data de nascimento inválida.");
        }
    }
}
