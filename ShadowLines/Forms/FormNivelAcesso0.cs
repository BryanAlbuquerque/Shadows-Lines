using System;
using System.Drawing;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms
{
    public partial class FormNivelAcesso0 : Form
    {
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
        }
        private void FormNivelAcesso0_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
        }
    }
}
