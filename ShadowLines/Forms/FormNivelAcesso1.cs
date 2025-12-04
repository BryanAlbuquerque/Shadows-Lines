using ShadowLines.Classes;
using ShadowLines.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormNivelAcesso1 : Form
    {
        private Panel painelAgendamentosUI;
        private Panel painelCanceladosDiaUI;
        private Panel painelTotalAgendamentosUI;
        private Panel painelValorTotalDiarioUI;

        public FormNivelAcesso1()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                    break;
                }
            }

            painelAgendamentosUI = new PainelAgendamentosUI().CriarPainel();
            painelCanceladosDiaUI = new PainelCanceladosDiaUI().CriarPainel();
            painelTotalAgendamentosUI = new PainelTotalAgendamentosUI().CriarPainel();
            painelValorTotalDiarioUI = new PainelValorTotalDiarioUI().CriarPainel();

            this.Controls.Add(painelAgendamentosUI);
            this.Controls.Add(painelCanceladosDiaUI);
            this.Controls.Add(painelTotalAgendamentosUI);
            this.Controls.Add(painelValorTotalDiarioUI);
        }


        public void Interface(bool visivel)
        {
            painelAgendamentosUI.Visible = visivel;
            painelCanceladosDiaUI.Visible = visivel;
            painelTotalAgendamentosUI.Visible = visivel;
            painelValorTotalDiarioUI.Visible = visivel;

            iconButtonAtualizar.Visible = visivel;
        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            Interface(true);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
            this.Hide();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            Interface(false);

            FormAgendamento agendamento = new FormAgendamento();
            agendamento.MdiParent = this;
            agendamento.Show();
        }

        private void btnReagendamento_Click(object sender, EventArgs e)
        {
            Interface(false);
            FormReagendamento reagendamento = new FormReagendamento();
            reagendamento.MdiParent = this;
            reagendamento.Show();
        }

        private void RecarregarPaineis()
        {
            // Remove os antigos
            this.Controls.Remove(painelAgendamentosUI);
            this.Controls.Remove(painelCanceladosDiaUI);
            this.Controls.Remove(painelTotalAgendamentosUI);
            this.Controls.Remove(painelValorTotalDiarioUI);

            // Cria painéis novos
            painelAgendamentosUI = new PainelAgendamentosUI().CriarPainel();
            painelCanceladosDiaUI = new PainelCanceladosDiaUI().CriarPainel();
            painelTotalAgendamentosUI = new PainelTotalAgendamentosUI().CriarPainel();
            painelValorTotalDiarioUI = new PainelValorTotalDiarioUI().CriarPainel();

            // Adiciona novamente
            this.Controls.Add(painelAgendamentosUI);
            this.Controls.Add(painelCanceladosDiaUI);
            this.Controls.Add(painelTotalAgendamentosUI);
            this.Controls.Add(painelValorTotalDiarioUI);

            // Atualiza visualmente
            painelAgendamentosUI.Refresh();
            painelCanceladosDiaUI.Refresh();
            painelTotalAgendamentosUI.Refresh();
            painelValorTotalDiarioUI.Refresh();
        }

        private void iconButtonAtualizar_Click(object sender, EventArgs e)
        {
            RecarregarPaineis();
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            Interface(false);
            FormSituacao situacao = new FormSituacao();
            situacao.MdiParent = this;
            situacao.Show();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            FormDadosAgendamentos dadosAgendamentos = new FormDadosAgendamentos();
            dadosAgendamentos.Show();
            this.Hide();
        }
    }
}
