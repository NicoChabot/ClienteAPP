using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ClienteApp.Domain.Entities;
using ClienteApp.Domain.Interfaces;
using ClienteApp.Infrastrucure.Data;

namespace ClienteApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string _connectionString;

        public ClienteRepository()
        {
            _connectionString = DBSettings.ConnectionString;
        }

        public void Adicionar(Cliente cliente)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                @"INSERT INTO Clientes (Nome, Email, Cpf, DataNascimento)
                  VALUES (@Nome, @Email, @Cpf, @DataNascimento)",
                connection);

            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);

            command.ExecuteNonQuery();
        }

        public void Atualizar(Cliente cliente)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                @"UPDATE Clientes
                  SET Nome = @Nome,
                      Email = @Email,
                      Cpf = @Cpf,
                      DataNascimento = @DataNascimento
                  WHERE Id = @Id",
                connection);

            command.Parameters.AddWithValue("@Id", cliente.Id);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);

            command.ExecuteNonQuery();
        }

        public void Remover(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                "DELETE FROM Clientes WHERE Id = @Id",
                connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public Cliente ObterPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand(
                "SELECT * FROM Clientes WHERE Id = @Id",
                connection);

            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();

            if (!reader.Read()) return null;

            return MapearCliente(reader);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            var clientes = new List<Cliente>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM Clientes", connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                clientes.Add(MapearCliente(reader));
            }

            return clientes;
        }

        private Cliente MapearCliente(SqlDataReader reader)
        {
            var cliente = new Cliente(
                reader["Nome"].ToString(),
                reader["Email"].ToString(),
                reader["Cpf"].ToString(),
                Convert.ToDateTime(reader["DataNascimento"])
            );

            typeof(Cliente)
                .GetProperty("Id")?
                .SetValue(cliente, Convert.ToInt32(reader["Id"]));

            return cliente;
            
        }
    }
}
