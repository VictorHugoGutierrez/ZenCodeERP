using Org.BouncyCastle.X509;
using System.Data;
using MySql.Data.MySqlClient;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Add(Produto produto)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO PRODUTO (CODEMPRESA, CODPRODUTO, TIPO, ATIVO, NOME, DESCRICAO, PRECOUNITARIO, CODCLASSIFICACAO, CUSTO, MARGEM) VALUES (?, ? ,? ,? ,? ,? ,? ,?, ?, ?)",
                produto.CODEMPRESA,
                produto.CODPRODUTO,
                produto.TIPO,
                produto.ATIVO,
                produto.NOME,
                produto.DESCRICAO,
                produto.PRECOUNITARIO,
                produto.CODCLASSIFICACAO,
                produto.CUSTO,
                produto.MARGEM);
        }

        public void Update(Produto produto)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE PRODUTO SET TIPO = ?, ATIVO = ?, NOME = ?, DESCRICAO = ?, PRECOUNITARIO = ?, CODCLASSIFICACAO = ?, CUSTO = ?, MARGEM = ? WHERE CODEMPRESA = ? AND CODPRODUTO = ?",
                produto.TIPO,
                produto.ATIVO,
                produto.NOME,
                produto.DESCRICAO,
                produto.PRECOUNITARIO,
                produto.CODCLASSIFICACAO,
                produto.CUSTO,
                produto.MARGEM,
                produto.CODEMPRESA,
                produto.CODPRODUTO);
        }

        public void Delete(int codEmpresa, int codProduto)
        {
            try
            {
                string sql = "DELETE FROM PRODUTO WHERE CODPRODUTO = @p0 AND CODEMPRESA = @p1";

                DataBaseConnection.Instance().ExecuteTransaction(sql, codProduto, codEmpresa);

                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Não é possível excluir este Produto pois ele já possui movimentações.\n",
                                    "Produto em Uso",
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

        public Produto GetByCodProduto(int codEmpresa, int codProduto)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM PRODUTO WHERE CODEMPRESA = ? AND CODPRODUTO = ?", codEmpresa, codProduto);
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Produto
            {
                CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                CODPRODUTO = Convert.ToInt32(row["CODPRODUTO"]),
                TIPO = Convert.ToInt32(row["TIPO"]),
                ATIVO = Convert.ToInt32(row["ATIVO"]),
                NOME = row["NOME"].ToString(),
                DESCRICAO = row["DESCRICAO"].ToString(),
                PRECOUNITARIO = Convert.ToDecimal(row["PRECOUNITARIO"]),
                CODCLASSIFICACAO = Convert.ToInt32(row["CODCLASSIFICACAO"]),
                CUSTO = Convert.ToDecimal(row["CUSTO"]),
                MARGEM = Convert.ToDecimal(row["MARGEM"])
            };
        }

        public List<Produto> GetAll(int codEmpresa)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM PRODUTO WHERE CODEMPRESA = ?", codEmpresa);
            List<Produto> produtos = new List<Produto>();
            foreach (DataRow row in dataTable.Rows)
            {
                produtos.Add(new Produto
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    CODPRODUTO = Convert.ToInt32(row["CODPRODUTO"]),
                    TIPO = Convert.ToInt32(row["TIPO"]),
                    ATIVO = Convert.ToInt32(row["ATIVO"]),
                    NOME = row["NOME"].ToString(),
                    DESCRICAO = row["DESCRICAO"].ToString(),
                    PRECOUNITARIO = Convert.ToDecimal(row["PRECOUNITARIO"]),
                    CODCLASSIFICACAO = Convert.ToInt32(row["CODCLASSIFICACAO"]),
                    CUSTO = Convert.ToDecimal(row["CUSTO"]),
                    MARGEM = Convert.ToDecimal(row["MARGEM"])
                });
            }
            return produtos;
        }

        public int GetNextCodProduto(int codEmpresa)
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODPRODUTO), 0) + 1 FROM PRODUTO WHERE CODEMPRESA = ?", codEmpresa));
        }
    }
}
