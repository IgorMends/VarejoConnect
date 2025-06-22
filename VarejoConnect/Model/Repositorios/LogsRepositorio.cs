using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class LogsRepositorio
    {
        public int Add(Logs log)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            INSERT INTO logs
                                (data_hora, funcionario, entidade, entidade_id, acao)
                            VALUES
                                (@dataHora, @funcionario, @entidade, @entidadeId, @acao)
                            RETURNING id;";

            int novoId = connection.Connection.QuerySingle<int>(query, new
            {
                dataHora = log.dataHora,
                funcionario = log.funcionario,
                entidade = log.entidade,
                entidadeId = log.entidadeId,
                acao = log.acao
            });

            return novoId;
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) FROM logs;";

            try
            {
                int? maxId = connection.Connection.QuerySingleOrDefault<int?>(query);

                if (maxId == null || maxId == 0)
                    return 0;
              
                return maxId.Value + 1;
            }
            catch (System.Data.DataException)
            {
                return -1; 
            }
        }
    }
}
