using ShadowLines.Classes;
using ShadowLines.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {
        private Panel painelAgendamentosUI;
        private Panel painelCanceladosDiaUI;
        private Panel painelTotalAgendamentosUI;
        private Panel painelValorTotalDiarioUI;

        public Menu01()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White; // cor que você quiser
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

        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            Interface(true);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
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
            // Mdi Form Reagendamentos
        }
    }
}
