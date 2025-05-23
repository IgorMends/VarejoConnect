using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class ProdutoVendaRepositorio
    {
        public bool Add(Produto produto, int vendaId)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.produto_venda(venda_fk, produto_fk, quantidade)
                     VALUES (@venda_fk, @produto_fk, @quantidade);";

            var parametros = new
            {
                venda_fk = vendaId,           
                produto_fk = produto.id,       
                quantidade = produto.quantidade
            };

            var result = connection.Connection.Execute(sql: query, param: parametros);

            return result == 1;
        }

        public List<Produto> GetByVendaId(int vendaId)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT p.id, p.nome, p.secao, pv.quantidade
                            FROM public.produto_venda pv
                            INNER JOIN public.produtos p ON p.id = pv.produto_fk
                            WHERE pv.venda_fk = @vendaId;
                        ";

            var produtos = connection.Connection.Query<Produto>(query, new { vendaId }).ToList();

            return produtos;
        }
    }
}
