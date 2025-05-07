using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VarejoConnect.Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string empresa { get; set; }
        public string documento { get; set; }
        public string telefone { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int funcionarioAlteracao { get; set; }
        public bool status { get; set; }

        public Fornecedor() { }

        public Fornecedor(int id, string nome, string empresa, string documento, string telefone, int funcionarioAlteracao, DateTime dataAlteracao, DateTime dataCriacao, bool status)
        {
            this.id = id;
            this.nome = nome;
            this.empresa = empresa;
            this.documento = documento;
            this.telefone = telefone;
            this.funcionarioAlteracao = funcionarioAlteracao;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.status = status;
        }
    }
}
