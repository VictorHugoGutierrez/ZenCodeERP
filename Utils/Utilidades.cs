using System.Data;
using System.Drawing.Imaging;
using System.IO;
using ZenCodeERP.Data;

namespace ZenCodeERP.Utils
{
    public class Utilidades
    {
        public void GetVisao(DataGridView dataGridView, string coluna, string tabela, string relacionamento, string where)
        {
            try
            {
                DataTable dtDicionario = DataBaseConnection.Instance().ExecuteQuery("SELECT COLUNA, DESCRICAO FROM DICIONARIO WHERE TABELA = '" + tabela + "'");

                Dictionary<string, string> regrasPersonalizadas = CarregaColunasPersonalizadas(tabela);

                List<string> listaColunasSql = new List<string>();

                List<string> colunas = new List<string>();

                if (!string.IsNullOrEmpty(coluna) && coluna.Trim() != "*")
                {
                    colunas = coluna.Split(',')
                                        .Select(c => c.Trim())
                                        .ToList();
                }

                foreach (string nomeColuna in colunas)
                {
                    if (regrasPersonalizadas.ContainsKey(nomeColuna))
                    {
                        listaColunasSql.Add(regrasPersonalizadas[nomeColuna]);
                    }
                    else
                    {
                        listaColunasSql.Add(nomeColuna);
                    }
                }

                if (listaColunasSql.Count == 0) listaColunasSql.Add("*");

                coluna = string.Join(", ", listaColunasSql);

                DataTable dt = DataBaseConnection.Instance().ExecuteQuery(string.Concat("SELECT ", coluna, " FROM ", tabela, " ", relacionamento, " WHERE ", where));

                if (dtDicionario.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string colName = dc.ColumnName;

                        DataRow[] dr = dtDicionario.Select("COLUNA = '" + colName + "'");
                        if (dr.Length > 0)
                        {
                            dc.ColumnName = dr[0]["DESCRICAO"].ToString();
                        }
                    }
                }

                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dictionary<string, string> CarregaColunasPersonalizadas(string tabela)
        {
            Dictionary<string, string> regras = new Dictionary<string, string>();

            if (tabela == "CLIENTEFORNECEDOR")
            {
                regras.Add("TIPOCADASTRO",
                    @"(CASE TIPOCADASTRO 
                WHEN 0 THEN 'Cliente' 
                WHEN 1 THEN 'Fornecedor' 
                WHEN 2 THEN 'Ambos'
              END) AS TIPOCADASTRO");

                regras.Add("TIPOPESSOA",
                    @"(CASE TIPOPESSOA 
                WHEN 0 THEN 'Física' 
                WHEN 1 THEN 'Jurídica' 
              END) AS TIPOPESSOA");
            }

            return regras;
        }

        public byte[] ConverterFotoParaByteArray(Image image)
        {
            if (image == null)
                return null;

            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }

        public Image ConverterByteArrayParaFoto(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            MemoryStream ms = new MemoryStream(byteArray);
            return Image.FromStream(ms);
        }

    }
}
