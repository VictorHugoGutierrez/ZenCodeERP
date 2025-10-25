using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Endereco
    {
        public int CODENDERECO { get; set; }

        public string NOME { get; set; }
        public string RUA { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; } 
        public string ESTADO { get; set; }
        public string PAIS { get; set; }
    }
}
