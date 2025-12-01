using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public interface IMovimentacaoRepository
    {
        void Add(Movimentacao movimentacao);
        void Update(Movimentacao movimentacao);
        void Delete(int codEmpresa, int codMovimentacao);
        Movimentacao GetByCodMovimentacao(int codEmpresa, int codMovimentacao);
        List<Movimentacao> GetAll(int codEmpresa);
        int GetNextCodMovimentacao(int codEmpresa);
    }
}
