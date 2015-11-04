using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DAL
{
    public class AcessoBanco
    {
        private SqlConnection conn;
        private DataTable data;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private SqlCommandBuilder cb;


        /// <summary>
        /// Metodo para realizar conexão no banco de dados Sql Server
        /// </summary>
        public void Conectar()
        {

            if (conn != null)
                conn.Close();

            string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=123456";

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Metodo para realizar comando SQL como: Insert,Delet,Update
        /// </summary>
        /// <param name="comandoSql"></param>
        public void ExecutarComandoSQL(string comandoSql)
        {

            SqlCommand cmd = new SqlCommand(comandoSql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Metodo para retornar um conjunto de dados para um grid ou comboBox
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        /// <summary>
        /// Metodo para retornar um conjunto de dados para somente leitura que só move pra frente
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader RetDataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            return dr;
        }

    }
}
