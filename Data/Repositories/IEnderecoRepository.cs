using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public interface IEnderecoRepository
    {
        void Add(Endereco endereco);
        void Update(Endereco endereco);
        void Delete(int codEndereco);
        Endereco GetByCodEndereco(int codEndereco);
        List<Endereco> GetAll();
    }
}
