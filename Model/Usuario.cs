using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCodeERP.Model
{
    public class Usuario
    {
        public string CODUSUARIO { get; set; }
        public string USUARIO { get; set; }
        public string NOME { get; set; }
        public string SENHA { get; set; }
        public int ATIVO { get; set; }
        public DateTime ULTIMOLOGIN { get; set; }
    }
}
