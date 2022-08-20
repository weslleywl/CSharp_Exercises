using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar
{
    public partial class appcad : Form
    {
        public appcad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //levando os caracteres dos campos para o banco de dados
            Cadastro cad = new Cadastro(txtNome.Text, txtCpf.Text);
            MessageBox.Show(cad.mensagem);
            txtNome.Clear();
            txtCpf.Clear();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.Desconectar();
            Close();
        }

        private void calldel_Click(object sender, EventArgs e)
        {
            appDel del = new appDel();
            del.ShowDialog();
        }
    }
}
