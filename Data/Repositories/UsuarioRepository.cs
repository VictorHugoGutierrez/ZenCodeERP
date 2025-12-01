using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;
using ZenCodeERP.Model;

namespace ZenCodeERP.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Add(Usuario usuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("INSERT INTO USUARIO (CODUSUARIO, USUARIO, NOME, SENHA, ATIVO, ULTIMOLOGIN) VALUES (? ,? ,? ,? ,? ,?)",
                usuario.CODUSUARIO,
                usuario.USUARIO,
                usuario.NOME,
                CriarHashBCrypt(usuario.SENHA),
                usuario.ATIVO,
                usuario.ULTIMOLOGIN);
        }

        public void Update(Usuario usuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE USUARIO SET NOME = ?, USUARIO = ?, SENHA = ?, ATIVO = ?, ULTIMOLOGIN = ? WHERE CODUSUARIO = ?",
                usuario.NOME,
                usuario.USUARIO,
                CriarHashBCrypt(usuario.SENHA),
                usuario.ATIVO,
                usuario.ULTIMOLOGIN,
                usuario.CODUSUARIO);
        }

        public void Delete(int codUsuario)
        {
            

            try
            {
                DataBaseConnection.Instance().ExecuteTransaction("DELETE FROM USUARIO WHERE CODUSUARIO = ?", codUsuario);

                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Não é possível excluir este usuário pois existem movimentações associadas a ele.",
                            "Atenção",
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

        public Usuario GetByCodUsuario(int codUsuario)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM USUARIO WHERE CODUSUARIO = {codUsuario}");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Usuario
            {
                CODUSUARIO = Convert.ToInt32(row["CODUSUARIO"]),
                USUARIO = row["USUARIO"].ToString(),
                NOME = row["NOME"].ToString(),
                SENHA = row["SENHA"].ToString(),
                ATIVO = Convert.ToInt32(row["ATIVO"]),
                ULTIMOLOGIN = Convert.ToDateTime(row["ULTIMOLOGIN"])
            };
        }

        public Usuario GetByUsuario(string usuario)
        {
            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery($"SELECT * FROM USUARIO WHERE USUARIO = '{usuario}'");
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];
            return new Usuario
            {
                CODUSUARIO = Convert.ToInt32(row["CODUSUARIO"]),
                USUARIO = row["USUARIO"].ToString(),
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
                    CODUSUARIO = Convert.ToInt32(row["CODUSUARIO"]),
                    USUARIO = row["USUARIO"].ToString(),
                    NOME = row["NOME"].ToString(),
                    SENHA = row["SENHA"].ToString(),
                    ATIVO = Convert.ToInt32(row["ATIVO"]),
                    ULTIMOLOGIN = Convert.ToDateTime(row["ULTIMOLOGIN"])
                });
            }
            return usuarios;
        }

        public int GetNextCodUsuario()
        {
            return Convert.ToInt32(DataBaseConnection.Instance().ExecuteGetField("SELECT COALESCE(MAX(CODUSUARIO), 0) + 1 FROM USUARIO"));
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

        public void AtualizaUltimoLogin(int codUsuario)
        {
            DataBaseConnection.Instance().ExecuteTransaction("UPDATE USUARIO SET ULTIMOLOGIN = ? WHERE CODUSUARIO = ?", DateTime.Now, codUsuario);
        }
    }
}
