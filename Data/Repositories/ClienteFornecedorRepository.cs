using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Mozilla;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Data.Repositories
{
    public class ClienteFornecedorRepository : IClienteFornecedorRepository
    {
        public void Add(ClienteFornecedor clientefornecedor)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO CLIENTEFORNECEDOR (CODEMPRESA, CODCLIFOR, NOME, NOMEFANTASIA, CNPJCPF, TELEFONE, TIPOCADASTRO, TIPOPESSOA, EMAIL, CODENDERECO) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", new object[] { clientefornecedor.CODEMPRESA, clientefornecedor.CODCLIFOR, clientefornecedor.NOME, clientefornecedor.NOMEFANTASIA, clientefornecedor.CNPJCPF, clientefornecedor.TELEFONE, clientefornecedor.TIPOCADASTRO, clientefornecedor.TIPOPESSOA, clientefornecedor.EMAIL, clientefornecedor.CODENDERECO });
        }

        public void Update(ClienteFornecedor clientefornecedor)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE CLIENTEFORNECEDOR SET NOME = ?, NOMEFANTASIA = ?, CNPJCPF = ?, TELEFONE = ?, TIPOCADASTRO = ?, TIPOPESSOA = ?, EMAIL = ?, CODENDERECO = ? WHERE CODEMPRESA = ? AND CODCLIFOR = ?", new object[] { clientefornecedor.NOME, clientefornecedor.NOMEFANTASIA, clientefornecedor.CNPJCPF, clientefornecedor.TELEFONE, clientefornecedor.TIPOCADASTRO, clientefornecedor.TIPOPESSOA, clientefornecedor.EMAIL, clientefornecedor.CODENDERECO, clientefornecedor.CODEMPRESA, clientefornecedor.CODCLIFOR });
        }

        public void Delete(int codEmpresa, int codCliFor)
        {
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM CLIENTEFORNECEDOR WHERE CODEMPRESA = ? AND CODCLIFOR = ?", codEmpresa, codCliFor);
        }

        public ClienteFornecedor GetByCodCliFor(int codEmpresa, int codCliFor)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM CLIENTEFORNECEDOR WHERE CODEMPRESA = {codEmpresa} AND CODCLIFOR = {codCliFor}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];


            return new ClienteFornecedor
            {
                CODEMPRESA = row["CODEMPRESA"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODEMPRESA"]),
                CODCLIFOR = row["CODCLIFOR"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODCLIFOR"]),
                NOME = row["NOME"] == DBNull.Value ? string.Empty : row["NOME"].ToString(),
                NOMEFANTASIA = row["NOMEFANTASIA"] == DBNull.Value ? string.Empty : row["NOMEFANTASIA"].ToString(),
                CNPJCPF = row["CNPJCPF"] == DBNull.Value ? string.Empty : row["CNPJCPF"].ToString(),
                TELEFONE = row["TELEFONE"] == DBNull.Value ? string.Empty : row["TELEFONE"].ToString(),
                TIPOCADASTRO = row["TIPOCADASTRO"] == DBNull.Value ? 0 : Convert.ToInt32(row["TIPOCADASTRO"]),
                TIPOPESSOA = row["TIPOPESSOA"] == DBNull.Value ? 0 : Convert.ToInt32(row["TIPOPESSOA"]),
                EMAIL = row["EMAIL"] == DBNull.Value ? string.Empty : row["EMAIL"].ToString(),
                CODENDERECO = row["CODENDERECO"] == DBNull.Value ? 0 : Convert.ToInt32(row["CODENDERECO"]),
            };
        }

        public List<ClienteFornecedor> GetAll(int codEmpresa)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM CLIENTEFORNECEDOR WHERE CODEMPRESA = ?", codEmpresa);
            List<ClienteFornecedor> clientefornecedor = new List<ClienteFornecedor>();
            foreach (DataRow row in dataTable.Rows)
            {
                clientefornecedor.Add(new ClienteFornecedor
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    CODCLIFOR = Convert.ToInt32(row["CODCLIFOR"]),
                    NOME = row["NOME"].ToString(),
                    NOMEFANTASIA = row["NOMEFANTASIA"].ToString(),
                    CNPJCPF = row["CNPJCPF"].ToString(),
                    TELEFONE = row["TELEFONE"].ToString(),
                    TIPOCADASTRO = Convert.ToInt32(row["TIPOCADASTRO"]),
                    TIPOPESSOA = Convert.ToInt32(row["TIPOPESSOA"]),
                    EMAIL = row["EMAIL"].ToString(),
                    CODENDERECO = Convert.ToInt32(row["CODENDERECO"]),
                });
            }
            return clientefornecedor;
        }

        public int GetNextCodCliFor(int codEmpresa)
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODCLIFOR), 0) + 1 FROM CLIENTEFORNECEDOR WHERE CODEMPRESA = ?", codEmpresa));
        }
    }
}
