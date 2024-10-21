using Dapper;
using System;
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
	                        id, nome, senha, cargo, salario, funcionario_alteracao, data_alteracao, data_criacao)
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
    }
}
