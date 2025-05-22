using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model
{
    public class ProdutoVenda
    {
        int venda_fk {  get; set; }
        int produto_fk { get; set; }
        int quantidade  { get; set; }
        public ProdutoVenda() { }

        public ProdutoVenda(int venda_fk, int produto_fk, int quantidade)
        {
            this.venda_fk = venda_fk;
            this.produto_fk = produto_fk;
            this.quantidade = quantidade;
        }
    }
}
