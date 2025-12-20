using System;
using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.UI;

namespace ShadowLines.Forms
{
    public partial class FormNivelAcesso0 : Form
    {
        private Panel painelClientesUI;
        public FormNivelAcesso0()
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

            painelClientesUI = new PainelClientesUI().CriarPainel();

            this.Controls.Add(painelClientesUI);
        }
        private void FormNivelAcesso0_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";

            Interface(true);
        }

        public void Interface(bool visivel)
        {
            painelClientesUI.Visible = visivel;
            

            //iconButtonAtualizar.Visible = visivel;
        }

    }
}
