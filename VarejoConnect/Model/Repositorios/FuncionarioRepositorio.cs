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
	                        id, nome, senha, cargo, salario, funcionarioAlteracao, dataAlteracao, dataCriacao)
	                        VALUES (@id, @nome, @senha, @cargo, @salario, @funcionarioAlteracao, @dataAlteracao, @dataAlteracao);";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1; 
        }

        public List<Funcionario> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.funcionarios";

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

            string query = @"DELETE FROM funcionarios WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1;
        }

        public bool UpdateFuncionario(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.funcionarios SET nome= @nome, cargo= @cargo, salario= @salario, funcionarioAlteracao= @funcionarioAlteracao, dataAlteracao= @dataAlteracao
	WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            return result == 1; 
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM funcionarios WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }
    }
}
