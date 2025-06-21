using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class Devolucao
    {

        public int id { get; set; }
        public int vendaId { get; set; }
        public string motivo { get; set; }
        public DateTime datadevolucao { get; set; }
        public int funcionario { get; set; }
        public string funcionarioNome { get; set; }

        public Devolucao(){}

        public Devolucao(int id, int vendaId, string motivo, DateTime datadevolucao, int funcionario)
        {
            this.id = id;
            this.vendaId = vendaId;
            this.motivo = motivo;
            this.datadevolucao = datadevolucao;
            this.funcionario = funcionario;
        }
    }
}
