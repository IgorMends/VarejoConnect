using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VarejoConnect.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public string email { get; set; }  
        public string telefone { get; set; }
        public int funcionarioAlteracao { get; set; }
        public string funcionarioNome { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public bool status { get; set; }

        public Cliente() { }

        public Cliente(int id, string nome, string documento, string email, string telefone, DateTime dataAlteracao, DateTime dataCriacao ,int funcionarioAlteracao, bool status)
        {
            this.id = id;
            this.nome = nome;
            this.documento = documento;
            this.email = email;
            this.telefone = telefone;
            this.funcionarioAlteracao = funcionarioAlteracao;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.status = status;
        }
    }
}
