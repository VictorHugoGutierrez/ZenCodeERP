using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class MovimentacaoItem
    {
        public int CODEMPRESA { get; set; }
        public int CODMOVIMENTACAO { get; set; }
        public int CODMOVIMENTACAOITEM { get; set; }
        public int CODPRODUTO { get; set; }
        public decimal QUANTIDADE { get; set; }
        public decimal VALORUNITARIO { get; set; }
        public decimal CUSTOUNITARIO { get; set; }
        public decimal VALORTOTAL { get; set; }
    }
}
