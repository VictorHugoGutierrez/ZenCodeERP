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
    public interface IClassificacaoRepository
    {
        void Add(Classificacao classificacao);
        void Update(Classificacao classificacao);
        void Delete(int codEmpresa, int codClassificacao);
        Classificacao GetByCodClassficacao(int codEmpresa, int codClassificacao);
        List<Classificacao> GetAll();
    }
}
