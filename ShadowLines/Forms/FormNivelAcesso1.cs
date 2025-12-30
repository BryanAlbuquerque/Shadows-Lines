using System;
using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.UI;

namespace ShadowLines.Forms
{
    public partial class FormNivelAcesso1 : Form
    {
        private Panel painelClientesUI;
        private Panel painelValorHojeUI;
        private Panel painelClientesDoDiaUI;

        private PainelClientesUI painelUI;
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

            painelUI = new PainelClientesUI(); 
            painelClientesUI = painelUI.CriarPainel();
            painelValorHojeUI = new PainelValorClientesUI().CriarPainel();
            painelClientesDoDiaUI = new PainelAgendamentosFuncionariosUI().CriarPainel();

            this.Controls.Add(painelClientesUI);
            this.Controls.Add(painelValorHojeUI);
            this.Controls.Add(painelClientesDoDiaUI);
        }
        private void FormNivelAcesso0_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";

            painelClientesUI.BringToFront();
            painelValorHojeUI.BringToFront();
            painelClientesDoDiaUI.BringToFront();

            iconButtonAtualizar.BringToFront();

            Interface(true);
        }

        public void Interface(bool visivel)
        {
            painelClientesUI.Visible = visivel;
            painelValorHojeUI.Visible = visivel;
            painelClientesDoDiaUI.Visible = visivel;

            //iconButtonAtualizar.Visible = visivel;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void iconButtonAtualizar_Click(object sender, EventArgs e)
        {
        }
    }
}
