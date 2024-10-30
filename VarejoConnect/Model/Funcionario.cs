using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class Funcionario
    {
        public int id{ get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int funcionarioAlteracao { get; set; }


        public Funcionario() { }

        public Funcionario(int id, string login,string nome, string senha, string cargo, double salario, DateTime dataCriacao, DateTime dataAlteracao, int funcionarioAlteracao)
        {
            this.id = id;
            this.login = login;
            this.nome = nome;
            this.senha = senha;
            this.cargo = cargo;
            this.salario = salario;
            this.dataCriacao = dataCriacao;
            this.dataAlteracao = dataAlteracao;
            this.funcionarioAlteracao = funcionarioAlteracao;
        }
    }
}
