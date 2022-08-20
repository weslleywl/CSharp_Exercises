using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar
{
    class Deletar
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string mensagem = "";
        public Deletar(string nome,string cpf)
        {
            cmd.CommandText = @"Delete from Clientes Where nome = @nome and CPF = @cpf";
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@cpf",cpf);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                mensagem = "Pessoa deletada com Sucesso !";
            }
            catch (SqlException e)
            {
                mensagem = "Pessoa não encontrada !";
            }
        }
    }
}
