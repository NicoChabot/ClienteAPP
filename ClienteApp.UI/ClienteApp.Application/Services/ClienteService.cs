using System.Collections.Generic;
using ClienteApp.Domain.Entities;
using ClienteApp.Domain.Interfaces;

namespace ClienteApp.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(string nome, string email, string cpf, DateTime dataNascimento)
        {
            var cliente = new Cliente(nome, email, cpf, dataNascimento);
            _repository.Adicionar(cliente);
        }

        public void Atualizar(int id, string nome, string email, string cpf, DateTime dataNascimento)
        {
            var cliente = _repository.ObterPorId(id);
            if (cliente == null)
                throw new Exception("Cliente não encontrado.");

            cliente.Atualizar(nome, email, cpf, dataNascimento);
            _repository.Atualizar(cliente);
        }

        public void Remover(int id)
            => _repository.Remover(id);

        public IEnumerable<Cliente> ObterTodos()
            => _repository.ObterTodos();
    }
}
