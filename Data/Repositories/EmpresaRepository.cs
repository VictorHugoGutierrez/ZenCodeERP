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
        private DataBaseConnection connection = new DataBaseConnection();

        public void Add(Empresa empresa)
        {
            connection.ExecuteTransaction("INSERT INTO EMPRESA (CODEMPRESA, NOMEFANTASIA, NOME, CNPJ, TELEFONE, EMAIL, RUA, NUMERO, COMPLEMENTO, BAIRRO, CEP, PAIS, IMAGEM) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.RUA, empresa.NUMERO, empresa.COMPLEMENTO, empresa.BAIRRO, empresa.CEP, empresa.PAIS, empresa.IMAGEM });
        }

        public void Update(Empresa empresa)
        {
            connection.ExecuteTransaction("UPDATE EMPRESA SET CODEMPRESA = ?, NOMEFANTASIA = ?, NOME = ?, CNPJ = ?, TELEFONE = ?, EMAIL = ?, RUA = ?, NUMERO = ?, COMPLEMENTO = ?, BAIRRO = ?, CEP = ?, PAIS = ?, IMAGEM = ?", new object[] { empresa.CODEMPRESA, empresa.NOMEFANTASIA, empresa.NOME, empresa.CNPJ, empresa.TELEFONE, empresa.EMAIL, empresa.RUA, empresa.NUMERO, empresa.COMPLEMENTO, empresa.BAIRRO, empresa.CEP, empresa.PAIS, empresa.IMAGEM });
        }
        
        public void Delete(int codEmpresa)
        {
            connection.ExecuteTransaction("DELETE FROM EMPRESA WHERE CODEMPRESA = ?", codEmpresa);
        }

        public Empresa GetByCodEmpresa(int codEmpresa)
        {
            DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM EMPRESA WHERE CODEMPRESA = {codEmpresa}");
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
                RUA = row["RUA"].ToString(),
                NUMERO = row["NUMERO"].ToString(),
                COMPLEMENTO = row["COMPLEMENTO"].ToString(),
                BAIRRO = row["BAIRRO"].ToString(),
                CEP = row["CEP"].ToString(),
                PAIS = row["PAIS"].ToString(),
                IMAGEM = row["IMAGEM"].ToString()
            };
        }

        public List<Empresa> GetAll()
        {
            DataTable dataTable = connection.ExecuteQuery("SELECT * FROM Empresa");
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
                    RUA = row["RUA"].ToString(),
                    NUMERO = row["NUMERO"].ToString(),
                    COMPLEMENTO = row["COMPLEMENTO"].ToString(),
                    BAIRRO = row["BAIRRO"].ToString(),
                    CEP = row["CEP"].ToString(),
                    PAIS = row["PAIS"].ToString(),
                    IMAGEM = row["IMAGEM"].ToString()
                });
            }
            return empresa;
        }
    }
}
