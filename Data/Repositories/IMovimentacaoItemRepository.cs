using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public interface IMovimentacaoItemRepository
    {
        void Add(MovimentacaoItem movimentacaoItem);
        void Update(MovimentacaoItem movimentacaoItem);
        void Delete(int codEmpresa, int codMovimentacao, int codMovimentacaoItem);
        MovimentacaoItem GetByCodMovimentacaoItem(int codEmpresa, int codMovimentacao, int codMovimentacaoItem);
        List<MovimentacaoItem> GetAll(int codEmpresa, int codMovimentacao);
        int GetNextCodMovimentacaoItem(int codEmpresa, int codMovimentacao);
    }
}
