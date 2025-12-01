using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class ClienteFornecedor
    {
        public int CODEMPRESA { get; set; }
        public int CODCLIFOR { get; set; }
        public string NOME { get; set; }
        public string NOMEFANTASIA { get; set; }
        public string CNPJCPF { get; set; }
        public string TELEFONE { get; set; }
        public int TIPOCADASTRO { get; set; }
        public int TIPOPESSOA { get; set; }
        public string EMAIL { get; set; }
        public int CODENDERECO { get; set; }
    }
}
