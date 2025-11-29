using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int codEmpresa, int codProduto);
        Produto GetByCodProduto(int codEmpresa, int codProduto);
        List<Produto> GetAll(int codEmpresa);
    }
}
