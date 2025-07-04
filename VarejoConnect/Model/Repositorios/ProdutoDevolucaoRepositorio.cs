﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class ProdutoDevolucaoRepositorio
    {
        public bool Add(Produto produto, int devolucaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.produto_devolucao(devolucao_fk, produto_fk, quantidade)
                     VALUES (@devolucao_fk, @produto_fk, @quantidade);";

            var parametros = new
            {
                devolucao_fk = devolucaoId,
                produto_fk = produto.id,
                quantidade = produto.quantidade
            };

            var result = connection.Connection.Execute(sql: query, param: parametros);

            return result == 1;
        }

        public int ObterQuantidadeDevolvida(int produtoId, int vendaId)
        {
            using var connection = new ConnectionDb();

            string query = @"
        SELECT COALESCE(SUM(pd.quantidade), 0)
        FROM produto_devolucao pd
        INNER JOIN devolucoes d ON d.id = pd.devolucao_fk
        WHERE pd.produto_fk = @produtoId AND d.venda_fk = @vendaId;
    ";

            return connection.Connection.QuerySingle<int>(query, new { produtoId, vendaId });
        }

        public List<Produto> GetByDevolucaoIdWithNames(int devolucaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT 
                                p.id,
                                p.nome,
                                p.secao,
                                s.nome AS secaoNome,
                                pd.quantidade
                            FROM public.produto_devolucao pd
                            INNER JOIN public.produtos p ON p.id = pd.produto_fk
                            INNER JOIN public.secoes s ON p.secao = s.id
                            WHERE pd.devolucao_fk = @devolucaoId;
                        ";

            var produtos = connection.Connection.Query<Produto>(query, new { devolucaoId }).ToList();

            return produtos;
        }
        public List<Produto> GetByDevolucaoId(int devolucaoId)
        {
            using var connection = new ConnectionDb();

            string query = @"
                            SELECT 
                                p.id, 
                                p.nome,
                                p.secao, 
                                pd.quantidade
                            FROM public.produto_devolucao pd
                            INNER JOIN public.produtos p ON p.id = pd.produto_fk
                            WHERE pd.devolucao_fk = @devolucaoId;
                        ";

            var produtos = connection.Connection.Query<Produto>(query, new { devolucaoId }).ToList();

            return produtos;
        }
    }
}
