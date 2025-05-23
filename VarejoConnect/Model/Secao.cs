using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class Secao
    {


        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int funcionarioAlteracao { get; set; }
        public string funcionarioNome { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public bool status { get; set; }

        public Secao() { }

        public Secao(int id, string nome, string descricao, int quantidade, int funcionarioAlteracao, DateTime dataAlteracao, DateTime dataCriacao, bool status)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.funcionarioAlteracao = funcionarioAlteracao;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.status = status;
        }
    }
}
