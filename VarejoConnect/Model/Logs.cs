using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class Logs
    {

        public DateTime dataHora { get; set; }

        public int funcionario { get; set; }

        public string entidade { get; set; }

        public int? entidadeId { get; set; }

        public string acao { get; set; }

        public Logs() { }
        public Logs( DateTime dataHora, int funcionario, string entidade, int? entidadeId, string acao)
        {
            this.dataHora = dataHora;
            this.funcionario = funcionario;
            this.entidade = entidade;
            this.entidadeId = entidadeId;
            this.acao = acao;
        }
    }
}
