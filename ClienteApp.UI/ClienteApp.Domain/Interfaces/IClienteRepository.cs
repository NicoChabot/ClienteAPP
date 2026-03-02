using System.Collections.Generic;
using ClienteApp.Domain.Entities;

namespace ClienteApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Remover(int id);
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> ObterTodos();
    }
}
