using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class DevolucaoRepositorio
    {
        public bool Add(Devolucao devolucao)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.devolucoes(
	                                                        id, venda_fk, motivo, datadevolucao, funcionario)
	                                                        VALUES (@id, @vendaId, @motivo, @datadevolucao, @funcionario);";

            var result = connection.Connection.Execute(sql: query, param: devolucao);

            return result == 1;
        }

        public List<Devolucao> GetAllDevolucoes()
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT d.id AS Id,
                                   d.venda_fk AS VendaId,
                                   d.motivo AS Motivo,
                                   d.datadevolucao AS DataDevolucao,
                                   d.funcionario AS Funcionario,
                                   f.nome AS FuncionarioNome
                            FROM devolucoes d
                            JOIN funcionarios f ON d.funcionario = f.id
                            ORDER BY d.datadevolucao DESC;
                        ";

            return connection.Connection.Query<Devolucao>(query).ToList();
        }
        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM devolucoes;";

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

        public List<Devolucao> GetDevolucoesWithNames(DateTime dataInicio, DateTime dataFim)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT 
                                d.id,
                                d.venda_fk,
                                d.motivo,
                                d.datadevolucao,
                                d.funcionario,
                                f.nome AS funcionarioNome
                            FROM devolucoes d
                            JOIN funcionarios f ON d.funcionario = f.id
                            WHERE d.datadevolucao BETWEEN @DataInicio AND @DataFim  
                            ORDER BY d.datadevolucao DESC;";

            return connection.Connection.Query<Devolucao>(query, new { DataInicio = dataInicio, DataFim = dataFim }).ToList();
        }
    }
}
