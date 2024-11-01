using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class ClienteRepositorio
    {
        public bool Add(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.clientes(
	                            id, nome, email, telefone, funcionario_fk, data_alteracao, data_criacao, cpf)
	                            VALUES (@id, @nome, @email, @telefone, @funcionarioAlteracao, @dataAlteracao, @dataCriacao, @cpf);";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            return result == 1;
        }

        public List<Cliente> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.clientes";

            var clientes = connection.Connection.Query<Cliente>(sql: query);

            return clientes.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM clientes;";

            int id = connection.Connection.QuerySingleOrDefault<int>(query);

            return id;
        }

        public bool RemoveCliente(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM clientes WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            return result == 1;
        }

        public bool UpdateCliente(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.clientes
	                        SET id= @id, nome= @nome, email= @email, telefone= @telefone, funcionario_fk= @funcionarioAlteracao, data_alteracao= @dataAlteracao, data_criacao= @dataCriacao, cpf= @cpf
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM clientes WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Cliente getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM clientes WHERE id = @Id;";

            Cliente clienteRetornado = connection.Connection.QuerySingleOrDefault<Cliente>(query, new { Id = id });

            return clienteRetornado;
        }
    }
}
