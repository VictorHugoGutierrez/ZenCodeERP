using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Data;

namespace ZenCodeERP.Utils
{
    public class Utilidades
    {
        public void GetVisao(DataGridView dataGridView, string coluna, string tabela, string relacionamento, string where)
        {
            try
            {
                string sSql = string.Concat("SELECT ", coluna, " FROM ", tabela, relacionamento, " WHERE ", where);

                DataTable dt = DataBaseConnection.Instance().ExecuteQuery(sSql);
                DataTable dtDicionario = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM DICIONARIO WHERE TABELA = '" + tabela + "'");   


                if(dtDicionario.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string col = dc.ColumnName;

                        DataRow[] dr = dtDicionario.Select("COLUNA = '" + col + "'");
                        if (dr.Length > 0)
                        {
                            dt.Columns[col].ColumnName = dr[0]["DESCRICAO"].ToString();
                        }
                    }
                }
                
                dataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }   
        }

    }
}
