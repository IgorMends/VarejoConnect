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
    }
}
