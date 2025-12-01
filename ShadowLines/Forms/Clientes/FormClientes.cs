using System;
using System.Windows.Forms;
using System.Linq;
using ShadowLines.Forms.Clientes;

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
            FormCadastroClientes cadastro = Application.OpenForms.OfType<FormCadastroClientes>().FirstOrDefault();


            if (cadastro == null)
            {
                cadastro = new FormCadastroClientes();
                cadastro.Show();
            }
            else
            {
                if (cadastro.WindowState == FormWindowState.Minimized)
                {
                    cadastro.MdiParent = this.MdiParent;
                    cadastro.WindowState = FormWindowState.Normal;
                }
                cadastro.Activate();
            }
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAlterarDadosCliente alterar = Application.OpenForms.OfType<FormAlterarDadosCliente>().FirstOrDefault();
            if (alterar == null)
            {
                alterar = new FormAlterarDadosCliente();
                alterar.Show();
            }
            else
            {
                if (alterar.WindowState == FormWindowState.Minimized)
                {
                    alterar.MdiParent = this.MdiParent;
                    alterar.WindowState = FormWindowState.Normal;
                }
                alterar.Activate();
            }
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirCliente cliente = Application.OpenForms.OfType<FormExcluirCliente>().FirstOrDefault();
            if (cliente == null)
            {
                cliente = new FormExcluirCliente();
                cliente.Show();
            }
            else
            {
                if (cliente.WindowState == FormWindowState.Minimized)
                {
                    cliente.MdiParent = this.MdiParent;
                    cliente.WindowState = FormWindowState.Normal;
                }
                cliente.Activate();
            }
        }

        private void visualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDadosClientes dados = new FormDadosClientes();
            dados.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu1 menu01 = new FormMenu1();
            menu01.Show();
            this.Hide();
        }

        private void clientesDevendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagamentoPendente pagamento = new FormPagamentoPendente();
            pagamento.Show();
            this.Hide();
        }

        private void cobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
