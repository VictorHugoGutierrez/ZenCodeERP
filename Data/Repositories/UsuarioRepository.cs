using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;
using BCrypt.Net;

namespace ZenCodeERP.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Add(Usuario usuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO USUARIO (CODEMPRESA, CODUSUARIO, NOME, SENHA, ATIVO, ULTIMOLOGIN) VALUES (? ,? ,? ,? ,? ,?)",
                usuario.CODEMPRESA,
                usuario.CODUSUARIO,
                usuario.NOME,
                CriarHashBCrypt(usuario.SENHA),
                usuario.ATIVO,
                usuario.ULTIMOLOGIN);
        }

        public void Update(Usuario usuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE USUARIO SET CODEMPRESA = ?, NOME = ?, SENHA = ?, ATIVO = ?, ULTIMOLOGIN = ? WHERE CODUSUARIO = ?",
                usuario.CODEMPRESA,
                usuario.NOME,
                usuario.SENHA,
                usuario.ATIVO,
                usuario.ULTIMOLOGIN,
                usuario.CODUSUARIO);
        }

        public void Delete(string codUsuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM USUARIO WHERE CODUSUARIO = ?", codUsuario);
        }

        public Usuario GetByCodUsuario(string codUsuario)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM USUARIO WHERE CODUSUARIO = {codUsuario}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Usuario
            {
                CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                CODUSUARIO = row["CODUSUARIO"].ToString(),
                NOME = row["NOME"].ToString(),
                SENHA = row["SENHA"].ToString(),
                ATIVO = Convert.ToInt32(row["ATIVO"]),
                ULTIMOLOGIN = Convert.ToDateTime(row["ULTIMOLOGIN"])
            };
        }

        public List<Usuario> GetAll()
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery("SELECT * FROM USUARIO");
            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in dataTable.Rows)
            {
                usuarios.Add(new Usuario
                {
                    CODEMPRESA = Convert.ToInt32(row["CODEMPRESA"]),
                    CODUSUARIO = row["CODUSUARIO"].ToString(),
                    NOME = row["NOME"].ToString(),
                    SENHA = row["SENHA"].ToString(),
                    ATIVO = Convert.ToInt32(row["ATIVO"]),
                    ULTIMOLOGIN = Convert.ToDateTime(row["ULTIMOLOGIN"])
                });
            }
            return usuarios;
        }

        public string CriarHashBCrypt(string senha)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(senha, 12);

            return hash;
        }

        public bool VerificarSenhaBCrypt(string senhaDigitada, string hashArmazenado)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, hashArmazenado);
        }
    }
}
