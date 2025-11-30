using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Mozilla;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Data.Repositories
{
    public class ClassificacaoRepository : IClassificacaoRepository
    {
        public void Add(Classificacao classificacao)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO CLASSIFICACAO (CODEMPRESA, CODCLASSIFICACAO, NOME, DESCRICAO) VALUES (?, ?, ?, ?)", new object[] { classificacao.CODEMPRESA, classificacao.CODCLASSIFICACAO, classificacao.NOME, classificacao.DESCRICAO});
        }

        public void Update(Classificacao classificacao)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE CLASSIFICACAO SET NOME = ?, DESCRICAO = ? WHERE CODCLASSIFICACAO = ? AND CODEMPRESA = ?", new object[] { classificacao.NOME, classificacao.DESCRICAO, classificacao.CODCLASSIFICACAO, classificacao.CODEMPRESA });
        }

        public void Delete(int codEmpresa, int codClassificacao)
        {
            try
            {
                DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM CLASSIFICACAO WHERE CODCLASSIFICACAO = ? AND CODEMPRESA = ?", codClassificacao, codEmpresa);

                MessageBox.Show("Classificação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Não é possível excluir esta classificação pois ela já está sendo usada em outros cadastros.\n\n" +
                                    "Exclua os itens vinculados antes de tentar excluir a classificação.",
                                    "Ação Bloqueada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Classificacao GetByCodClassficacao(int codEmpresa, int codClassificacao)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM CLASSIFICACAO WHERE CODEMPRESA = {codEmpresa} AND CODCLASSIFICACAO = {codClassificacao}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];


            return new Classificacao
            {
                CODEMPRESA = row["CODEMPRESA"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODEMPRESA"]),
                CODCLASSIFICACAO = row["CODCLASSIFICACAO"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODCLASSIFICACAO"]),
                NOME = row["NOME"] == DBNull.Value ? string.Empty : row["NOME"].ToString(),
                DESCRICAO = row["DESCRICAO"] == DBNull.Value ? string.Empty : row["DESCRICAO"].ToString(),  
            };
        }

        public List<Classificacao> GetAll()
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM CLASSIFICACAO");
            List<Classificacao> classificacao = new List<Classificacao>();
            foreach (DataRow row in dataTable.Rows)
            {
                classificacao.Add(new Classificacao
                {
                    CODEMPRESA = row["CODEMPRESA"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODEMPRESA"]),
                    CODCLASSIFICACAO = row["CODCLASSIFICACAO"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODCLASSIFICACAO"]),
                    NOME = row["NOME"] == DBNull.Value ? string.Empty : row["NOME"].ToString(),
                    DESCRICAO = row["DESCRICAO"] == DBNull.Value ? string.Empty : row["DESCRICAO"].ToString(),
                });
            }
            return classificacao;
        }

        public int GetNextCodEmpresa()
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODEMPRESA), 0) + 1 FROM CLASSIFICACAO"));
        }
        public int GetNextCodClassificacao(int codEmpresa)
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODCLASSIFICACAO), 0) + 1 FROM CLASSIFICACAO WHERE CODEMPRESA = ?", codEmpresa));
        }


    }
}
