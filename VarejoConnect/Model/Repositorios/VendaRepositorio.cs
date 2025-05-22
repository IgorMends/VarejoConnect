 using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class VendaRepositorio
    {
        public bool Add(Venda venda)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.vendas(
	                            id, funcionario_fk, cliente_fk, data_venda, valor_total, forma_pagamento)
	                                VALUES (@id, @funcionarioVenda, @clienteVenda, @dataVenda, @valorTotal, @formaPagamento);";

            var result = connection.Connection.Execute(sql: query, param: venda);

            return result == 1;
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM vendas;";

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

        public List<Venda> GetVendasWithNames(DateTime dataInicio, DateTime dataFim)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT 
                                v.id, 
                                c.nome AS clienteNome, 
                                f.nome AS funcionarioNome, 
                                v.data_venda AS dataVenda, 
                                v.valor_total AS valorTotal, 
                                v.forma_pagamento AS formaPagamento,
                                v.cliente_fk AS clienteVenda,
                                v.funcionario_fk AS funcionarioVenda
                            FROM vendas v
                            JOIN clientes c ON v.cliente_fk = c.id
                            JOIN funcionarios f ON v.funcionario_fk = f.id
                            WHERE v.data_venda BETWEEN @DataInicio AND @DataFim  
                            ORDER BY v.data_venda DESC;";

            return connection.Connection.Query<Venda>(query, new { DataInicio = dataInicio, DataFim = dataFim }).ToList();
        }

        public List<Venda> GetAllVendas()
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT v.id AS Id, 
                               v.cliente_fk AS clienteVenda, 
                               c.nome AS clienteNome, 
                               v.funcionario_fk AS funcionarioVenda, 
                               f.nome AS funcionarioNome, 
                               v.data_venda AS dataVenda, 
                               v.valor_total AS valorTotal, 
                               v.forma_pagamento AS formaPagamento
                            FROM vendas v
                            JOIN clientes c ON v.cliente_fk = c.id
                            JOIN funcionarios f ON v.funcionario_fk = f.id
                            ORDER BY v.data_venda DESC;"; 

            return connection.Connection.Query<Venda>(query).ToList();
        }
    }
}
