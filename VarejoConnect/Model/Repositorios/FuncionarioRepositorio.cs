using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class FuncionarioRepositorio
    {
        public bool Add(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.funcionarios(
	                        id, login,nome, senha, cargo, salario, funcionarioAlteracao, dataAlteracao, dataCriacao, status)
	                        VALUES (@id, @login,@nome, @senha, @cargo, @salario, @funcionarioAlteracao, @dataAlteracao, @dataAlteracao, @status);";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1; 
        }

        public List<Funcionario> getAllWithNames()
        {
            using var connection = new ConnectionDb();

            string query = @"
        SELECT 
            fu.id,
            fu.login,
            fu.nome,
            fu.senha,
            fu.cargo,
            fu.salario,
            fu.funcionarioalteracao,
            f.nome AS funcionarioNome,
            fu.dataalteracao,
            fu.datacriacao,
            fu.status
        FROM funcionarios fu
        JOIN funcionarios f ON fu.funcionarioalteracao = f.id
        WHERE fu.status = true
        ORDER BY fu.id DESC;";

            return connection.Connection.Query<Funcionario>(query).ToList();
        }

        public List<Funcionario> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM public.funcionarios WHERE status = TRUE;";

            var funcionarios = connection.Connection.Query<Funcionario>(sql: query);

            return funcionarios.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM funcionarios;";

            int id = connection.Connection.QuerySingleOrDefault<int>(query);

            return id;
        }

        public bool RemoveFuncionario(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE funcionarios SET status = FALSE WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1;
        }

        public bool UpdateFuncionario(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.funcionarios SET login= @login, nome= @nome, cargo= @cargo, salario= @salario, funcionarioAlteracao= @funcionarioAlteracao, dataAlteracao= @dataAlteracao
	WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1; 
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM funcionarios WHERE id = @Id AND status = TRUE;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Funcionario getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM funcionarios WHERE id = @Id AND status = TRUE;";

            Funcionario funcionarioRetornado = connection.Connection.QuerySingleOrDefault<Funcionario>(query, new { Id = id });

            return funcionarioRetornado;
        }
    }
}
