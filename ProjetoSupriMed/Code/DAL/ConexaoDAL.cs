using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DAL
{
    public class ConexaoDAL
    {
        private String _strconexao;
        private SqlConnection _conexao;

        public ConexaoDAL(String dadosconexao)
        {
            this._conexao = new SqlConnection();
            this._strconexao = dadosconexao;
            this._conexao.ConnectionString = dadosconexao;
        }
        public String StringConexao
        {
            get
            {
                return this._strconexao;
            }
            set
            {
                this._strconexao = value;
            }
        }
        public SqlConnection Conexao
        {
            get
            {
                return this._conexao;
            }
            set
            {
                this._conexao = value;
            }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
