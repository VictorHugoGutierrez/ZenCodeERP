using System.Data;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class MovimentacaoItemRepository : IMovimentacaoItemRepository
    {
        public void Add(MovimentacaoItem movimentacaoItem)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO MOVIMENTACAOITEM (CODEMPRESA, CODMOVIMENTACAO, CODMOVIMENTACAOITEM, CODPRODUTO, QUANTIDADE, VALORUNITARIO, VALORTOTAL) VALUES (?, ?, ?, ?, ?, ?, ?)",
                movimentacaoItem.CODEMPRESA,
                movimentacaoItem.CODMOVIMENTACAO,
                movimentacaoItem.CODMOVIMENTACAOITEM,
                movimentacaoItem.CODPRODUTO,
                movimentacaoItem.QUANTIDADE,
                movimentacaoItem.VALORUNITARIO,
                movimentacaoItem.VALORTOTAL);
        }

        public void Update(MovimentacaoItem movimentacaoItem)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE MOVIMENTACAOITEM SET CODPRODUTO = ?, QUANTIDADE = ?, VALORUNITARIO = ?, VALORTOTAL = ? WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ? AND CODMOVIMENTACAOITEM = ?",
                movimentacaoItem.CODPRODUTO,
                movimentacaoItem.QUANTIDADE,
                movimentacaoItem.VALORUNITARIO,
                movimentacaoItem.VALORTOTAL,
                movimentacaoItem.CODEMPRESA,
                movimentacaoItem.CODMOVIMENTACAO,
                movimentacaoItem.CODMOVIMENTACAOITEM);
        }

        public void Delete(int codEmpresa, int codMovimentacao, int codMovimentacaoItem)
        { 
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM MOVIMENTACAOITEM WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ? AND CODMOVIMENTACAOITEM = ?", codEmpresa, codMovimentacao, codMovimentacaoItem);
        }

        public MovimentacaoItem GetByCodMovimentacaoItem(int codEmpresa, int codMovimentacao, int codMovimentacaoItem)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM MOVIMENTACAOITEM WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ? AND CODMOVIMENTACAOITEM = ?", codEmpresa, codMovimentacao, codMovimentacaoItem);
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new MovimentacaoItem
            {
                CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                CODMOVIMENTACAO = Convert.ToInt32(row["CODMOVIMENTACAO"]),
                CODMOVIMENTACAOITEM = Convert.ToInt32(row["CODMOVIMENTACAOITEM"]),
                CODPRODUTO = Convert.ToInt32(row["CODPRODUTO"]),
                QUANTIDADE = Convert.ToDecimal(row["QUANTIDADE"]),
                VALORUNITARIO = Convert.ToDecimal(row["VALORUNITARIO"]),
                VALORTOTAL = Convert.ToDecimal(row["VALORTOTAL"])
            };
        }

        public List<MovimentacaoItem> GetAll(int codEmpresa, int codMovimentacao)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM MOVIMENTACAOITEM WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", codEmpresa, codMovimentacao);
            List<MovimentacaoItem> movimentacaoItems = new List<MovimentacaoItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                movimentacaoItems.Add(new MovimentacaoItem
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    CODMOVIMENTACAO = Convert.ToInt32(row["CODMOVIMENTACAO"]),
                    CODMOVIMENTACAOITEM = Convert.ToInt32(row["CODMOVIMENTACAOITEM"]),
                    CODPRODUTO = Convert.ToInt32(row["CODPRODUTO"]),
                    QUANTIDADE = Convert.ToDecimal(row["QUANTIDADE"]),
                    VALORUNITARIO = Convert.ToDecimal(row["VALORUNITARIO"]),
                    VALORTOTAL = Convert.ToDecimal(row["VALORTOTAL"])
                });
            }
            return movimentacaoItems;
        }

        public int GetNextCodMovimentacaoItem(int codEmpresa, int codMovimentacao)
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODMOVIMENTACAOITEM), 0) + 1 FROM MOVIMENTACAOITEM WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", codEmpresa, codMovimentacao));
        }
    }
}
