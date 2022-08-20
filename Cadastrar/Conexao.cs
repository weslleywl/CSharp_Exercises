using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar
{
    class Conexao
    {
        //estabelecendo conexao com sql
        SqlConnection connection = new SqlConnection();
        public Conexao()
        {
            connection.ConnectionString = @"Data Source=WESLLEYPC\SQLEXPRESS;Initial Catalog=Teste;User ID=sa;Password=123456";
        }
        public SqlConnection Conectar()
        {
            //evitando a conexao do sql caso ja esteja ativado
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
