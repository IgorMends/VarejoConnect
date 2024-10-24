using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class ProdutoRepositorio
    {
        public bool Add(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.produtos(
	                            id, nome, preco, marca, descricao, funcionario_fk, dataalteracao, datacriacao)
	                            VALUES (@id, @nome, @preco, @marca, @descricao, @funcionarioAlteracao, @dataAlteracao, @dataCriacao);";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public List<Produto> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.produtos";

            var produtos = connection.Connection.Query<Produto>(sql: query);

            return produtos.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM produtos;";

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

        public bool RemoveProduto(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM produtos WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public bool UpdateProduto(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.produtos SET nome= @nome, marca= @marca, preco= @preco, funcionario_fk= @funcionarioAlteracao, dataalteracao= @dataAlteracao
	WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM produtos WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }
    }
}
