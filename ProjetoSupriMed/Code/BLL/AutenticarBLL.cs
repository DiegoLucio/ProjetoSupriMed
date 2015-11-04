using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSupriMed.Code.DAL;
using System.Data;
using ProjetoSupriMed.Code.DTO;
using System.Data.SqlClient;

namespace ProjetoSupriMed.Code.BLL
{
    public class AutenticarBLL
    {
        private readonly string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=123456";
        public bool AutenticarUsuario(LoginDTO login)
        {
            try
            {
                ConexaoDAL conexaodao = new ConexaoDAL(conn);

                SqlCommand cmd = new SqlCommand("select * from LOGIN where LOG_USUARIO = @LOG_USUARIO AND LOG_SENHA = @LOG_SENHA", conexaodao.Conexao);

                SqlParameter parametroUsuario = new SqlParameter("@LOG_USUARIO", SqlDbType.VarChar, 50);
                parametroUsuario.Value = login.LOG_USUARIO;
                cmd.Parameters.Add(parametroUsuario);

                SqlParameter parametroSenha = new SqlParameter("@LOG_SENHA", SqlDbType.VarChar, 6);
                parametroSenha.Value = login.LOG_SENHA;
                cmd.Parameters.Add(parametroSenha);

                conexaodao.Conexao.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //usuario existe
                    return true;
                }
                else
                {
                    //usuario nao existe
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}
