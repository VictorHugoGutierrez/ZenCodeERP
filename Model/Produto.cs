using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Produto
    {
        public int CODEMPRESA { get; set; }
        public int CODPRODUTO { get; set; }
        public int TIPO { get; set; }
        public int ATIVO { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public decimal PRECOUNITARIO { get; set; }
        public decimal CUSTO { get; set; }
        public decimal MARGEM { get; set; }
        public int CODCLASSIFICACAO { get; set; }
    }
}
