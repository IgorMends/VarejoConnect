using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VarejoConnect.Model
{
    public class Venda
    {
        public int id{ get; set; }
        public double valorTotal{ get; set; }
        public string formaPagamento{  get; set; }
        public DateTime dataVenda{  get; set; }
        public int clienteVenda{ get; set; }
        public string clienteNome { get; set; }
        public int funcionarioVenda{ get; set; }
        public string funcionarioNome {  get; set; }

        public Venda(int id, double valorTotal, string formaPagamento, DateTime dataVenda, int clienteVenda, int funcionarioVenda)
        {
            this.id = id;
            this.valorTotal = valorTotal;
            this.formaPagamento = formaPagamento;
            this.dataVenda = dataVenda;
            this.clienteVenda = clienteVenda;
            this.funcionarioVenda = funcionarioVenda;
        }
        public Venda() { }  
    }
}
