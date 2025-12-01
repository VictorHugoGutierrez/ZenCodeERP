using System.Data;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        public void Add(Movimentacao movimentacao)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO MOVIMENTACAO (CODEMPRESA, CODMOVIMENTACAO, STATUS, VALORTOTAL, CODUSUARIO, CODCLIFOR, TIPOMOVIMENTO, DATA, OBSERVACAO) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)",
                movimentacao.CODEMPRESA,
                movimentacao.CODMOVIMENTACAO,
                movimentacao.STATUS,
                movimentacao.VALORTOTAL,
                movimentacao.CODUSUARIO,
                movimentacao.CODCLIFOR,
                movimentacao.TIPOMOVIMENTO,
                movimentacao.DATA,
                movimentacao.OBSERVACAO);
        }

        public void Update(Movimentacao movimentacao)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE MOVIMENTACAO SET STATUS = ?, VALORTOTAL = ?, CODUSUARIO = ?, CODCLIFOR = ?, TIPOMOVIMENTO = ?, DATA = ?, OBSERVACAO = ? WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?",
                movimentacao.STATUS,
                movimentacao.VALORTOTAL,
                movimentacao.CODUSUARIO,
                movimentacao.CODCLIFOR,
                movimentacao.TIPOMOVIMENTO,
                movimentacao.DATA,
                movimentacao.OBSERVACAO,
                movimentacao.CODEMPRESA,
                movimentacao.CODMOVIMENTACAO);
        }

        public void Delete(int codEmpresa, int codMovimentacao)
        { 
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM MOVIMENTACAO WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", codEmpresa, codMovimentacao);
        }

        public Movimentacao GetByCodMovimentacao(int codEmpresa, int codMovimentacao)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM MOVIMENTACAO WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", codEmpresa, codMovimentacao);
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Movimentacao
            {
                CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                CODMOVIMENTACAO = Convert.ToInt32(row["CODMOVIMENTACAO"]),
                STATUS = Convert.ToInt32(row["STATUS"]),
                VALORTOTAL = Convert.ToDecimal(row["VALORTOTAL"]),
                CODUSUARIO = Convert.ToInt32(row["CODUSUARIO"]),
                CODCLIFOR = Convert.ToInt32(row["CODCLIFOR"]),
                TIPOMOVIMENTO = row["TIPOMOVIMENTO"].ToString(),
                DATA = Convert.ToDateTime(row["DATA"]),
                OBSERVACAO = row["OBSERVACAO"].ToString()
            };
        }

        public List<Movimentacao> GetAll(int codEmpresa)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM MOVIMENTACAO WHERE CODEMPRESA = ?", codEmpresa);
            List<Movimentacao> movimentacoes = new List<Movimentacao>();
            foreach (DataRow row in dataTable.Rows)
            {
                movimentacoes.Add(new Movimentacao
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    CODMOVIMENTACAO = Convert.ToInt32(row["CODMOVIMENTACAO"]),
                    STATUS = Convert.ToInt32(row["STATUS"]),
                    VALORTOTAL = Convert.ToDecimal(row["VALORTOTAL"]),
                    CODUSUARIO = Convert.ToInt32(row["CODUSUARIO"]),
                    CODCLIFOR = Convert.ToInt32(row["CODCLIFOR"]),
                    TIPOMOVIMENTO = row["TIPOMOVIMENTO"].ToString(),
                    DATA = Convert.ToDateTime(row["DATA"]),
                    OBSERVACAO = row["OBSERVACAO"].ToString()
                });
            }
            return movimentacoes;
        }

        public int GetNextCodMovimentacao(int codEmpresa)
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODMOVIMENTACAO), 0) + 1 FROM MOVIMENTACAO WHERE CODEMPRESA = ?", codEmpresa));
        }
    }
}
