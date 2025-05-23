using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class FornecedorRepositorio
    {
        public bool Add(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.fornecedores(
	                            id, nome, empresa, documento, telefone, funcionarioalteracao, dataalteracao, datacriacao, status)
	                            VALUES (@id, @nome, @empresa, @documento, @telefone, @funcionarioAlteracao, @dataAlteracao, @dataCriacao, @status);";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            return result == 1;
        }

        public List<Fornecedor> getAllWithNames()
        {
            using var connection = new ConnectionDb();

            string query = @"
        SELECT 
            fn.id,
            fn.nome,
            fn.empresa,
            fn.documento,
            fn.telefone,
            fn.funcionarioalteracao,
            f.nome AS funcionarioNome,
            fn.dataalteracao,
            fn.datacriacao,
            fn.status
        FROM fornecedores fn
        JOIN funcionarios f ON fn.funcionarioalteracao = f.id
        WHERE fn.status = true
        ORDER BY fn.id DESC;";

            return connection.Connection.Query<Fornecedor>(query).ToList();
        }

        public List<Fornecedor> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.fornecedores WHERE status = TRUE;";

            var fornecedores = connection.Connection.Query<Fornecedor>(sql: query);

            return fornecedores.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM fornecedores;";

            int id;

            try
            {
                id = connection.Connection.QuerySingleOrDefault<int>(query);
            }
            catch (System.Data.DataException ex)
            {
                return -1;
            }

            return id;
        }

        public bool RemoveFornecedor(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE fornecedores SET status = FALSE WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            return result == 1;
        }

        public bool UpdateFornecedor(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.fornecedores
	                        SET id= @id, nome= @nome, empresa= @empresa , telefone= @telefone, funcionarioalteracao= @funcionarioAlteracao, dataalteracao= @dataAlteracao, datacriacao= @dataCriacao, documento= @documento
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM fornecedores WHERE id = @Id AND status = TRUE;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Fornecedor getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM fornecedores WHERE id = @Id AND status = TRUE;";

            Fornecedor fornecedorRetornado = connection.Connection.QuerySingleOrDefault<Fornecedor>(query, new { Id = id });

            return fornecedorRetornado;
        }

        public Fornecedor getByName(string nome)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM fornecedores WHERE nome = @nome AND status = TRUE;";

            Fornecedor fornecedorRetornado = connection.Connection.QuerySingleOrDefault<Fornecedor>(query, new { nome = nome });

            return fornecedorRetornado;
        }
    }
}
