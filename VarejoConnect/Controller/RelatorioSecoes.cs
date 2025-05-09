﻿using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarejoConnect.Model;

namespace VarejoConnect.Controller
{
    public class RelatorioSecoes : IDocument
    {
        private readonly List<Secao> _secoes;
        private readonly string _titulo;

        public RelatorioSecoes(List<Secao> secoes, string titulo)
        {
            _secoes = secoes;
            _titulo = titulo;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeColumn().AlignCenter().Height(40).Image("C:\\Users\\William\\Desktop\\Project\\VarejoConnect\\VarejoConnect\\Imagens\\Logo.png", ImageScaling.FitHeight);
                });

                column.Item().Height(30);

                column.Item().Row(row =>
                {
                    row.RelativeColumn().Text(_titulo).FontSize(15).SemiBold().FontColor(Colors.Blue.Medium);
                    row.ConstantColumn(150).AlignRight().Text($"Data: {DateTime.Now:dd/MM/yyyy}").FontSize(10).Light();
                });
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(10).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(2);
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("ID").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Nome").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Descrição").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Quantidade de Produtos").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Funcionário").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Alteração").FontSize(9).SemiBold();
                    header.Cell().Element(CellStyle).Text("Data Criação").FontSize(9).SemiBold();
                });

                bool alternate = false;
                foreach (var secao in _secoes)
                {
                    var backgroundColor = alternate ? Colors.Grey.Lighten3 : Colors.White;
                    alternate = !alternate;

                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.id.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.nome).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.descricao).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.quantidade).FontSize(7);
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.funcionarioAlteracao.ToString()).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.dataAlteracao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                    table.Cell().Element(CellStyle).Background(backgroundColor).Text(secao.dataCriacao.ToString("yyyy/MM/dd")).FontSize(7).AlignRight();
                }
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeColumn().AlignLeft().Text("\u00a9 2024 - VarejoConnect").FontSize(10).Light();
                row.ConstantColumn(50).AlignRight().Text(text =>
                {
                    text.Span("P\u00e1gina ");
                    text.CurrentPageNumber();
                });
            });
        }

        private static IContainer CellStyle(IContainer container)
        {
            return container.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        }
    }
}
