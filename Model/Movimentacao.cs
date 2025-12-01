using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Movimentacao
    {
        public int CODEMPRESA { get; set; }
        public int CODMOVIMENTACAO { get; set; }
        public int STATUS { get; set; }
        public decimal VALORTOTAL { get; set; }
        public int CODUSUARIO { get; set; }
        public int CODCLIFOR { get; set; }
        public string TIPOMOVIMENTO { get; set; }
        public DateTime DATA { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
