using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Data.Repositories
{
    public interface IClienteFornecedorRepository
    {
        void Add(ClienteFornecedor cliente);
        void Update(ClienteFornecedor cliente);
        void Delete(int codEmpresa, int codCliFor);
        ClienteFornecedor GetByCodCliFor(int codEmpresa, int CodCliFor);
        List<ClienteFornecedor> GetAll(int codEmpresa);
        int GetNextCodCliFor(int codEmpresa);
    }
}
