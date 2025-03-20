using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }     
        public string marca { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public int quantidade {  get; set; }
        public int funcionarioAlteracao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public bool status { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string marca, string descricao, double preco, int quantidade,int funcionarioAlteracao, DateTime dataAlteracao, DateTime dataCriacao, bool status)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            this.marca = marca;
            this.descricao = descricao; 
            this.funcionarioAlteracao = funcionarioAlteracao;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.status = status;
        }
    }
}
