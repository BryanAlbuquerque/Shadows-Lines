using System;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClientes cadastro = new FormCadastroClientes();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarDadosCliente update = new FormAlterarDadosCliente();
            update.MdiParent = this.MdiParent;
            update.Show();
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirCliente cliente = new FormExcluirCliente();
            cliente.MdiParent = this.MdiParent;
            cliente.Show();
        }

        private void visualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesDados dados = new FormClientesDados();
            dados.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu01 menu01 = new Menu01();
            menu01.Show();
            this.Hide();
        }

    }
}
