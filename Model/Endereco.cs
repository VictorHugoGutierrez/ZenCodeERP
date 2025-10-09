using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Endereco
    {
        private int CODENDERECO { get; set; }
        private string RUA { get; set; }
        private string NUMERO { get; set; }
        private string COMPLEMENTO { get; set; }
        private string BAIRRO { get; set; }
        private string CEP { get; set; }
        private string CIDADE { get; set; } 
        private string ESTADO { get; set; }
        private string PAIS { get; set; }
    }
}
