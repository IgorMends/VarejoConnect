using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class ProdutoDevolucao
    {
        public int devolucaoId { get; set; }
        public int produtoId { get; set; }
        public int quantidade { get; set; }

        public ProdutoDevolucao() { }
        public ProdutoDevolucao(int devolucaoId, int produtoId, int quantidade)
        {
            this.devolucaoId = devolucaoId;
            this.produtoId = produtoId;
            this.quantidade = quantidade;
        }
    }
}
