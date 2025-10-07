using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Empresa
    {
        public int CODEMPRESA { get; set; }
        public string NOMEFANTASIA { get; set; }
        public string NOME { get; set; }
        public string CNPJ { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }
        public string RUA { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public string PAIS { get; set; }
        public string IMAGEM { get; set; }
    }
}
