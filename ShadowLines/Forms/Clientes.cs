using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            txtNome.Visible = true;

            lblCPF.Visible = true;
            txtCPF.Visible = true;

            lblTelefone.Visible = true;
            txtTelefone.Visible = true;

            lblEmail.Visible = true;
            txtEmail.Visible = true;

            lblData.Visible = true;
            txtData.Visible = true;

            lblEnd.Visible = true;
            txtEnd.Visible = true;

            btnEnviar.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
