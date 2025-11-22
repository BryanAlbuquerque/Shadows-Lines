using ShadowLines.Classes;
using System;
using System.Windows.Forms;
using ShadowLines.Forms;

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
    }
}
