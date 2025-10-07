using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public interface IEmpresaRepository
    {
        void Add(Empresa empresa);
        void Update(Empresa empresa);
        void Delete(int codEmpresa);
        Empresa GetByCodEmpresa(int CodEmpresa);
        List<Empresa> GetAll();
    }
}
