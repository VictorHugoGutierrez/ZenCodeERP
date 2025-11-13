using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public void Add(Endereco endereco)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO ENDERECO (CODENDERECO, NOME, RUA, NUMERO, COMPLEMENTO, BAIRRO, CEP, CIDADE, ESTADO, PAIS) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", new object[] { endereco.CODENDERECO, endereco.NOME, endereco.RUA, endereco.NUMERO, endereco.COMPLEMENTO, endereco.BAIRRO, endereco.CEP, endereco.CIDADE, endereco.ESTADO, endereco.PAIS });
        }

        public void Update(Endereco endereco)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE ENDERECO SET CODENDERECO = ?, NOME = ?, RUA = ?, NUMERO = ?, COMPLEMENTO = ?, BAIRRO = ?, CEP = ?, CIDADE = ?, ESTADO = ?, PAIS = ?", new object[] { endereco.CODENDERECO, endereco.NOME, endereco.RUA, endereco.NUMERO, endereco.COMPLEMENTO, endereco.BAIRRO, endereco.CEP, endereco.CIDADE, endereco.ESTADO, endereco.PAIS});
        }

        public void Delete(int codEndereco)
        {
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM ENDERECO WHERE CODENDERECO = ?", codEndereco);
        }

        public Endereco GetByCodEndereco(int codEndereco)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM ENDERECO WHERE CODENDERECO = {codEndereco}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Endereco
            {
                CODENDERECO = Convert.ToInt32(row["CODENDERECO"]),
                NOME = row["NOME"].ToString(),
                RUA = row["RUA"].ToString(),
                NUMERO = row["NUMERO"].ToString(),
                COMPLEMENTO = row["COMPLEMENTO"].ToString(),
                BAIRRO = row["BAIRRO"].ToString(),
                CEP = row["CEP"].ToString(),
                CIDADE = row["CIDADE"].ToString(),
                ESTADO = row["ESTADO"].ToString(),
                PAIS = row["PAIS"].ToString()
            };
        }

        public List<Endereco> GetAll()
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM ENDERECO");
            List<Endereco> endereco = new List<Endereco>();
            foreach (DataRow row in dataTable.Rows)
            {
                endereco.Add(new Endereco
                {
                    CODENDERECO = Convert.ToInt32(row["CODENDERECO"]),
                    NOME = row["NOME"].ToString(),
                    RUA = row["RUA"].ToString(),
                    NUMERO = row["NUMERO"].ToString(),
                    COMPLEMENTO = row["COMPLEMENTO"].ToString(),
                    BAIRRO = row["BAIRRO"].ToString(),
                    CEP = row["CEP"].ToString(),
                    CIDADE = row["CIDADE"].ToString(),
                    ESTADO = row["ESTADO"].ToString(),
                    PAIS = row["PAIS"].ToString()
                });
            }
            return endereco;
        }

        public int GetNextCodEndereco()
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODENDERECO), 0) + 1 FROM ENDERECO"));
        }
    }
}
