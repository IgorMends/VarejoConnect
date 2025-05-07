using Dapper;
using Npgsql;
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
	                            id, nome, preco, quantidade, secao, marca, descricao, funcionarioalteracao, dataalteracao, datacriacao, status)
	                            VALUES (@id, @nome, @preco, @quantidade, @secao, @marca, @descricao, @funcionarioAlteracao, @dataAlteracao, @dataCriacao, @status);";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public List<Produto> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.produtos WHERE status = TRUE;";

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

            string query = @"UPDATE produtos SET status = FALSE WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public bool UpdateProduto(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.produtos SET nome= @nome, marca= @marca, preco= @preco, secao = @secao,funcionarioalteracao= @funcionarioAlteracao, dataalteracao= @dataAlteracao
	WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM produtos WHERE id = @Id AND status = TRUE;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Produto getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM produtos WHERE id = @Id AND status = TRUE;";

            Produto produtoRetornado = connection.Connection.QuerySingleOrDefault<Produto>(query, new { Id = id });

            return produtoRetornado;
        }

        public bool updateQuantidade(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.produtos SET quantidade = @quantidade WHERE id = @id AND status = TRUE;";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public Produto getByName(string nome)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM produtos WHERE nome = @nome AND status = TRUE;";

            Produto produtoRetornado = connection.Connection.QuerySingleOrDefault<Produto>(query, new { nome = nome });

            return produtoRetornado;
        }

        public void decreaseQuantity(Produto produto, int decrease)
        {
            using var connection = new ConnectionDb();

            string query = "UPDATE Produtos SET quantidade = quantidade - @quantidade WHERE id = @id AND status = TRUE";

            connection.Connection.Execute(query ,new { Quantidade = decrease, Id = produto.id });
        }

        public int GetQuantity(Produto produto)
        {
            using var connectionDb = new ConnectionDb();

            string query = "SELECT quantidade FROM produtos WHERE id = @id AND status = TRUE";

            return connectionDb.Connection.QuerySingle<int>(query, new { Id = produto.id });
        }

        public int GetQuantidadePorSecao(int secaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT COUNT(*) 
                     FROM public.produtos 
                     WHERE secao = @SecaoId AND status = TRUE;";

            int quantidade = connection.Connection.QuerySingle<int>(sql: query, param: new { SecaoId = secaoId });

            return quantidade;
        }
    }
}
