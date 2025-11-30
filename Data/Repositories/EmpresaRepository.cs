using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Data.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public void Add(Empresa empresa)
        {
            byte[] imagem = new Utilidades().ConverterFotoParaByteArray(empresa.IMAGEM);

            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO EMPRESA (CODEMPRESA, NOMEFANTASIA, NOME, CNPJ, TELEFONE, EMAIL, CODENDERECO, IMAGEM) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.CODENDERECO, imagem });
        }

        public void Update(Empresa empresa)
        {
            byte[] imagem = new Utilidades().ConverterFotoParaByteArray(empresa.IMAGEM);

            DataBaseConnection.Instance().ExecuteTransaction("UPDATE EMPRESA SET CODEMPRESA = ?, NOMEFANTASIA = ?, NOME = ?, CNPJ = ?, TELEFONE = ?, EMAIL = ?, CODENDERECO = ?, IMAGEM = ?", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.CODENDERECO, imagem });
        }
        
        public void Delete(int codEmpresa)
        {
            try
            {
                DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM EMPRESA WHERE CODEMPRESA = ?", codEmpresa);

                MessageBox.Show("Empresa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("CRÍTICO: Não é possível excluir esta Empresa pois existem dados vinculados a ela.\n",
                                    "Ação Proibida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop); 
                }
                else
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Empresa GetByCodEmpresa(int codEmpresa)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM EMPRESA WHERE CODEMPRESA = {codEmpresa}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];

            byte[] imagemBytes = row["IMAGEM"] == DBNull.Value ? null : (byte[])row["IMAGEM"];
            Image image = new Utilidades().ConverterByteArrayParaFoto(imagemBytes);

            return new Empresa
            {
                CODEMPRESA = row["CODEMPRESA"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODEMPRESA"]),
                NOMEFANTASIA = row["NOMEFANTASIA"] == DBNull.Value ? string.Empty : row["NOMEFANTASIA"].ToString(),
                NOME = row["NOME"] == DBNull.Value ? string.Empty : row["NOME"].ToString(),
                CNPJ = row["CNPJ"] == DBNull.Value ? string.Empty : row["CNPJ"].ToString(),
                TELEFONE = row["TELEFONE"] == DBNull.Value ? string.Empty : row["TELEFONE"].ToString(),
                EMAIL = row["EMAIL"] == DBNull.Value ? string.Empty : row["EMAIL"].ToString(),
                CODENDERECO = row["CODENDERECO"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODENDERECO"]),
                IMAGEM = image,
            };
        }

        public List<Empresa> GetAll()
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM EMPRESA");
            List<Empresa> empresa = new List<Empresa>();
            foreach (DataRow row in dataTable.Rows)
            {
                empresa.Add(new Empresa
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    NOMEFANTASIA = row["NOMEFANTASIA"].ToString(),
                    NOME = row["NOME"].ToString(),
                    CNPJ = row["CNPJ"].ToString(),
                    TELEFONE = row["TELEFONE"].ToString(),
                    EMAIL = row["EMAIL"].ToString(),
                    CODENDERECO = Convert.ToInt32(row["CODENDERECO"]),
                });
            }
            return empresa;
        }

        public int GetNextCodEmpresa()
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODEMPRESA), 0) + 1 FROM EMPRESA"));
        }
    }
}
