using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class SecaoRepositorio
    {
        public bool Add(Secao secao)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.secoes(
	                            id, nome, descricao, quantidade, funcionarioalteracao, dataalteracao, datacriacao, status)
	                            VALUES (@id, @nome, @descricao, @quantidade, @funcionarioAlteracao, @dataAlteracao, @dataCriacao, @status);";

            var result = connection.Connection.Execute(sql: query, param: secao);

            return result == 1;
        }

        public List<Secao> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.secoes WHERE status = TRUE;";

            var secoes = connection.Connection.Query<Secao>(sql: query);

            return secoes.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM secoes;";

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

        public bool RemoveSecao(Secao secao)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE secoes SET status = FALSE WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: secao);

            return result == 1;
        }

        public bool UpdateSecao(Secao secao)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.secoes
	                        SET id= @id, nome= @nome, descricao= @descricao, funcionarioalteracao= @funcionarioAlteracao, dataalteracao= @dataAlteracao, datacriacao= @dataCriacao
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: secao);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM secoes WHERE id = @Id AND status = TRUE;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Secao getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM secoes WHERE id = @Id AND status = TRUE;";

            Secao secaoRetornado = connection.Connection.QuerySingleOrDefault<Secao>(query, new { Id = id });

            return secaoRetornado;
        }

        public Secao getByName(string nome)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM secoes WHERE nome = @nome AND status = TRUE;";

            Secao secaoRetornado = connection.Connection.QuerySingleOrDefault<Secao>(query, new { nome = nome });

            return secaoRetornado;
        }

        public List<string> getAllNomes()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM public.secoes WHERE status = TRUE;";

            var nomes = connection.Connection.Query<string>(sql: query);

            return nomes.ToList();
        }

        public int getIdByName(string nome)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT id FROM public.secoes 
                     WHERE nome = @Nome AND status = TRUE;";

            try
            {
                int id = connection.Connection.QuerySingleOrDefault<int>(
                    sql: query,
                    param: new { Nome = nome }
                );

                return id; 
            }
            catch (System.Data.DataException)
            {
                return -1; 
            }
        }

        public void IncrementarQuantidadeSecao(int secaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE secoes SET quantidade = quantidade + 1 WHERE id = @secaoId;";

            connection.Connection.Execute(query, new { secaoId });
        }

        public void DecrementarQuantidadeSecao(int secaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE secoes SET quantidade = quantidade - 1 WHERE id = @secaoId AND quantidade > 0;";

            connection.Connection.Execute(query, new { secaoId });
        }
    }
}
