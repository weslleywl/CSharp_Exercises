using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar
{
    class Cadastro
    {
        //instanciando objetos internos para trabalhar com o sql
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";
        public Cadastro(string nome,string cpf)
        {
            //o comando que sera executado no sql server
            cmd.CommandText = "Insert into Clientes (Nome, CPF) values (@nome,@cpf)";
            //os parametros que o campo vai receber
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@cpf",cpf);
            try
            {
                //conectar com o banco
                cmd.Connection = conexao.Conectar();
                //executar o comando dos parametros
                cmd.ExecuteNonQuery();
                //desconectar com o banco
                conexao.Desconectar();
                //mensagem de erro ou sucesso
                mensagem = "Cadastrado com Sucesso !";
            }
            catch (SqlException e)
            {
                mensagem = "Nao foi possivel conectar-se ao Banco";

            }
        }
    }
}
