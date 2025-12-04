using ShadowLines.Classes;
using ShadowLines.Forms.Clientes;
using System;
using System.Linq;
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
            if (SessaoUsuarioModel.NivelAcesso == 1)
            {
                FormNivelAcesso1 menu = new FormNivelAcesso1();
                menu.Show();
                this.Hide();
            }
            else if (SessaoUsuarioModel.NivelAcesso == 2)
            {
                FormNivelAcesso2 menu = new FormNivelAcesso2();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro: Nível de acesso inválido. Contate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesDevendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagamentoPendente pagamento = new FormPagamentoPendente();
            pagamento.Show();
            this.Hide();
        }

        private void cobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCobranca cobranca = Application.OpenForms.OfType<FormCobranca>().FirstOrDefault();
            if (cobranca == null)
            {
                cobranca = new FormCobranca();
                cobranca.Show();
            }
            else
            {
                if (cobranca.WindowState == FormWindowState.Minimized)
                {
                    cobranca.MdiParent = this.MdiParent;
                    cobranca.WindowState = FormWindowState.Normal;
                }
                cobranca.Activate();
            }
        }
    }
}
