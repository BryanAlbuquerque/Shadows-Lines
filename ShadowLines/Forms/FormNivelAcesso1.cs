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

            this.Controls.Add(painelClientesUI);
            this.Controls.Add(painelValorHojeUI);
        }
        private void FormNivelAcesso0_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            painelClientesUI.BringToFront();
            painelValorHojeUI.BringToFront();
            Interface(true);
        }

        public void Interface(bool visivel)
        {
            painelClientesUI.Visible = visivel;
            painelValorHojeUI.Visible = visivel;


            //iconButtonAtualizar.Visible = visivel;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
