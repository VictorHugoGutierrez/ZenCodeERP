using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public void Add(Empresa empresa)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO EMPRESA (CODEMPRESA, NOMEFANTASIA, NOME, CNPJ, TELEFONE, EMAIL, CODENDERECO, IMAGEM) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.CODENDERECO, empresa.IMAGEM });
        }

        public void Update(Empresa empresa)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE EMPRESA SET CODEMPRESA = ?, NOMEFANTASIA = ?, NOME = ?, CNPJ = ?, TELEFONE = ?, EMAIL = ?, CODENDERECO = ?, IMAGEM = ?", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.CODENDERECO, empresa.IMAGEM });
        }
        
        public void Delete(int codEmpresa)
        {
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM EMPRESA WHERE CODEMPRESA = ?", codEmpresa);
        }

        public Empresa GetByCodEmpresa(int codEmpresa)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM EMPRESA WHERE CODEMPRESA = {codEmpresa}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Empresa
            {
                CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                NOMEFANTASIA = row["NOMEFANTASIA"].ToString(),
                NOME = row["NOME"].ToString(),
                CNPJ = row["CNPJ"].ToString(),
                TELEFONE = row["TELEFONE"].ToString(),
                EMAIL = row["EMAIL"].ToString(),
                CODENDERECO = Convert.ToInt32(row["CODENDERECO"]),
                IMAGEM = row["IMAGEM"].ToString()
            };
        }

        public List<Empresa> GetAll()
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM Empresa");
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
                    IMAGEM = row["IMAGEM"].ToString()
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
