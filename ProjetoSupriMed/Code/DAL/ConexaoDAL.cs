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
        private String _strconexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=123456";
        private SqlConnection _conexao;

        public ConexaoDAL()
        {
            this._conexao = new SqlConnection();


            this._conexao.ConnectionString = _strconexao;
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
