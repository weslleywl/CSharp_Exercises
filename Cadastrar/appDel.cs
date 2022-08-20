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
    public partial class appDel : Form
    {
        public appDel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Deletar del = new Deletar(delNome.Text,delCpf.Text);
            MessageBox.Show(del.mensagem);
        }
    }
}
